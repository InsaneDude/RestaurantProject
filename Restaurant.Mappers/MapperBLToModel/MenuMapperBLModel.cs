using System.Collections.Generic;
using Restaurant.Models;
using Restaurant.Mappers.MapperBLToModel.Interfaces;
using VModels.Models;


namespace Restaurant.Mappers.MapperBLToModel
{
    public class MenuMapperBLModel : IMenuMapperBLModel
    {
        private IFoodMapperBLModel _foodMapperBLModel;
        
        public MenuMapperBLModel(IFoodMapperBLModel foodMapperBLModel)
        {
            _foodMapperBLModel = foodMapperBLModel;
        }
        
        public MenuModel convertToModel(Menu mod)
        {
            return new MenuModel
            {
                FoodId = mod.FoodId,
                Food = _foodMapperBLModel.convertToModel(mod.Food),
                Id = mod.Id
            };
        }

        public Menu convertToBLMod(MenuModel model)
        {
            return new Menu
            {
                FoodId = model.FoodId,
                Food = _foodMapperBLModel.convertToBLMod(model.Food),
                Id = model.Id
            };
        }
    }
}