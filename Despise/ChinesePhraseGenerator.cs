namespace Despise
{
    public class ChinesePhraseGenerator : StringGenerator<ChineseCharGenerator>
    {
        public override string Generate()
        {
            return Generate("00", "0000000000");
        }
    }
}