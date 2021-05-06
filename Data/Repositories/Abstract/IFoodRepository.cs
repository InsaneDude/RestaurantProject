using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IFoodRepository
    {
        void AddFood(FoodEntity food);
        void UpdateChief(FoodEntity food);
        List<FoodEntity> GetAllFood();
        void DeleteFoodById(int id);
    }
}