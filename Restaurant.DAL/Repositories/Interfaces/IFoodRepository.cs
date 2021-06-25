using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Repositories.Interfaces
{
    public interface IFoodRepository: IGenericRepository<FoodEntity, int> { }
}