namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Monitor;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class MonitorsController : BaseProductController<MonitorViewModel, MonitorFilterOptions>
    {
        public MonitorsController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}