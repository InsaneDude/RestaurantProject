using Restaurant.Mappers.MapperBLToModel.Interfaces;
using Restaurant.BLModels.Models;
using Restaurant.WPF.Models;


namespace Restaurant.Mappers.MapperBLToModel
{
    public class FoodMapperBLModel : IFoodMapperBLModel
    {
        public FoodModel convertToModel(Food mod)
        {
            return new FoodModel
            { 
                Name = mod.Name, 
                Weight = mod.Weight, 
                CookingTime = mod.CookingTime,
                Ingredients = mod.Ingredients, 
                FoodNeedInstrument = mod.FoodNeedInstrument, 
                Id = mod.Id 
            };
        }

        public Food convertToBLMod(FoodModel model)
        {
            return new Food
            { 
                Name = model.Name, 
                Weight = model.Weight, 
                CookingTime = model.CookingTime, 
                Ingredients = model.Ingredients, 
                FoodNeedInstrument = model.FoodNeedInstrument, 
                Id = model.Id 
            };
        }
    }
}