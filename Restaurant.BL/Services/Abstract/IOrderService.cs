using System.Collections.Generic;
using Restaurant.BLModels.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order AddOrder(int id);
    }
}