using System.Collections.Generic;
using Restaurant.BL.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order CreateOrder(int id);
    }
}