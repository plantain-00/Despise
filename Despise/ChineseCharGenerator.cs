namespace Despise
{
    public class ChineseCharGenerator : CharGenerator
    {
        public override char Generate()
        {
            return Generate((char) 0x4E00, (char) 0x9FA5);
        }
    }
}