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

            CreateMap<CraftBeer, FullProductViewModel>();
            CreateMap<DeliveryViewModel, DeliveryAddress>();
            CreateMap<DeliveryAddress, DeliveryViewModel>();
            CreateMap<CustomerViewModel, CustomerInfo>();
            CreateMap<CustomerInfo, CustomerViewModel>();
        }
    }
}