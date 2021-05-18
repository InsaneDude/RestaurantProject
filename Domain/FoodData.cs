using System.Collections.Generic;

namespace Domain
{
    public class FoodData
    {
        private List<Food> _foodList = new List<Food>();

        public FoodData()
        {
            
        }
        
        public void AddFood(Food foodToAdd)
        {
            _foodList.Add(foodToAdd);
        }
        public List<Food> GetAllFoods()
        {
            return _foodList;
        }
    }
}