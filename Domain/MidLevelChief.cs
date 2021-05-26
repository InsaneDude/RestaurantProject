namespace Domain
{
    public class MidLevelChief : Chief
    {
        private int chiefLevel = 2;
        public override int ChiefLevel
        {
            get
            {
                return this.chiefLevel;
            }
            set
            {
                this.chiefLevel = 2;
            }
        }
        public override string Name { get; set; }
        public override bool IsFree { get; set; }
        public override int Id { get; set; }
    }
}