using System.Data.Entity;
using Entities;

namespace Restaurant.DAL
{
    public class RestaurantDBContext: DbContext
    {
        public RestaurantDBContext() : base("RestaurantDB") { }
        public DbSet<ChiefEntity> Chiefs { get; set; }
        public DbSet<ChiefMakesFoodEntity> ChiefsMakeFood { get; set; }
        public DbSet<ChiefUseInstrumentEntity> ChiefsUseInstrument { get; set; }
        public DbSet<InstrumentEntity> Instruments { get; set; }
        public DbSet<FoodEntity> Foods { get; set; }
    }
}