using System;
using System.Collections.Generic;
using Entities;

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
                    Console.WriteLine("true");
                    break;
                case false:
                    Console.WriteLine("false");
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
        
        // public void PreparingInstrumentForWork(int id)
        // {
        //     UsedInstrumentData.UpdateInstrument();
        // }
    }
}