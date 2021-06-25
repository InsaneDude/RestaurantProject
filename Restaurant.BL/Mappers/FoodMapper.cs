using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.BL.Mappers
{
    public class FoodMapper : IFoodMapper
    {
        public FoodEntity convertToEntity(Food model)
        {
            return new FoodEntity { 
                Name = model.Name, 
                Weight = model.Weight, 
                CookingTime = model.CookingTime,
                Ingredients = model.Ingredients, 
                FoodNeedInstrument = model.FoodNeedInstrument, 
                Id = model.Id 
            };
        }

        public Food convertToModel(FoodEntity entity)
        {
            return new Food { 
                Name = entity.Name, 
                Weight = entity.Weight, 
                CookingTime = entity.CookingTime, 
                Ingredients = entity.Ingredients, 
                FoodNeedInstrument = entity.FoodNeedInstrument, 
                Id = entity.Id 
            };
        }
    }
}