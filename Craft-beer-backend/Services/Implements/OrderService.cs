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
        private readonly UserManager<DbUser> _userManager;
        public OrderService(IMapper mapper, IDeliveryCompanyRepository deliveryCompanyRepository,
            ICustomerInfoRepository customerInfoRepository, UserManager<DbUser> userManager, 
            IDeliveryAddressRepository deliveryAddressRepository = null)
        {
            _mapper = mapper;
            _deliveryCompanyRepository = deliveryCompanyRepository;
            _customerInfoRepository = customerInfoRepository;
            _userManager = userManager;
            _deliveryAddressRepository = deliveryAddressRepository;
        }

        public ClaimsPrincipal User { get; private set; }

        public string GenerateOrderUniqueId()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        public CartViewModel GetCartFromUri(string URI)
        {
            var decodedModelJson = Uri.UnescapeDataString(URI);

            return JsonSerializer.Deserialize<CartViewModel>(decodedModelJson);
        }

        public OrderViewModel PrepareOrderViewModel(string URI, long userId)
        {
            var model = new OrderViewModel();

            model = _mapper.Map(GetCartFromUri(URI),model);
            model.Delivery = _mapper.Map<DeliveryViewModel>(_deliveryCompanyRepository.GetAll().Select(x => x.Name).ToList());
            model.Customers = _mapper.Map<List<CustomerViewModel>>(_customerInfoRepository.GetAll().Where(x => x.DbUserId == userId).ToList());
            //model.Customers = new List<CustomerViewModel>();

            return model;
        }
    }
}
