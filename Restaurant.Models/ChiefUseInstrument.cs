namespace Restaurant.Models
{
    public class ChiefUseInstrument
    {
        public int Id { get; set; }
        public Chief Chief { get; set; }
        public Instrument Instrument { get; set; }
    }
}