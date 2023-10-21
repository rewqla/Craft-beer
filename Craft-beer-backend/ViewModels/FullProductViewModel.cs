using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Craft_beer_backend.ViewModels
{
    public class FullProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double Volume { get; set; }
        public double Rating { get; set; }
        public double ABV { get; set; }
        public IEnumerable<Entities.OrderItem> OrderItems { get; set; }
    }
}
