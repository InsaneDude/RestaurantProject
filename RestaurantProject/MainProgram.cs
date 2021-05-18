using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Domain;
using Entities;

namespace RestaurantProject
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            ApplicationLogic appLogic = new ApplicationLogic();
            Console.WriteLine("Приветствуем Вас в нашем ресторане."); 
            while (true)
            {
                Console.WriteLine("Если Вы желаете посмотреть меню - введите цифру 1." +
                                  "\nЕсли Вы желаете заказать что-либо - введите цифру 2." +
                                  "\nЕсли вы закончили работу с программой - введите цифру 3.");
                int inputedNumber = Convert.ToInt32(Console.ReadLine());
                switch (inputedNumber)
                {
                    case 1:
                        Console.WriteLine("Меню : ");
                        foreach (var selectedFood in appLogic.GetAllFoods())
                        {
                            Console.WriteLine($"№{selectedFood.Id} : {selectedFood.Name}, порция весит {selectedFood.Weight} грамм, время ожидания {selectedFood.CookingTime} секунд.");
                        }
                        Console.WriteLine();
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