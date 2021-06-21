using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class ChiefMakesFoodRepository: GenericRepository<ChiefMakesFoodEntity, int>, IChiefMakesFoodRepository
    {
        public ChiefMakesFoodRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}