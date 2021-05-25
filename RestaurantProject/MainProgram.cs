using System;
using System.Net.Mime;
using Domain;

namespace RestaurantProject
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            ApplicationLogic appLogic = new ApplicationLogic();
            MenuList menuLogic = new MenuList();
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
                        menuLogic.ShowMenu();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер блюда, которое Вы желаете заказать : ");
                        int counter = 0;
                        foreach (var selectedFood in appLogic.GetAllFoods())
                        {
                            counter++;
                            Console.WriteLine($"{counter} : {selectedFood.Name}");
                        }
                        int foodSelectionNumber = Convert.ToInt32(Console.ReadLine());
                        Food gettingFoodToServe = appLogic.GetAllFoods()[foodSelectionNumber-1];
                        Console.WriteLine(gettingFoodToServe.Name);
                        appLogic.ReserveFood(gettingFoodToServe);
                        break;
                    case 3:
                        Console.WriteLine("Завершение работы программы.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Введите одну из вышеуказанных цифер" + "\n");
                        break;
                }
            }
        }
    }
}