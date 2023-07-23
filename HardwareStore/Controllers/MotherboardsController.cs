﻿namespace HardwareStore.Controllers
{
    using HardwareStore.Core.Services.Contracts;
    using HardwareStore.Core.ViewModels.Motherboard;
    using Microsoft.AspNetCore.Mvc;

    public class MotherboardsController : Controller
    {
        private readonly IProductService productService;

        public MotherboardsController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await this.productService.GetModel<MotherboardViewModel>();

            return View(model);
        }

        public IActionResult FilterMotherboards([FromBody] MotherboardFilterOptions filter)
        {
            IEnumerable<MotherboardViewModel> filtered;
            try
            {
                filtered = this.productService.FilterProducts<MotherboardViewModel, MotherboardFilterOptions>(filter);
            }
            catch (ArgumentNullException)
            {
                throw;
            }

            return PartialView("_ProductsPartialView", filtered);
        }
    }
}