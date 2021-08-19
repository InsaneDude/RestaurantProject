namespace VModels.Models
{
    public class ChiefModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsFree { get; set; }
        public InstrumentModel Instrument { get; set; } 
    }
}