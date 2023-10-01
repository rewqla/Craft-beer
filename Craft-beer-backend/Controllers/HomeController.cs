using Craft_beer_backend.Entities;
using Craft_beer_backend.Models;
using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Craft_beer_backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICraftBeerService _craftBeerService;
        private List<string> productList;

        public HomeController(ILogger<HomeController> logger, ICraftBeerService craftBeerService)
        {
            _logger = logger;
            _craftBeerService = craftBeerService;
            productList = _craftBeerService.GetFullProducts().Select(p => p.Name).ToList();
        }

        public IActionResult Index()
        {
            var model = _craftBeerService.GetFullProducts();
            ViewBag.ProductList = productList;
            return View(model);
        }

        public IActionResult Privacy()
        {
            ViewBag.ProductList = productList;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
