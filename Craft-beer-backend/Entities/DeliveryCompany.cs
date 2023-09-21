using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class DeliveryCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DeliveryAddress> DeliveryAddresses { get; set; }
    }
}
