namespace Domain
{
    public class Instrument
    {
        public bool IsReady { get; set; }
        public float WarmingTime { get; set; }
        public float KeepWarm { get; set; } 
        public int Id { get; set; }
    }
}