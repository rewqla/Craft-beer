using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
