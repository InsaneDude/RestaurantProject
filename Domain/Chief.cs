namespace Domain
{
    public abstract class Chief
    {
        // chief level must be abstract
        public abstract int ChiefLevel { get; set; }
        public abstract string Name { get; set; }
        public abstract bool IsFree { get; set; }
        public abstract int Id { get; set; }
    }
}