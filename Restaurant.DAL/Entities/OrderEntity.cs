using System;
using System.Collections.Generic;

namespace Entities
{
    public class OrderEntity: BaseEntity<int>
    {
        public List<FoodEntity> OrderedFood { get; set; }
        public DateTime OrderTime { get; set; }
    }
}