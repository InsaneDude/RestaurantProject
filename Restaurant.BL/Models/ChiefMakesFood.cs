namespace Restaurant.Models
{
    public class ChiefMakesOrder
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public ChiefUseInstrument ChiefUseInstrument { get; set; }
        public bool FoodReady { get; set; }
    }
}