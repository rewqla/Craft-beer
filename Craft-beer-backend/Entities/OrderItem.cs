namespace Craft_beer_backend.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int CraftBeerId { get; set; }
        public CraftBeer CraftBeer { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public double ItemPrice { get; set; }
        public int Count { get; set; }
    }
}
