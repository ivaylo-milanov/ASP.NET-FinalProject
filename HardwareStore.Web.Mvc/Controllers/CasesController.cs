namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Case;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class CasesController : BaseProductController<CaseViewModel, CaseFilterOptions>
    {
        public CasesController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}
