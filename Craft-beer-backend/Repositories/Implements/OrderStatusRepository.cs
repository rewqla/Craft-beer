﻿using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class OrderStatusRepository : GenericRepository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

