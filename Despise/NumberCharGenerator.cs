namespace Despise
{
    public class NumberCharGenerator : CharGenerator
    {
        public override char this[int index]
        {
            get
            {
                return (char) ('0' + index);
            }
        }
        public override int RangeCount
        {
            get
            {
                return 10;
            }
        }

        public override char Generate()
        {
            return Generate('0', ':');
        }
    }
}