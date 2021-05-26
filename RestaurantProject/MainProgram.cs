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
                        appLogic.ShowMenu();
                        break;
                    case 2:
                        Console.WriteLine(appLogic.Ordering());
                        Console.WriteLine("");
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