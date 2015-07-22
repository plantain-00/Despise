namespace Despise
{
    public class NumberCharGenerator : CharGenerator
    {
        public override char this[int index] => (char) ('0' + index);
        public override int RangeCount => 10;

        public override char Generate()
        {
            return Generate('0', ':');
        }
    }
}