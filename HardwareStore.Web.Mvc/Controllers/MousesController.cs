namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Mouse;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class MousesController : BaseProductController<MouseViewModel, MouseFilterOptions>
    {
        public MousesController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}