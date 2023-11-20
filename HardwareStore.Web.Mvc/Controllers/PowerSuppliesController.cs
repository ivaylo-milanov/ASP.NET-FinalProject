namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.PowerSupply;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class PowerSuppliesController : BaseProductController<PowerSupplyViewModel, PowerSupplyFilterOptions>
    {
        public PowerSuppliesController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}
