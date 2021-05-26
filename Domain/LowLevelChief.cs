namespace Domain
{
    public class LowLevelChief : Chief
    {
        private int chiefLevel = 1;
        public override int ChiefLevel
        {
            get
            {
                return this.chiefLevel;
            }
            set
            {
                this.chiefLevel = 1;
            }
        }
        public override string Name { get; set; }
        public override bool IsFree { get; set; }
        public override int Id { get; set; }
    }
}