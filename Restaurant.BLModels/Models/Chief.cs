namespace Restaurant.BLModels.Models
{
    public class Chief
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsFree { get; set; }
        public Instrument Instrument { get; set; } 
    }
}