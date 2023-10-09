using System.Collections.Generic;

namespace Craft_beer_backend.ViewModels
{
    public class OrderInfoViewModel
    {
        public string UniqueCode { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public DeliveryViewModel Delivery { get; set; }
        public CustomerViewModel Customer { get; set; }
        public List<CartItemViewModel> Items { get; set; }
    }
}
