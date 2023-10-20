using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
using Craft_beer_backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Craft_beer_backend.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ICraftBeerService craftBeerService;
        private readonly IOrderService _orderService;

        public AdministrationController(ICraftBeerService craftBeerService, IOrderService orderService)
        {
            this.craftBeerService = craftBeerService;
            _orderService = orderService;
        }


        public IActionResult ProductsList() { return View(craftBeerService.GetFullProducts()); }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(FullProductViewModel model)
        {
            if (model == null)
            {
                return View("NotFound");
            }
            if (model.Name != null)
            {
                craftBeerService.AddProduct(model);
                return RedirectToAction("ProductsList", "Administration");
            }
            else
            {
                ViewBag.ErrorMessage = $"Ім'я товару повинне бути вказане обов'язково";
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult EditProduct(int id = 0)
        {
            var product = craftBeerService.GetFullProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                ViewBag.ErrorMessage = $"Продукту з id = {id} не знайдено";
                return View("Error");
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(FullProductViewModel model)
        {
            var product = craftBeerService.GetFullProducts().FirstOrDefault(p => p.Id == model.Id);

            if (product == null)
            {
                ViewBag.ErrorMessage = $"Продукту з id = {model.Id} не знайдено";
                return View("Error");
            }
            else
            {
                model.OrderItems = product.OrderItems;
                craftBeerService.UpdateProduct(model);
                return RedirectToAction("ProductsList");
            }
        }


        public IActionResult DeleteProduct(int id = 0)
        {
            if (craftBeerService.GetFullProducts().Any(p => p.Id == id))
            {
                craftBeerService.DeleteProduct(id);
                return RedirectToAction("ProductsList");
            }
            ViewBag.ErrorMessage = $"Продукту з id = {id} не знайдено";
            return View("Error");
        }

        public IActionResult ListOrders()
        {
            var model = _orderService.GetOrders();

            return View(model);
        }

        public IActionResult OrderDetails(string uniqueCode)
        {
            var model = _orderService.GetOrderDetails(uniqueCode);

            return View(model);
        }
        [HttpPost]
        public IActionResult ChangeStatus(string uniqueCode, string status)
        {
            _orderService.ChangeStatus(uniqueCode,status);

            return RedirectToAction("OrderDetails", "Administration", new { uniqueCode = uniqueCode });
        }
    }
}
