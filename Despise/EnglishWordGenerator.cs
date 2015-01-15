namespace Despise
{
    public class EnglishWordGenerator : StringGenerator<EnglishLowerCaseCharGenerator>
    {
        public override string Generate()
        {
            return Generate("000", "0000000");
        }
    }
}