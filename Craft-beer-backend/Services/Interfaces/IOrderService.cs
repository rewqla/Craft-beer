using Craft_beer_backend.ViewModels;

namespace Craft_beer_backend.Services.Interfaces
{
    public interface IOrderService
    {
        public CartViewModel GetCartFromUri(string URI);
        public OrderViewModel PrepareOrderViewModel(string URI, long userId);
        public string GenerateOrderUniqueId();
    }
}
