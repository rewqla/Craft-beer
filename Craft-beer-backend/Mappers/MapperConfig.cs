using AutoMapper;
using Craft_beer_backend.Entities;
using Craft_beer_backend.Models;

namespace Craft_beer_backend.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CraftBeer, CraftBeerViewModel>();
        }
    }
}
