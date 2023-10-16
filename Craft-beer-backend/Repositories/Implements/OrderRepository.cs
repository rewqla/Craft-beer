using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

