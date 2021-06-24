using Microsoft.Extensions.DependencyInjection;
using Restaurant.Services.Abstract;


namespace Restaurant.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection RegisterDAL(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IChiefMakesOrderService, ChiefMakesOrderService>();
            serviceCollection.AddScoped<IChiefUseInstrumentService, ChiefUseInstrumentService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            return serviceCollection;
        }
    }
}