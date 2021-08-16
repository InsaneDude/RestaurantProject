using System.Collections.Generic;

namespace Restaurant.WPF.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public FoodModel Food { get; set; }
    }
}