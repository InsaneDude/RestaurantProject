using System;

namespace Domain
{
    public class MenuList
    {
        ApplicationLogic menuLogic = new ApplicationLogic();
        public void ShowMenu()
        {
            Console.WriteLine("Меню : ");
            foreach (var selectedFood in menuLogic.GetAllFoods())
            {
                Console.WriteLine($"№{selectedFood.Id} : {selectedFood.Name}, порция весит {selectedFood.Weight} грамм, время ожидания {selectedFood.CookingTime} секунд.");
            }
            Console.WriteLine();
        }
    }
}