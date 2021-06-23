using Restaurant.Services.Abstract;


namespace Restaurant.Services
{
    public static class ServicesRegistration
    {
        public static void RegisterDAL(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<RestaurantDBContext>();
            serviceCollection.AddScoped<IChiefMakesOrderService, ChiefMakesOrderService>();
            serviceCollection.AddScoped<IChiefUseInstrumentService, ChiefUseInstrumentService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
        }
    }
}