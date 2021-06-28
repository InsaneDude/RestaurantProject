using System.Collections.Generic;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public class MenuMapper : IMenuMapper
    {
        private IFoodMapper _foodMapper;
        
        public MenuMapper(IFoodMapper foodMapper)
        {
            _foodMapper = foodMapper;
        }
        public MenuEntity convertToEntity(Menu model)
        {
            return new MenuEntity
            {
                FoodId = model.FoodId,
                Food = _foodMapper.convertToEntity(model.Food),
                Id = model.Id
            };
        }

        public Menu convertToModel(MenuEntity entity)
        {
            return new Menu
            {
                FoodId = entity.FoodId,
                Food = _foodMapper.convertToModel(entity.Food),
                Id = entity.Id
            };
        }
    }
}