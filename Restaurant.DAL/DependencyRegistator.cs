using Restaurant.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Restaurant.DAL
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddScoped<RestaurantDBContext>();
            serviceCollection.AddScoped<IChiefRepository, ChiefRepository>();
            serviceCollection.AddScoped<IChiefMakesOrderRepository, IChiefMakesOrderRepository>();
            serviceCollection.AddScoped<IChiefUseInstrumentRepository, ChiefUseInstrumentRepository>();
            serviceCollection.AddScoped<IMenuRepository, MenuRepository>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddScoped<IFoodRepository, FoodRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}