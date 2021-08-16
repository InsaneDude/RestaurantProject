using System;

namespace Restaurant.DAL.Entities
{
    public class OrderEntity: BaseEntity<int>
    {
        public FoodEntity OrderedFood { get; set; }
        public int OrderedFoodId { get; set; }
        public DateTime OrderTime { get; set; }
        public ChiefEntity ChiefToMakeOrder { get; set; }
    }
}