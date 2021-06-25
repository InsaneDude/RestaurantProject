namespace Restaurant.DAL.Entities
{
    public class ChiefMakesOrderEntity: BaseEntity<int>
    {
        public ChiefUseInstrumentEntity ChiefUseInstrument { get; set; }
        public OrderEntity Order { get; set; }
        public bool FoodReady { get; set; }
    }
}