using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class ChiefRepository: GenericRepository<ChiefEntity, int>, IChiefRepository
    {
        public ChiefRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}