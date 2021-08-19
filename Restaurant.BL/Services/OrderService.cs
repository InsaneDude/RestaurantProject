using System;
using System.Collections.Generic;
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
        // ?

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            foreach (var orderNow in _unitOfWork.OrderRepository.GetAll())
            {
                orderList.Add(_orderMapper.convertToModel(orderNow));
            }
            // TODO LINQ замість циклу
            return orderList;
        }
        
        public Order AddOrder(int idToOrder)
        {
            Order newOrder = new Order();
            newOrder.OrderTime = DateTime.Now;
            for (int i = 1; i < _unitOfWork.FoodRepository.GetAll().Count + 1; i++)
            {
                if (idToOrder == i)
                {
                    newOrder.OrderedFood = _foodMapper.convertToModel(_unitOfWork.FoodRepository.Get(idToOrder));
                    break;
                }
            }
            // TODO переробити addOrder і цикл
            return newOrder;
        }
    }
}