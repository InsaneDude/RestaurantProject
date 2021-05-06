using System.Collections.Generic;

namespace Domain
{
    public class Chief
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public List<Food> FoodList { get; set; }
    }
}