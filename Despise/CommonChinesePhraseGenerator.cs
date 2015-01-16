namespace Despise
{
    public class CommonChinesePhraseGenerator : StringGenerator<CommonChineseCharGenerator>
    {
        public override string Generate()
        {
            return Generate(2, 10);
        }
    }
}