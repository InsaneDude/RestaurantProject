namespace Domain
{
    public class HighLevelChief : Chief
    {
        private int chiefLevel = 3;
        public override int ChiefLevel
        {
            get
            {
                return this.chiefLevel;
            }
            set
            {
                this.chiefLevel = 3;
            }
        }
        public override string Name { get; set; }
        public override bool IsFree { get; set; }
        public override int Id { get; set; }
    }
}