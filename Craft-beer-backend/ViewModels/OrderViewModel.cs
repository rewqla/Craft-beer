using System.Collections.Generic;

namespace Craft_beer_backend.ViewModels
{
    public class OrderViewModel
    {
        public List<string> Companies { get; set; }
        public List<CustomerViewModel> Customers { get; set; }
        public CartViewModel Cart { get; set; }
    }
}
