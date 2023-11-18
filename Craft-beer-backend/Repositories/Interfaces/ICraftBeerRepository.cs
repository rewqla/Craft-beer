using Craft_beer_backend.Entities;
using System.Collections.Generic;

namespace Craft_beer_backend.Repositories.Interfaces
{
    public interface ICraftBeerRepository : IGenericRepository<CraftBeer>
    {
        public List<string> GetNames();
    }
}
