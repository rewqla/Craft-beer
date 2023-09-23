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


        public HomeController(ILogger<HomeController> logger, ICraftBeerService craftBeerService)
        {
            _logger = logger;
            _craftBeerService = craftBeerService;
        }

        public IActionResult Index()
        {
            var model = _craftBeerService.GetBeers();
            return View(model);
        }
        [Route("/shopping-cart")]
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
