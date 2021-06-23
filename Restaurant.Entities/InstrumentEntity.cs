namespace Entities
{
    public class InstrumentEntity: BaseEntity<int>
    {
        public string Name { get; set; }
        public int WarmingTime { get; set; }
    }
}