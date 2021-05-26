namespace Domain
{
    public class Instrument
    {
        public bool IsFree { get; set; }
        public bool IsReady { get; set; }
        public float WarmingTime { get; set; }
        public float KeepWarm { get; set; } 
        public string Name { get; set; }
        public int Id { get; set; }
    }
}