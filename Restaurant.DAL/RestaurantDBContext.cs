using System.Data.Entity;
using Restaurant.DAL.Entities;


namespace Restaurant.DAL
{
    public class RestaurantDBContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
        
        public RestaurantDBContext() : base("RestaurantDBConnStr") { }
        public DbSet<ChiefEntity> Chiefs { get; set; }
        public DbSet<ChiefMakesOrderEntity> ChiefsMakeOrder { get; set; }
        public DbSet<ChiefUseInstrumentEntity> ChiefsUseInstrument { get; set; }
        public DbSet<InstrumentEntity> Instruments { get; set; }
        public DbSet<FoodEntity> Foods { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
    }
}