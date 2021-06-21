using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class ChiefUseInstrumentRepository: GenericRepository<ChiefUseInstrumentEntity, int>, IChiefUseInstrumentRepository
    {
        public ChiefUseInstrumentRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}