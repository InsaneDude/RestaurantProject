using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        private IFoodMapper _foodMapper;

        public OrderMapper(IFoodMapper foodMapper)
        {
            _foodMapper = foodMapper;
        }
        public OrderEntity convertToEntity(Order model)
        {
            return new OrderEntity
            {
                OrderedFood = _foodMapper.convertToEntity(model.OrderedFood),
                OrderTime = model.OrderTime, 
                Id = model.Id
            };
        }
        public Order convertToModel(OrderEntity entity)
        {
            return new Order
            {
                OrderedFood = _foodMapper.convertToModel(entity.OrderedFood),
                OrderTime = entity.OrderTime, 
                Id = entity.Id
            };
        }
    }
}