using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
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

        public AdministrationController(ICraftBeerService craftBeerService)
        {
            this.craftBeerService = craftBeerService;
        }


        public IActionResult ProductsList() { return View(craftBeerService.GetBeers()); }

        //[HttpGet]
        //public IActionResult CreateProduct()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreateProduct(CreateProductViewModel model)
        //{
        //    if (model == null)
        //    {
        //        return View("NotFound");
        //    }
        //    product prod;
        //    if (model.name != null)
        //    {

        //        prod = new product() { name = model.name, categoryId = model.categoryId, longDesk = model.longDesk, shortDesk = model.shortDesk, price = model.price, rating = model.rating, img = model.img };
        //        dbCon.Products.Add(prod);
        //        int affectedRows = dbCon.SaveChanges();

        //        if (affectedRows > 0)
        //        {
        //            return RedirectToAction("ProductsList", "Products");
        //        }
        //        else
        //        {
        //            return View("Error");
        //        }
        //    }
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult EditProduct(int id = 0)
        //{
        //    var prod = dbCon.Products.FirstOrDefault(p => p.id == id);
        //    if (prod == null)
        //    {
        //        ViewBag.ErrorMessage = $"Продукту з id = {id} не знайдено";
        //        return View("NotFound");
        //    }

        //    var model = new EditProductViewModel { categoryId = prod.categoryId, longDesk = prod.longDesk, name = prod.name, price = prod.price, rating = prod.rating, img = prod.img, shortDesk = prod.shortDesk, id = prod.id };
        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult EditProduct(EditProductViewModel model)
        //{
        //    var product = dbCon.Products.FirstOrDefault(p => p.id == model.id);

        //    if (product == null)
        //    {

        //        ViewBag.ErrorMessage = $"Продукту з id = {model.id} не знайдено";
        //        return View("NotFound");
        //    }
        //    else
        //    {
        //        dbCon.Products.Find(model.id).img = model.img;
        //        dbCon.Products.Find(model.id).longDesk = model.longDesk;
        //        dbCon.Products.Find(model.id).name = model.name;
        //        dbCon.Products.Find(model.id).price = model.price;
        //        dbCon.Products.Find(model.id).rating = model.rating;
        //        dbCon.Products.Find(model.id).shortDesk = model.shortDesk;
        //        dbCon.Products.Find(model.id).categoryId = model.categoryId;
        //        dbCon.SaveChanges();
        //        return RedirectToAction("ProductsList");
        //    }
        //}


        //public IActionResult DeleteProduct(int id = 0)
        //{
        //    var prod = dbCon.Products.First(p => p.id == id);
        //    if (prod != null)
        //    {
        //        dbCon.Products.Remove(prod);
        //        dbCon.SaveChanges();
        //        return RedirectToAction("ProductsList");
        //    }
        //    ViewBag.ErrorMessage = $"Продукту з id = {id} не знайдено";
        //    return View("NotFound");
        //}



    }
}
