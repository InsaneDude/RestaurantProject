using System.Collections.Generic;

namespace Restaurant.DAL.Entities
{
    public class MenuEntity: BaseEntity<int>
    {
        public List<FoodEntity> FoodList { get; set; }
    }
}