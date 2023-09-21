namespace Craft_beer_backend.Entities
{
    public class DeliveryAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int DeliveryCompanyId { get; set; }
        public DeliveryCompany DeliveryCompany { get; set; }
    }
}
