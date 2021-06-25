using System.Collections.Generic;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public static class MenuMapper
    {
        public static MenuEntity convertToEntity(this Menu model)
        {
            // List<MenuEntity> menuList = new List<MenuEntity>();
            // model.FoodList.ForEach(i Menu => menuList.Add(i.convertToEntity()));
            // return new MenuEntity
            // {
            //     
            // };
            return null;
        }

        public static Menu convertToModel(this MenuEntity entity)
        {
            return new Menu
            { 
                // TODO realiz
            };
        }
    }
}