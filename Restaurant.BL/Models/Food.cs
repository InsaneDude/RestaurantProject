namespace Restaurant.BL.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int CookingTime { get; set; }
        public string Ingredients { get; set; }
        public bool FoodNeedInstrument { get; set; }   
    }
}