using System;
using System.Collections.Generic;

namespace Domain
{
    public class Menu
    {
        private List<Food> _foodList = new List<Food>();

        public Menu()
        {
            Food meatSoup = new Food()
            {
                Name = "Суп", Id = 1, Weight = 750, ChiefId = 0, CookingTime = 2400, FoodNeedsInstrument = true,
                ListOfIngredients = {Ingredient.Carrot, Ingredient.Meat, Ingredient.Water, 
                    Ingredient.Potato, Ingredient.Bread}
            };
            AddFood(meatSoup);
            
            Food pastaWithCheese = new Food()
            {
                Name = "Паста с сыром", Id = 2, Weight = 500, ChiefId = 0, CookingTime = 300, FoodNeedsInstrument = false,
                ListOfIngredients = {Ingredient.Pasta, Ingredient.Cheese}
            };
            AddFood(pastaWithCheese);
            
            Food vegetableSalad = new Food()
            {
                Name = "Овощной салат", Id = 3, Weight = 1000, ChiefId = 0, CookingTime = 450, FoodNeedsInstrument = false,
                ListOfIngredients =
                {Ingredient.Carrot, Ingredient.Potato, Ingredient.Tomato, 
                    Ingredient.Cucumber, Ingredient.Cabbage}
            };
            AddFood(vegetableSalad);
            
            Food fruitPie = new Food()
            {
                Name = "Фруктовый пирог", Id = 4, Weight = 1500, ChiefId = 0, CookingTime = 1800, FoodNeedsInstrument = true,
                ListOfIngredients = {Ingredient.Apple, Ingredient.Flour, Ingredient.Strawberry, Ingredient.Cherry}
            };
            AddFood(fruitPie);

            Food water = new Food()
            {
                Name = "Вода", Id = 5, Weight = 500, ChiefId = 0, CookingTime = 0, FoodNeedsInstrument = false,
                ListOfIngredients = {Ingredient.Water}
            };
            AddFood(water);
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