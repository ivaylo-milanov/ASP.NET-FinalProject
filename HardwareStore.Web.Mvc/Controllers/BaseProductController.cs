namespace HardwareStore.Web.Mvc.Controllers
{
    using HardwareStore.Controllers;
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Product;
    using Microsoft.AspNetCore.Mvc;

    public abstract class BaseProductController<TEntity, TFilter> : Controller
        where TEntity : ProductViewModel
        where TFilter : ProductFilterOptions
    {
        private readonly IProductService productService;
        private readonly ILogger<CasesController> logger;

        protected BaseProductController(IProductService productService, ILogger<CasesController> logger)
        {
            this.productService = productService;
            this.logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ProductsViewModel<TEntity> model;
            try
            {
                model = await this.productService.GetModel<TEntity>();
            }
            catch (ArgumentException ex)
            {
                this.logger.LogError(ex, ex.Message);
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }

            return View(model);
        }

        public IActionResult FilterProducts([FromBody] TFilter filter)
        {
            IEnumerable<TEntity> filtered;
            try
            {
                filtered = this.productService.FilterProducts<TEntity, TFilter>(filter);
            }
            catch (ArgumentNullException ex)
            {
                this.logger.LogError(ex, ex.Message);
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }

            return PartialView("_ProductsPartialView", filtered);
        }
    }
}
