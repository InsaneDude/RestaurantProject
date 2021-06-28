namespace Restaurant.DAL.Entities
{
    public class ChiefMakesOrderEntity: BaseEntity<int>
    {
        public ChiefEntity Chief { get; set; }
        public int ChiefId { get; set; }
        public OrderEntity Order { get; set; }
        public int OrderId { get; set; }
        public bool FoodReady { get; set; }
    }
}