using System;

namespace Restaurant.DAL.Entities
{
    public class InstrumentEntity: BaseEntity<int>
    {
        public string Name { get; set; }
        public int WarmingTime { get; set; }
        public bool IsInstrumentFree { get; set; }
        public DateTime LastUsageTime { get; set; }
    }
}