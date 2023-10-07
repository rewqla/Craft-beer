using System;
using System.Collections.Generic;

namespace Craft_beer_backend.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UniqueCode { get; set; }
        public string Date { get; set; }
        public DbUser DbUser { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int CustomerInfoId { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public int DeliveryAddressId { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
