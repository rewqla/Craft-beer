using Craft_beer_backend.Entities;
using Craft_beer_backend.ViewModels;

namespace Craft_beer_backend.Services.Interfaces
{
    public interface IOrderService
    {
        public CartViewModel GetCartFromUri(string URI);
        public CheckoutViewModel PrepareOrderViewModel(string URI, long userId);
        public void Checkout(CheckoutViewModel model, string cartData, long userId);
        public string GenerateOrderUniqueId();
        public int GetCustomerId(CustomerViewModel model, long userId);
    }
}
