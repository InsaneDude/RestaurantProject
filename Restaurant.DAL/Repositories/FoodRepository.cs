using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class FoodRepository: GenericRepository<FoodEntity, int>, IFoodRepository
    {
        public FoodRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}