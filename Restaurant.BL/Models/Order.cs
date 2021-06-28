using System;

namespace Restaurant.BL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Food OrderedFood { get; set; }
        public int OrderedFoodId { get; set; }        
        public DateTime OrderTime { get; set; }
    }
}