using System;

namespace Entities
{
    public class ChiefUseInstrumentEntity: BaseEntity<int>
    {
        public ChiefEntity Chief { get; set; }
        public InstrumentEntity Instrument { get; set; }
        public DateTime LastUsageTime { get; set; }
        public bool IsInstrumentReady { get; set; }
        public bool IsInstrumentFree { get; set; }
    }
}