﻿namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Services.Contracts;
    using HardwareStore.Core.ViewModels.Monitor;
    using Microsoft.AspNetCore.Mvc;

    public class MonitorsController : Controller
    {
        private readonly IProductService productService;

        public MonitorsController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await this.productService.GetModel<MonitorViewModel>();

            return View(model);
        }

        public IActionResult FilterMonitors([FromBody] MonitorFilterOptions filter)
        {
            IEnumerable<MonitorViewModel> filtered;
            try
            {
                filtered = this.productService.FilterProducts<MonitorViewModel, MonitorFilterOptions>(filter);
            }
            catch (ArgumentNullException)
            {
                throw;
            }

            return PartialView("_ProductsPartialView", filtered);
        }
    }
}