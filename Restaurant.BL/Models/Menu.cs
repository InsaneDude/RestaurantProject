using System.Collections.Generic;

namespace Restaurant.BL.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}