namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Keyboard;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class KeyboardsController : BaseProductController<KeyboardViewModel, KeyboardFilterOptions>
    {
        public KeyboardsController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}
