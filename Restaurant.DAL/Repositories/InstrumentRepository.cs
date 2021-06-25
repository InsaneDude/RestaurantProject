using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class InstrumentRepository: GenericRepository<InstrumentEntity, int>, IInstrumentRepository
    {
        public InstrumentRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}