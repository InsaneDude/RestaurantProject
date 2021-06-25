using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class MenuRepository : GenericRepository<MenuEntity, int>, IMenuRepository
    {
        public MenuRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}