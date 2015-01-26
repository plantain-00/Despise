namespace Despise
{
    public class EnglishLowerCaseCharGenerator : CharGenerator
    {
        public override char Generate()
        {
            return Generate('a', '{');
        }

        public override char this[int index]
        {
            get
            {
                return (char) ('a' + index);
            }
        }
        public override int RangeCount
        {
            get
            {
                return 26;
            }
        }
    }
}