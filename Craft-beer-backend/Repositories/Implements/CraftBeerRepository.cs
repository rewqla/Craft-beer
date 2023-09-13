using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class CraftBeerRepository : GenericRepository<CraftBeer>, ICraftBeerRepository
    {
        public CraftBeerRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

