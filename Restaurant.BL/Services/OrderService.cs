using System;
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
            foreach (var orderNow in _unitOfWork.OrderRepository.GetAll())
            {
                orderList.Add(_orderMapper.convertToModel(orderNow));
            }
            return orderList;
        }
        
        public Order AddOrder(int idToOrder)
        {
            Order newOrder = new Order();
            newOrder.OrderTime = DateTime.Now;
            newOrder.OrderedFood = new Food();
            for (int i = 0; i < _unitOfWork.FoodRepository.GetAll().Count; i++)
            {
                if (idToOrder == i)
                {
                    newOrder.OrderedFood = _foodMapper.convertToModel(_unitOfWork.FoodRepository.Get(idToOrder));
                }
            }
            return newOrder;
        }
    }
}