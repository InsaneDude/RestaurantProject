using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Food> FoodList { get; set; }
    }
}