using AutoMapper;
using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;
using Craft_beer_backend.Services.Interfaces;
using Craft_beer_backend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;

namespace Craft_beer_backend.Services.Implements
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IDeliveryCompanyRepository _deliveryCompanyRepository;
        private readonly IDeliveryAddressRepository _deliveryAddressRepository;
        private readonly ICustomerInfoRepository _customerInfoRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;
        private readonly IOrderItemRepository _orderItem;
        private readonly ICraftBeerRepository _craftBeerRepository;
        public OrderService(IMapper mapper, IDeliveryCompanyRepository deliveryCompanyRepository,
            ICustomerInfoRepository customerInfoRepository, IDeliveryAddressRepository deliveryAddressRepository,
            IOrderRepository orderRepository, IOrderStatusRepository orderStatusRepository, 
            IOrderItemRepository orderItem, ICraftBeerRepository craftBeerRepository, IOrderItemRepository orderItemRepository)
        {
            _mapper = mapper;
            _deliveryCompanyRepository = deliveryCompanyRepository;
            _customerInfoRepository = customerInfoRepository;
            _deliveryAddressRepository = deliveryAddressRepository;
            _orderRepository = orderRepository;
            _orderStatusRepository = orderStatusRepository;
            _orderItem = orderItem;
            _craftBeerRepository = craftBeerRepository;
            _orderItemRepository = orderItemRepository;
        }


        public void Checkout(CheckoutViewModel model, string cartData, long userId)
        {
            model.Order = new OrderViewModel()
            {
                Cart = JsonSerializer.Deserialize<CartViewModel>(cartData)
            };

            var address = _mapper.Map<DeliveryAddress>(model.Delivery);
            address.DeliveryCompanyId = _deliveryCompanyRepository.GetAll().FirstOrDefault(x => x.Name == model.Delivery.Company).Id;
            _deliveryAddressRepository.Add(address);

            var order = new Order()
            {
                UniqueCode = GenerateOrderUniqueId(),
                Date = DateTime.Now.ToString(),
                OrderStatusId = 3,
                DeliveryAddressId = address.Id,
                CustomerInfoId = GetCustomerId(model.Customer, userId),
                DbUserId = userId,
            };

            _orderRepository.Add(order);

            foreach (var item in model.Order.Cart.Items)
            {
                _orderItem.Add(new OrderItem
                {
                    ItemPrice = item.Price,
                    Count = item.Count,
                    CraftBeerId = _craftBeerRepository.GetAll()
                        .FirstOrDefault(x => x.Name == item.Name && x.Volume == item.Volume).Id,
                    OrderId = order.Id,
                });
            }
        }

        public string GenerateOrderUniqueId()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        public CartViewModel GetCartFromUri(string URI)
        {
            var decodedModelJson = Uri.UnescapeDataString(URI);

            return JsonSerializer.Deserialize<CartViewModel>(decodedModelJson);
        }

        public int GetCustomerId(CustomerViewModel model, long userId)
        {
            var customer = _customerInfoRepository.GetAll().FirstOrDefault
                (x => x.FirstName == model.FirstName && x.LastName == model.LastName && x.Phone == model.Phone);

            if (customer != null)
            {
                return customer.Id;
            }

            customer = _mapper.Map<CustomerInfo>(model);
            customer.DbUserId = userId;
            _customerInfoRepository.Add(customer);

            return customer.Id;
        }

        public OrderInfoViewModel GetOrderDetails(string uniqueCode)
        {
            var order=_orderRepository.GetAll().FirstOrDefault(x => x.UniqueCode == uniqueCode);

            var customerInfo = _customerInfoRepository.FindById(order.CustomerInfoId);
            var deliveryAddress = _deliveryAddressRepository.FindById(order.DeliveryAddressId);

            var items = _orderItemRepository.GetAll().Where(x=>x.OrderId==order.Id).Select(item=>new CartItemViewModel
            {
                Count = item.Count,
                Price = item.ItemPrice,
                Image = _craftBeerRepository.FindById(item.CraftBeerId).ImageUrl,
                Name = _craftBeerRepository.FindById(item.CraftBeerId).Name,
                Volume = _craftBeerRepository.FindById(item.CraftBeerId).Volume
            }).ToList();

            var model = new OrderInfoViewModel
            {
                UniqueCode = uniqueCode,
                Date = order.Date,
                Status = _orderStatusRepository.FindById(order.OrderStatusId).Name,
                Customer = _mapper.Map<CustomerViewModel>(customerInfo),
                Delivery = _mapper.Map<DeliveryViewModel>(deliveryAddress),
                Items = items
            };
            model.Delivery.Company = _deliveryCompanyRepository.FindById(deliveryAddress.DeliveryCompanyId).Name;


            return model;
        }

        public List<OrderShortInfoViewModel> GetUserOrders(long userId)
        {
            var orders = _orderRepository.GetAll().Where(x => x.DbUserId == userId)
                .Select(item => new OrderShortInfoViewModel
                {
                    Status = _orderStatusRepository.FindById(item.OrderStatusId).Name,
                    UniqueCode = item.UniqueCode,
                    Date=item.Date,
                }).ToList();

            return orders;
        }

        public OrderViewModel PrepareOrderViewModel(string URI, long userId)
        {
            var model = new OrderViewModel();

            model.Cart = _mapper.Map<CartViewModel>(GetCartFromUri(URI));
            model.Customers = _mapper.Map<List<CustomerViewModel>>(_customerInfoRepository.GetAll().Where(x => x.DbUserId == userId).ToList());
            model.Companies = _deliveryCompanyRepository.GetAll().Select(x => x.Name).ToList();

            return model;
        }
    }
}
