using System.Collections.Generic;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        private IFoodMapper _foodMapper;
        public OrderEntity convertToEntity(Order model)
        {
            List<FoodEntity> foodList = new List<FoodEntity>();
            model.OrderedFood.ForEach(i => foodList.Add(_foodMapper.convertToEntity(i)));
            return new OrderEntity
            {
                OrderedFood = foodList,
                OrderTime = model.OrderTime, 
                Id = model.Id
            };
        }
        public Order convertToModel(OrderEntity entity)
        {
            List<Food> foodList = new List<Food>();
            entity.OrderedFood.ForEach(i=> foodList.Add(_foodMapper.convertToModel(i)));
            return new Order
            {
                OrderedFood = foodList,
                OrderTime = entity.OrderTime, 
                Id = entity.Id
            };
        }
    }
}