using System;

namespace Restaurant.WPF.Models
{
    public class InstrumentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WarmingTime { get; set; }
        public bool IsInstrumentFree { get; set; }
        public DateTime LastUsageTime { get; set; }
    }
}