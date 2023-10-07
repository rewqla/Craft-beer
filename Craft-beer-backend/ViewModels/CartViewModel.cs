using System.Collections.Generic;

namespace Craft_beer_backend.ViewModels
{

    public class CartViewModel
    {
        public List<CartItemViewModel> Items { get; set; }
        public double TotalPrice { get; set; }
    }
    public class CartItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
