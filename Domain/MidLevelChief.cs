namespace Domain
{
    public class MidLevelChief : Chief
    {
        private int _level;

        public override int ChiefLevel
        {
            get { return 2; }
            set { _level = value; }
        }
    }
}