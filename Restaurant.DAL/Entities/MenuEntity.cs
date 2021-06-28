using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class MenuEntity: BaseEntity<int>
    {
        public int FoodId { get; set; }
        public FoodEntity Food { get; set; }
    }
}