using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class CraftBeer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double Volume { get; set; }
        public double ABV { get; set; } // Alcohol By Volume percentage
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
