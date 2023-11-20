namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Cooler;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class CoolersController : BaseProductController<CoolerViewModel, CoolerFilterOptions>
    {
        public CoolersController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}