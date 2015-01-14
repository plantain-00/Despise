namespace Despise
{
    public class ChineseCharGenerator : GeneratorBase<char>
    {
        private const int START_CHAR = 0x4E00;
        private const int END_CHAR = 0x9FA5;

        public override char Generate()
        {
            return (char) Random.Next(START_CHAR, END_CHAR);
        }
    }
}