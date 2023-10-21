using Craft_beer_backend.ViewModels;
﻿using Craft_beer_backend.Entities;
using System.Collections.Generic;

namespace Craft_beer_backend.Services.Interfaces
{
    public interface ICraftBeerService
    {
        IEnumerable<CraftBeerViewModel> GetBeers();
        IEnumerable<FullProductViewModel> GetFullProducts();
        FullProductViewModel GetFullProductById(int id);
        FullProductViewModel GetFullProductById(string id);
        void AddProduct(FullProductViewModel model);
        void UpdateProduct(FullProductViewModel model);
        void DeleteProduct(CraftBeer product);
        void DeleteProduct(int productId);
    }
}
