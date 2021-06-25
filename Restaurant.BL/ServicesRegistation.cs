using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL.Mappers;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services;
using Restaurant.BL.Services.Abstract;


namespace Restaurant.BL
{
    public static class ServicesRegistration
    {
        public static IServiceCollection RegisterBL(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IChiefMakesOrderMapper, ChiefMakesOrderMapper>();
            serviceCollection.AddScoped<IInstrumentMapper, InstrumentMapper>();
            serviceCollection.AddScoped<IChiefMapper, ChiefMapper>();
            serviceCollection.AddScoped<IChiefUseInstrumentMapper, ChiefUseInstrumentMapper>();
            serviceCollection.AddScoped<IFoodMapper, FoodMapper>();
            serviceCollection.AddScoped<IMenuMapper, MenuMapper>();
            serviceCollection.AddScoped<IOrderMapper, OrderMapper>();
            serviceCollection.AddScoped<IChiefMakesOrderService, ChiefMakesOrderService>();
            serviceCollection.AddScoped<IChiefUseInstrumentService, ChiefUseInstrumentService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            return serviceCollection;
        }
    }
}