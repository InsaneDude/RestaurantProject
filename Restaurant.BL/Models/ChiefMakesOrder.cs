namespace Restaurant.BL.Models
{
    public class ChiefMakesOrder
    {
        public int Id { get; set; }
        public Chief Chief { get; set; }
        public int ChiefId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public bool FoodReady { get; set; }
    }
}