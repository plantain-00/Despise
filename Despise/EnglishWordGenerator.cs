namespace Despise
{
    public class EnglishWordGenerator : StringGenerator<EnglishLowerCaseCharGenerator>
    {
        public override string Generate()
        {
            return Generate(3, 7);
        }
    }
}