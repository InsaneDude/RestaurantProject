using System;
using System.Collections.Generic;

namespace Domain
{
    public class ApplicationLogic : IApplicationLogic
    {
        private ChiefData UsedChiefData;
        private InstrumentData UsedInstrumentData;
        private Menu UsedMenu;

        public ApplicationLogic()
        {
            UsedChiefData = new ChiefData();
            UsedInstrumentData = new InstrumentData();
            UsedMenu = new Menu();
        }
        
        public float ReserveFood(Food reservedFood)
        {
            float timeToCook = 0;
            switch (reservedFood.FoodNeedsInstrument)
            {
                case true:
                    Console.WriteLine("Для даного типа еды нужен инструмент.");
                    List<Chief> chiefToSelectPlus = UsedChiefData.GetAllChiefs();
                    List<Instrument> instrumentToSelect = UsedInstrumentData.GetAllInstruments();
                    foreach (var checkingFurnace in instrumentToSelect)
                    {
                        if (checkingFurnace.IsFree == true)
                        {
                            Console.WriteLine($"На разогрев {checkingFurnace.Name} уйдёт {checkingFurnace.WarmingTime} секунд");
                            timeToCook += checkingFurnace.WarmingTime;
                            break;
                        }
                    }

                    foreach (var checkingChief in chiefToSelectPlus)
                    {
                        if (checkingChief.IsFree == true)
                        {
                            checkingChief.IsFree = false;
                            timeToCook += reservedFood.CookingTime / checkingChief.ChiefLevel;
                            Console.WriteLine($"Шеф {checkingChief.Name} приступил к работе. ");
                            checkingChief.IsFree = true;
                            break;
                        }
                    }
                    break;
                
                case false:
                    Console.WriteLine("Для даного типа еды не нужен инструмент.");
                    List<Chief> chiefToSelectMinus = UsedChiefData.GetAllChiefs();
                    foreach (var checkingChief in chiefToSelectMinus)
                    {
                        if (checkingChief.IsFree == true)
                        {
                            checkingChief.IsFree = false;
                            timeToCook += reservedFood.CookingTime / checkingChief.ChiefLevel;
                            Console.WriteLine($"Шеф {checkingChief.Name} приступил к работе. ");
                            checkingChief.IsFree = true;
                            break;
                        }
                    }
                    break;
            }
            return timeToCook;
        }
        
        public void ShowMenu()
        {
            Console.WriteLine("Меню : ");
            foreach (var selectedFood in GetAllFoods())
            {
                Console.WriteLine(
                    $"№{selectedFood.Id} : {selectedFood.Name}, порция весит {selectedFood.Weight} грамм, время ожидания {selectedFood.CookingTime} секунд.");
            }
            Console.WriteLine();
        }

        public string Ordering()
        {
            Console.WriteLine("Введите номер блюда, которое Вы желаете заказать : ");
            int counter = 0;
            foreach (var selectedFood in UsedMenu.GetAllFoods())
            {
                counter++;
                Console.WriteLine($"{counter} : {selectedFood.Name}");
            }
            int foodSelectionNumber = Convert.ToInt32(Console.ReadLine());
            Food gettingFoodToServe = UsedMenu.GetAllFoods()[foodSelectionNumber-1];
            string timeToWaitForOrder = $"Блюдо {gettingFoodToServe.Name} будет готово через " +
                              $"{ReserveFood(gettingFoodToServe)} секунд.";
            return timeToWaitForOrder;
        }
        public List<Chief> GetAllChiefs()
        {
            return UsedChiefData.GetAllChiefs();
        }
        
        public List<Food> GetAllFoods()
        {
            return UsedMenu.GetAllFoods();
        }
        
        public List<Instrument> GetAllInstruments()
        {
            return UsedInstrumentData.GetAllInstruments();
        }
    }
}