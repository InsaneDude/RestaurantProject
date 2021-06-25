using System.Collections.Generic;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;


namespace Restaurant.BL.Services
{
    public class OrderService: IOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IOrderMapper _orderMapper;

        public OrderService(IUnitOfWork unitOfWork, IOrderMapper orderMapper)
        {
            _unitOfWork = unitOfWork;
            _orderMapper = orderMapper;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            foreach (var orderNow in _unitOfWork.OrderRepository.GetAll())
            {
                orderList.Add(_orderMapper.convertToModel(orderNow));
            }
            return orderList;
            // return null;
            // Argument type 'Restaurant.DAL.Entities.OrderEntity' is not assignable to parameter type 'Entities.OrderEntity'

        }
        // public Order CreateOrder()
        // {
        //     Order NewOrder = new Order();
        //     NewOrder.OrderTime = DateTime.Now;
        //     // NewOrder.OrderedFood
        // }
    }
}