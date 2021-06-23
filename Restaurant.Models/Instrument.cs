namespace Restaurant.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsReady { get; set; }
        public bool IsFree { get; set; }
        public int WarmingTime { get; set; }
        public int KeepWarm { get; set; }
    }
}