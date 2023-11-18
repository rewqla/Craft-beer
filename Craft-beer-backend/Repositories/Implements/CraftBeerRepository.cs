using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Craft_beer_backend.Repositories.Implements
{
    public class CraftBeerRepository : GenericRepository<CraftBeer>, ICraftBeerRepository
    {
        private DbContextOptions<ApplicationDbContext> options;
        public CraftBeerRepository(ApplicationDbContext context, DbContextOptions<ApplicationDbContext> options) : base(context)
        {
            this.options = options;
        }

        public List<string> GetNames()
        {
           return new ApplicationDbContext(options).CraftBeers.Select(p=>p.Name).ToList();
        }
    }
}

