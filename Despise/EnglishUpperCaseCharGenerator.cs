namespace Despise
{
    public class EnglishUpperCaseCharGenerator : CharGenerator
    {
        public override char this[int index]
        {
            get
            {
                return (char) ('A' + index);
            }
        }
        public override int RangeCount
        {
            get
            {
                return 26;
            }
        }

        public override char Generate()
        {
            return Generate('A', '[');
        }
    }
}