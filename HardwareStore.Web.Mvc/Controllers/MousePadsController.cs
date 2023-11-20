namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.MousePad;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class MousePadsController : BaseProductController<MousePadViewModel, MousePadFilterOptions>
    {
        public MousePadsController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}
