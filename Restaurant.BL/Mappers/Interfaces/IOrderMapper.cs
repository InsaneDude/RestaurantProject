using Restaurant.BL.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.BL.Mappers.Interfaces
{
    public interface IOrderMapper : IMapper<OrderEntity, Order> { }
}