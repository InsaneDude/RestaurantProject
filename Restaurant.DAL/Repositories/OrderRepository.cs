using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class OrderRepository : GenericRepository<OrderEntity, int>, IOrderRepository
    {
        public OrderRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}