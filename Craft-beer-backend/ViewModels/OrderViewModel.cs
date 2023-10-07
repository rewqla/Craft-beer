using System.Collections.Generic;

namespace Craft_beer_backend.ViewModels
{
    public class OrderViewModel
    {
        public DeliveryViewModel Delivery { get; set; }
        public List<CustomerViewModel> Customers { get; set; }
        public CustomerViewModel SelectedCustomer { get; set; }
        public CartViewModel Cart { get; set; }
        public long UserId { get; set; }
    }
    public class DeliveryViewModel
    {
        public string City { get; set; }
        public string Address { get; set; }
        public List<string> Companies { get; set; }
        public string SelectedCompany { get; set; }

    }

    public class CustomerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

    }
}
