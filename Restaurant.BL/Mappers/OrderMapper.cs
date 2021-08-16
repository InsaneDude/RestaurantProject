using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        private IFoodMapper _foodMapper;
        private IChiefMapper _chiefMapper;

        public OrderMapper(IFoodMapper foodMapper, IChiefMapper chiefMapper)
        {
            _foodMapper = foodMapper;
            _chiefMapper = chiefMapper;
        }
        public OrderEntity convertToEntity(Order model)
        {
            return new OrderEntity
            {
                OrderedFood = _foodMapper.convertToEntity(model.OrderedFood),
                OrderTime = model.OrderTime,
                Id = model.Id,
                ChiefToMakeOrder = _chiefMapper.convertToEntity(model.ChiefToMakeOrder)
            };
        }
        public Order convertToModel(OrderEntity entity)
        {
            return new Order
            {
                OrderedFood = _foodMapper.convertToModel(entity.OrderedFood),
                OrderTime = entity.OrderTime, 
                Id = entity.Id,
                ChiefToMakeOrder = _chiefMapper.convertToModel(entity.ChiefToMakeOrder),
            };
        }
    }
}