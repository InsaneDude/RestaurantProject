using System.Collections.Generic;

namespace Domain
{
    public class Food
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float CookingTime { get; set; }
        public int ChiefId { get; set; }
        public bool FoodNeedsInstrument { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int Id { get; set; }
    }
}
