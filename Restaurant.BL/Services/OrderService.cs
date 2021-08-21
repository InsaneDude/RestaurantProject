using System;
using System.Collections.Generic;
using System.Linq;
using Restaurant.BL.Services.Abstract;
using Restaurant.Models;
using Restaurant.DAL.Repositories.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;


namespace Restaurant.BL.Services
{
    public class OrderService: IOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IOrderMapper _orderMapper;
        private IFoodMapper _foodMapper;

        public OrderService(IUnitOfWork unitOfWork, IOrderMapper orderMapper, IFoodMapper foodMapper)
        {
            _unitOfWork = unitOfWork;
            _orderMapper = orderMapper;
            _foodMapper = foodMapper;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            _unitOfWork.OrderRepository.GetAll().ForEach(orderNow => orderList.Add(_orderMapper.convertToModel(orderNow)));
            return orderList;
        }
        
        public Order AddOrder(int idToOrder)
        {
            Order newOrder = new Order();
            newOrder.OrderTime = DateTime.Now;
            newOrder.OrderedFood = _foodMapper.convertToModel(_unitOfWork.FoodRepository
                .GetAll()
                .FirstOrDefault(selectedFood => selectedFood.Id == idToOrder));
            return newOrder;
        }
    }
}