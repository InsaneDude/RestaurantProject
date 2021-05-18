using System;
using Domain;

namespace RestaurantProject
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            ApplicationLogic appLogic = new ApplicationLogic();
            Console.WriteLine("Вітаємо вас у нашому ресторані."); 
            while (true)
            {
                Console.WriteLine("Якщо ви бажаєте переглянути меню - введіть цифру 1." +
                                  "\nЯкщо ви бажаєте замовити - введіть цифру 2." +
                                  "\nЯкщо ви закінчили роботу з програмою - введіть цифру 3.");
                int inputedNumber = Convert.ToInt32(Console.ReadLine());
                switch (inputedNumber)
                {
                    case 1:
                        Console.WriteLine("Пока что тут ничего нету" + "\n");
                        break;
                    case 2:
                        foreach (var selectedChief in appLogic.GetAllChiefs())
                        {
                            Console.WriteLine(selectedChief.Name);
                        }
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("test" + "\n");

                        break;
                    case 4:
                        Console.WriteLine("Завершуємо роботу." + "\n");
                        break;
                    default:
                        Console.WriteLine("Введіть одну із вищевказаних цифер" + "\n");
                        break;
                }
            }
        }
    }
}