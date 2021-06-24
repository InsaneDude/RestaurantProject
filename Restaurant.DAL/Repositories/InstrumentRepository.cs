using Entities;
using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class InstrumentRepository: GenericRepository<InstrumentEntity, int>, IInstrumentRepository
    {
        public InstrumentRepository(RestaurantDBContext context) : base(context)
        {
        }
    }
}