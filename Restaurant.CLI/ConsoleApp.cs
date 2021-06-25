using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL;

namespace Restaurant.CLI
{
    public class ConsoleApp
    {
        private readonly ServiceProvider serviceProvider;

        public ConsoleApp()
        {
            var services = new ServiceCollection();
            services.RegisterDAL();
            services.RegisterBL();
            serviceProvider = services.BuildServiceProvider();
        }

        public void RunConsoleApp()
        {
            Console.WriteLine("Работает!");
            IOrderService orderService = serviceProvider.GetRequiredService<IOrderService>();
            List<Order> OrderList = orderService.GetAllOrders();
            foreach (var order in OrderList)
            {
                Console.WriteLine($"Заказ №, {order.Id}. Время выполнения заказа : {order.OrderTime}");
            }
            Console.WriteLine("И тут работает!");
        }
    }
}