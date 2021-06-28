namespace Restaurant.DAL.Entities
{
    public class ChiefEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsFree { get; set; }
    }
}