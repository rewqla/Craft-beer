﻿using AutoMapper;
using Craft_beer_backend.Entities;
using Craft_beer_backend.Models;
using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
using Craft_beer_backend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Craft_beer_backend.Services.Implements
{

    public class CraftBeerService : ICraftBeerService
    {
        private readonly ICraftBeerRepository _craftBeerRepository;
        private readonly IMapper _mapper;

        public CraftBeerService(ICraftBeerRepository craftBeerRepository, IMapper mapper)
        {
            _craftBeerRepository = craftBeerRepository;
            _mapper = mapper;
        }

        public IEnumerable<CraftBeerViewModel> GetBeers()
        {
            return _mapper.Map<IEnumerable<CraftBeerViewModel>>(_craftBeerRepository.GetAll());
        }

        public IEnumerable<FullProductViewModel> GetFullProducts()
        {
            return _mapper.Map<IEnumerable<FullProductViewModel>>(_craftBeerRepository.GetAll());
        }
        public FullProductViewModel GetProductById(int id)=> _mapper.Map<FullProductViewModel>(_craftBeerRepository.FindById(id));
        public FullProductViewModel GetProductById(string id)
        {
            int intId = 0;

            try
            {
                intId = Int32.Parse(id);
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            return _mapper.Map<FullProductViewModel>(_craftBeerRepository.FindById(intId));
        }

        public void AddProduct(FullProductViewModel model)
        {
            _craftBeerRepository.Add(new CraftBeer { ABV=model.ABV, Description=model.Description, ImageUrl=model.ImageUrl, Name=model.Name, Price=model.Price, Volume=model.Volume, Rating=model.Rating});
        }
        public void UpdateProduct(FullProductViewModel model)
        {
            _craftBeerRepository.Update(new CraftBeer { Id=model.Id, ABV = model.ABV, Description = model.Description, ImageUrl = model.ImageUrl, Name = model.Name, Price = model.Price, Volume = model.Volume, OrderItems=model.OrderItems, Rating = model.Rating });
        }
        public void DeleteProduct(CraftBeer product)
        {
            _craftBeerRepository.Delete(product);
        }
        public void DeleteProduct(int productId)
        {
            _craftBeerRepository.Delete(_craftBeerRepository.FindById(productId));
        }

    }
}
