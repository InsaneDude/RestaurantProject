using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class MenuRepository : GenericRepository<MenuEntity, int>, IMenuRepository
    {
        public MenuRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}