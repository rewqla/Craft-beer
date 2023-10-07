﻿using Craft_beer_backend.Services.Interfaces;
using Craft_beer_backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
namespace Craft_beer_backend.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Index(string cartModel)
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = _orderService.PrepareOrderViewModel(cartModel, long.Parse(userId));

            return View(model);
        }
    }
}