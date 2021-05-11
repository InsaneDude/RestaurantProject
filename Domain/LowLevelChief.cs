namespace Domain
{
    public class LowLevelChief : Chief
    {
        private int _level;

        public override int ChiefLevel
        {
            get { return 1; }
            set { _level = value; }
        }
    }
}