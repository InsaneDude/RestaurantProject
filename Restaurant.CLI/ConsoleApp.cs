using System;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL;

namespace Restaurant.CLI
{
    public class ConsoleApp
    {
        private readonly ServiceProvider _serviceProvider;

        public ConsoleApp()
        {
            var services = new ServiceCollection();
            services.RegisterDAL();
            services.RegisterBL();
            _serviceProvider = services.BuildServiceProvider();
        }

        public void RunConsoleApp()
        {
            IOrderService orderService = 
                _serviceProvider.GetRequiredService<IOrderService>();
            IChiefService chiefService = 
                _serviceProvider.GetRequiredService<IChiefService>();
            IMenuService menuService =
                _serviceProvider.GetRequiredService<IMenuService>();
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
                            StringBuilder menuOutput = new StringBuilder();
                            menuOutput.AppendFormat("Блюдо #{0} : ", menuService.ShowMenu()[i].Id);
                            menuOutput.AppendFormat("{0}, ", menuService.ShowMenu()[i].Name);
                            menuOutput.AppendFormat("весит {0}. ", menuService.ShowMenu()[i].Weight);
                            menuOutput.AppendFormat("Ингредиенты : {0}.", menuService.ShowMenu()[i].Ingredients);
                            // menuOutput.Append($"Блюдо #{menuService.ShowMenu()[i].Id}" +
                            //                   $" {menuService.ShowMenu()[i].Name}, " +
                            //                   $"весит {menuService.ShowMenu()[i].Weight}. " +
                            //                   $"Ингредиенты : {menuService.ShowMenu()[i].Ingredients}.");
                            Console.WriteLine(menuOutput);
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
                        Console.WriteLine("Заказ будет выполнен в : " +
                                          $"{chiefService.CountingFinalTime(orderService.AddOrder(foodToOrderNum))}");
                        break;
                    case 3:
                        Console.WriteLine("Завершение работы программы.");
                        return;
                }
            }
        } 
    } 
}