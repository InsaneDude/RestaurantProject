using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class OrderRepository : GenericRepository<OrderEntity, int>, IOrderRepository
    {
        public OrderRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}