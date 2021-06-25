using Restaurant.DAL.Entities;

namespace Restaurant.DAL.Repositories.Interfaces
{
    public interface IOrderRepository: IGenericRepository<OrderEntity, int> { }
}