using System;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
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
            IChiefService chiefService = 
                serviceProvider.GetRequiredService<IChiefService>();
            IMenuService menuService =
                serviceProvider.GetRequiredService<IMenuService>();
            Console.WriteLine("Приветствуем Вас в нашем ресторане.");
            while (true)
            {
                Console.WriteLine("Если Вы желаете посмотреть меню - введите цифру 1." +
                                  "\nЕсли Вы желаете заказать что-либо - введите цифру 2." +
                                  "\nЕсли Вы закончили работу с программой - введите цифру 3.");
                Console.WriteLine("");
                int inputedNumber = Convert.ToInt32(Console.ReadLine());
                switch (inputedNumber)
                {
                    case 1:
                        Console.WriteLine("Меню : ");
                        for (int i = 0; i < menuService.ShowMenu().Count; i++)
                        {
                            Console.WriteLine($"Блюдо #{menuService.ShowMenu()[i].Id}" +
                                              $" {menuService.ShowMenu()[i].Name}, " +
                                              $"весит {menuService.ShowMenu()[i].Weight}. " +
                                              $"Ингредиенты : {menuService.ShowMenu()[i].Ingredients}.");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер блюда, которое Вы желаете заказать : ");
                        int foodToOrderNum = Convert.ToInt32(Console.ReadLine());
                        if (foodToOrderNum > menuService.ShowMenu().Count || foodToOrderNum < 1)
                        {
                            Console.WriteLine("Такого блюда не существует.");
                            break;
                        }
                        Console.WriteLine($"Заказ будет выполнен в : {chiefService.CountingFinalTime(orderService.AddOrder(foodToOrderNum))}");
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