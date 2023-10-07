using AutoMapper;
using Craft_beer_backend.Entities;
using Craft_beer_backend.ViewModels;
using System.Collections.Generic;

namespace Craft_beer_backend.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CraftBeer, CraftBeerViewModel>();
            CreateMap<CartViewModel, OrderViewModel>()
                .ForMember(dest => dest.Cart, opt => opt.MapFrom(src => src));
            CreateMap<CustomerViewModel, CustomerInfo>();
            CreateMap<List<string>, DeliveryViewModel>()
                .ForMember(dest => dest.Companies, opt => opt.MapFrom(src => src));

            CreateMap<CraftBeer, FullProductViewModel>();
        }
    }
}