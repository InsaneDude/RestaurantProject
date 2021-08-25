using System;
using System.Data.Entity;
using Restaurant.DAL.Entities;


namespace Restaurant.DAL
{
    public class RestaurantDBContext: DbContext
    {
        class MyContextInitializer : DropCreateDatabaseAlways<RestaurantDBContext>
        {
            protected override void Seed(RestaurantDBContext db)
            {
                FoodEntity food1 = new FoodEntity {Name = "Вода", Ingredients = "вода", Weight = 200, CookingTime = 20, FoodNeedInstrument = false};
                FoodEntity food2 = new FoodEntity {Name = "Суп", Ingredients = "вода, картошка, мясо, морковь", Weight = 500, CookingTime = 400, FoodNeedInstrument = true};
                FoodEntity food3 = new FoodEntity {Name = "Піцца", Ingredients = "тесто, сыр, мясо, кетчуп", Weight = 500, CookingTime = 400, FoodNeedInstrument = true};

                ChiefEntity chief1 = new ChiefEntity { Instrument = null, Level = 1, Name = "Kalh", IsFree = true};
                ChiefEntity chief2 = new ChiefEntity { Instrument = null, Level = 2, Name = "Valeska", IsFree = true};
                ChiefEntity chief3 = new ChiefEntity { Instrument = null, Level = 3, Name = "Neela", IsFree = true};
                
                InstrumentEntity instrument1 = new InstrumentEntity { IsInstrumentFree = true, Name = "instr1", WarmingTime = 500, LastUsageTime = DateTime.Now};
                InstrumentEntity instrument2 = new InstrumentEntity { IsInstrumentFree = true, Name = "instr2", WarmingTime = 300, LastUsageTime = DateTime.Now};
                InstrumentEntity instrument3 = new InstrumentEntity { IsInstrumentFree = true, Name = "instr3", WarmingTime = 700, LastUsageTime = DateTime.Now};

                db.Foods.Add(food1);
                db.Foods.Add(food2);
                db.Chiefs.Add(chief1);
                db.Chiefs.Add(chief2);
                db.Instruments.Add(instrument1);
                db.Instruments.Add(instrument2);
                db.SaveChanges();
            }
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<RestaurantDBContext>(new MyContextInitializer());
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }

        public RestaurantDBContext() : base("RestaurantDBConnStr") { }
        public DbSet<ChiefEntity> Chiefs { get; set; }
        public DbSet<InstrumentEntity> Instruments { get; set; }
        public DbSet<FoodEntity> Foods { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
    }
}