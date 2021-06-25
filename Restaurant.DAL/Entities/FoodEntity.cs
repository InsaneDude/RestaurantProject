namespace Restaurant.DAL.Entities
{
    public class FoodEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float CookingTime { get; set; }
        public string Ingredients { get; set; }
        public bool FoodNeedInstrument { get; set; }
    }
}