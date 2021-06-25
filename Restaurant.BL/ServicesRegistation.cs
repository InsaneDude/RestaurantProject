using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL.Services;
using Restaurant.BL.Services.Abstract;


namespace Restaurant.BL
{
    public static class ServicesRegistration
    {
        public static IServiceCollection RegisterBL(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IChiefMakesOrderService, ChiefMakesOrderService>();
            serviceCollection.AddScoped<IChiefUseInstrumentService, ChiefUseInstrumentService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            return serviceCollection;
        }
    }
}