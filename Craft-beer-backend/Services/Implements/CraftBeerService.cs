using AutoMapper;
using Craft_beer_backend.ViewModels;
using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
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
    }
}
