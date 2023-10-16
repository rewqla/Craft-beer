namespace Craft_beer_backend.ViewModels
{
    public class CheckoutViewModel
    {
        public CardViewModel Card { get; set; }
        public OrderViewModel Order { get; set; }
        public DeliveryViewModel Delivery { get; set; }
        public CustomerViewModel Customer { get; set; }

    }
}
