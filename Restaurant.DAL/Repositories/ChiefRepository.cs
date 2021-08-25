using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class ChiefRepository: GenericRepository<ChiefEntity, int>, IChiefRepository
    {
        public ChiefRepository(RestaurantDBContext context) : base(context)
        {
            
        }
    }
}