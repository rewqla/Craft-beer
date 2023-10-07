﻿using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class CustomerInfoRepository : GenericRepository<CustomerInfo>, ICustomerInfoRepository
    {
        public CustomerInfoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

