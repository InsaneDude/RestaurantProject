namespace Entities
{
    public class ChiefMakesFoodEntity: BaseEntity<int>
    {
        public int ChiefId { get; set; }
        public int FoodId { get; set; }
        public ChiefEntity Chief { get; set; }
        public FoodEntity Food { get; set; }
    }
}