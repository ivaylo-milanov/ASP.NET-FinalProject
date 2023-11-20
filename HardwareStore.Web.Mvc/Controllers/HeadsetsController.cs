namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Headset;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class HeadsetsController : BaseProductController<HeadsetViewModel, HeadsetFilterOptions>
    {
        public HeadsetsController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}