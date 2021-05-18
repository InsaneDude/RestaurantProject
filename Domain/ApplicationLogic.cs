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
        
        public void ReserveFood(Food newFood)
        {
            return;
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