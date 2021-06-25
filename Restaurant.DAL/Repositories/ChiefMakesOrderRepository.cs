using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class ChiefMakesOrderRepository: GenericRepository<ChiefMakesOrderEntity, int>, IChiefMakesOrderRepository
    {
        public ChiefMakesOrderRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}