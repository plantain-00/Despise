namespace Despise
{
    public class ChineseNameGenerator : StringGenerator<ChineseCharGenerator>
    {
        public override string Generate()
        {
            return Generate(2, 4);
        }
    }
}