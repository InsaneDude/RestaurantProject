using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL.Mappers;
using Restaurant.BL.Mappers.Interfaces;
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
            serviceCollection.AddScoped<IFoodMapper, FoodMapper>();
            serviceCollection.AddScoped<IMenuMapper, MenuMapper>();
            serviceCollection.AddScoped<IOrderMapper, OrderMapper>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
            serviceCollection.AddScoped<IChiefService, ChiefService>();
            serviceCollection.AddScoped<IInstrumentService, InstrumentService>();
            serviceCollection.AddScoped<IMenuService, MenuService>();
            return serviceCollection;
        }
    }
}