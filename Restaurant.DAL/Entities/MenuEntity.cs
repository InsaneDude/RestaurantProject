using System.Collections.Generic;

namespace Entities
{
    public class MenuEntity: BaseEntity<int>
    {
        public List<FoodEntity> FoodList { get; set; }
    }
}