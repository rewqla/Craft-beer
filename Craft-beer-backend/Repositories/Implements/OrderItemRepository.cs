using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

