namespace Despise
{
    public class EnglishUpperCaseCharGenerator : CharGenerator
    {
        public override char this[int index] => (char) ('A' + index);
        public override int RangeCount => 26;

        public override char Generate()
        {
            return Generate('A', '[');
        }
    }
}