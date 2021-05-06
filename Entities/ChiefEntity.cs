using Entities.Abstract;

namespace Entities
{
    public class ChiefEntity : BaseEntity
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
    }
}