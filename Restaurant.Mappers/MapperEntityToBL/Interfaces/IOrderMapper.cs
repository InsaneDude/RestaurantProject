using Restaurant.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.Mappers.MapperEntityToBL.Interfaces
{
    public interface IOrderMapper : IMapper<OrderEntity, Order> { }
}