namespace Entities
{
    public class ChiefUseInstrumentEntity: BaseEntity<int>
    {
        public int ChiefId { get; set; }
        public int InstrumentId { get; set; }
        public ChiefEntity Chief { get; set; }
        public InstrumentEntity Instrument { get; set; }
    }
}