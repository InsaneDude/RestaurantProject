using Entities;
using Restaurant.Models;

namespace Restaurant.Mappers
{
    public static class FoodMapper
    {
        public static FoodEntity convertToEntity(this Food model)
        {
            return new FoodEntity { Name = model.Name, Weight = model.Weight, CookingTime = model.CookingTime, 
                                    Ingredients = model.Ingredients, FoodNeedInstrument = model.FoodNeedInstrument, 
                                    Id = model.Id };
        }

        public static Food convertToModel(this FoodEntity entity)
        {
            return new Food { Name = entity.Name, Weight = entity.Weight, CookingTime = entity.CookingTime, 
                              Ingredients = entity.Ingredients, FoodNeedInstrument = entity.FoodNeedInstrument, 
                              Id = entity.Id };
        }
    }
}