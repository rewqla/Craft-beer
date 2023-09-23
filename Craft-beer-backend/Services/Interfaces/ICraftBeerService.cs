using Craft_beer_backend.ViewModels;
using System.Collections.Generic;

namespace Craft_beer_backend.Services.Interfaces
{
    public interface ICraftBeerService
    {
        IEnumerable<CraftBeerViewModel> GetBeers();
    }

}
