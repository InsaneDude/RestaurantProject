using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class ChiefUseInstrumentRepository: GenericRepository<ChiefUseInstrumentEntity, int>, IChiefUseInstrumentRepository
    {
        public ChiefUseInstrumentRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}