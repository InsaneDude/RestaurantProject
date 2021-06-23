namespace Restaurant.Models
{
    public class ChiefMakesFood
    {
        public int Id { get; set; }
        public Chief Chief { get; set; }
        public Food Food { get; set; }
    }
}