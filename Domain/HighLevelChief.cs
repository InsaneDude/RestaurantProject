namespace Domain
{
    public class HighLevelChief : Chief
    {
        private int _level;

        public override int ChiefLevel
        {
            get { return 3; }
            set { _level = value; }
        }
    }
}