using Entities.Abstract;

namespace Entities
{
    public class FoodEntity : BaseEntity
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float CookingTime { get; set; }
        public int ChiefId { get; set; }
    }
}