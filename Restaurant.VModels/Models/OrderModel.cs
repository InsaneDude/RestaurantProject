using System;

namespace Restaurant.WPF.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public FoodModel OrderedFood { get; set; }
        public int OrderedFoodId { get; set; }        
        public DateTime OrderTime { get; set; }
        public ChiefModel ChiefToMakeOrder { get; set; }

    }
}