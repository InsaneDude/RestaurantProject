using System;

namespace Restaurant.BL.Models
{
    public class ChiefUseInstrument
    {
        public int Id { get; set; }
        public Chief Chief { get; set; }
        public Instrument Instrument { get; set; }
        public DateTime LastUsageTime { get; set; }
        public bool IsInstrumentReady { get; set; }
    }
}