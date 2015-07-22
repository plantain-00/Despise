namespace Despise
{
    public class ChineseCharGenerator : CharGenerator
    {
        public override char Generate()
        {
            return Generate((char) 0x4E00, (char) 0x9FA5);
        }

        public override char this[int index] => (char) (0x4E00 + index);
        public override int RangeCount => 0x9FA5 - 0x4E00;
    }
}