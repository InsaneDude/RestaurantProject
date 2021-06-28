using System;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services;
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
            IOrderService orderService = 
                serviceProvider.GetRequiredService<IOrderService>();
            IChiefMakesOrderService chiefMakesOrderService =
                serviceProvider.GetRequiredService<IChiefMakesOrderService>();
            IChiefUseInstrumentService chiefUseInstrumentService =
                serviceProvider.GetRequiredService<IChiefUseInstrumentService>();
            Console.WriteLine("Приветствуем Вас в нашем ресторане.");
            while (true)
            {
                Console.WriteLine("Если Вы желаете посмотреть меню - введите цифру 1." +
                                  "\nЕсли Вы желаете заказать что-либо - введите цифру 2." +
                                  "\nЕсли вы закончили работу с программой - введите цифру 3.");
                Console.WriteLine("");
                int inputedNumber = Convert.ToInt32(Console.ReadLine());
                switch (inputedNumber)
                {
                    case 1:
                        Console.WriteLine("Меню : ");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер блюда, которое Вы желаете заказать : ");
                        int foodToOrderNum = Convert.ToInt32(Console.ReadLine());
                        chiefMakesOrderService.ChiefIsMakingOrder(
                            chiefUseInstrumentService.ChiefUseInstrumentNow(), 
                            orderService.CreateOrder(foodToOrderNum));
                        break;
                    case 3:
                        Console.WriteLine("Завершение работы программы.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }       
}
