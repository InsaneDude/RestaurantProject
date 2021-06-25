using System;
using System.Collections.Generic;

namespace Restaurant.BL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Food> OrderedFood { get; set; }
        public DateTime OrderTime { get; set; }
    }
}