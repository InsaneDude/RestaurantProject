namespace Domain
{
    public abstract class Chief
    {
        public abstract int ChiefLevel { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        void Cook(Food food){}
        void GetOrder(){}
    }
}