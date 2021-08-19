using Restaurant.Models;
using Restaurant.Mappers.MapperBLToModel.Interfaces;
using VModels.Models;


namespace Restaurant.Mappers.MapperBLToModel
{
    public class OrderMapperBLModel : IOrderMapperBLModel
    {
        private IFoodMapperBLModel _foodMapperBLModel;
        private IChiefMapperBLModel _chiefMapperBLModel;

        public OrderMapperBLModel(
            IFoodMapperBLModel foodMapperBLModel, 
            IChiefMapperBLModel chiefMapperBLModel)
        {
            _foodMapperBLModel = foodMapperBLModel;
            _chiefMapperBLModel = chiefMapperBLModel;
        }
        public OrderModel convertToModel(Order mod)
        {
            return new OrderModel
            {
                OrderedFood = _foodMapperBLModel.convertToModel(mod.OrderedFood),
                OrderTime = mod.OrderTime,
                Id = mod.Id,
                ChiefToMakeOrder = _chiefMapperBLModel.convertToModel(mod.ChiefToMakeOrder)
            };
        }
        public Order convertToBLMod(OrderModel model)
        {
            return new Order
            {
                OrderedFood = _foodMapperBLModel.convertToBLMod(model.OrderedFood),
                OrderTime = model.OrderTime, 
                Id = model.Id,
                ChiefToMakeOrder = _chiefMapperBLModel.convertToBLMod(model.ChiefToMakeOrder),
            };
        }
    }
}