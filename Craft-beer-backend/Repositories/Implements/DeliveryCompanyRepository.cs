using Craft_beer_backend.Entities;
using Craft_beer_backend.Repositories.Interfaces;

namespace Craft_beer_backend.Repositories.Implements
{
    public class DeliveryCompanyRepository : GenericRepository<DeliveryCompany>, IDeliveryCompanyRepository
    {
        public DeliveryCompanyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

