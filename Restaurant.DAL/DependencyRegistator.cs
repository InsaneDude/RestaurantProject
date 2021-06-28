using Microsoft.Extensions.DependencyInjection;
using Restaurant.DAL.Repositories;
using Restaurant.DAL.Repositories.Interfaces;


namespace Restaurant.DAL
{
    public static class DependencyRegistrator
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection serviceCollection) 
        {
            serviceCollection.AddScoped<RestaurantDBContext>();
            serviceCollection.AddScoped<IChiefRepository, ChiefRepository>();
            serviceCollection.AddScoped<IMenuRepository, MenuRepository>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
            serviceCollection.AddScoped<IFoodRepository, FoodRepository>();
            serviceCollection.AddScoped<IInstrumentRepository, InstrumentRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}