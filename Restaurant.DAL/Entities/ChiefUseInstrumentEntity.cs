using System;

namespace Restaurant.DAL.Entities
{
    public class ChiefUseInstrumentEntity: BaseEntity<int>
    {
        public ChiefEntity Chief { get; set; }
        public InstrumentEntity Instrument { get; set; }
        public DateTime LastUsageTime { get; set; }
        public bool IsInstrumentReady { get; set; }
        
    }
}