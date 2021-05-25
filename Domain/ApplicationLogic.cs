using System;
using System.Collections.Generic;

namespace Domain
{
    public class ApplicationLogic
    {
        private ChiefData UsedChiefData;
        private FoodData UsedFoodData;
        private InstrumentData UsedInstrumentData;

        public ApplicationLogic()
        {
            UsedChiefData = new ChiefData();
            UsedFoodData = new FoodData();
            UsedInstrumentData = new InstrumentData();
        }
        
        public void ReserveFood(Food reservedFood)
        {
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
                            Console.WriteLine($"Разогреваем {checkingFurnace.Name}");
                            while (checkingFurnace.TimeToBecomeHeated != 1800)
                            {
                                checkingFurnace.TimeToBecomeHeated++;
                            }
                            Console.WriteLine($"{checkingFurnace.Name} готова к использованию");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("На данный момент нету свободной печи для приготовления чего-либо. " +
                                              "Закажите что-то, что не требует печь.");
                            return;
                        }
                    }

                    foreach (var checkingChief in chiefToSelectPlus)
                    {
                        if (checkingChief.IsFree == true)
                        {
                            checkingChief.IsFree = false;
                            Console.WriteLine($"Шеф {checkingChief.Name} приступил к работе. " +
                                              $"Блюдо {reservedFood.Name} будет приготовлено через " +
                                              $"{reservedFood.CookingTime / checkingChief.ChiefLevel} секунд.");
                            Console.WriteLine($"Блюдо {reservedFood.Name} приготовлено. " +
                                              $"Шеф {checkingChief.Name} свободен.");
                            checkingChief.IsFree = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("На данный момент нету свободных шефов. Подождите, пока один из них " +
                                              "освободится.");
                        }
                    }
                    Console.WriteLine("");
                    break;
                
                case false:
                    Console.WriteLine("Для даного типа еды не нужен инструмент.");
                    List<Chief> chiefToSelectMinus = UsedChiefData.GetAllChiefs();
                    foreach (var checkingChief in chiefToSelectMinus)
                    {
                        if (checkingChief.IsFree == true)
                        {
                            checkingChief.IsFree = false;
                            Console.WriteLine($"Шеф {checkingChief.Name} приступил к работе. " +
                                              $"Блюдо {reservedFood.Name} будет приготовлено через " +
                                              $"{reservedFood.CookingTime / checkingChief.ChiefLevel} секунд.");
                            Console.WriteLine($"Блюдо {reservedFood.Name} приготовлено. " +
                                              $"Шеф {checkingChief.Name} свободен.");
                            checkingChief.IsFree = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("На данный момент нету свободных шефов. Подождите, пока один из них " +
                                              "освободится.");
                        }
                    }
                    Console.WriteLine("");
                    break;
            }
        }
        
        public List<Chief> GetAllChiefs()
        {
            return UsedChiefData.GetAllChiefs();
        }
        
        public List<Food> GetAllFoods()
        {
            return UsedFoodData.GetAllFoods();
        }
        
        public List<Instrument> GetAllInstruments()
        {
            return UsedInstrumentData.GetAllInstruments();
        }
    }
}