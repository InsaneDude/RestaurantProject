using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class FoodRepository: GenericRepository<FoodEntity, int>, IFoodRepository
    {
        public FoodRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}