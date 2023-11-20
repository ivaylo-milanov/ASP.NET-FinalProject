namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Contracts;
    using HardwareStore.Core.ViewModels.Processor;
    using HardwareStore.Web.Mvc.Controllers;
    using Microsoft.Extensions.Logging;

    public class ProcessorsController : BaseProductController<ProcessorViewModel, ProcessorFilterOptions>
    {
        public ProcessorsController(IProductService productService, ILogger<CasesController> logger)
            : base(productService, logger)
        {
        }
    }
}
