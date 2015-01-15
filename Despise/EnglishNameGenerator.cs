namespace Despise
{
    public class EnglishNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var result = Get<EnglishLowerCaseCharGenerator>().GenerateMany(2, 7);
            return Get<EnglishUpperCaseCharGenerator>().Generate() + new string(result);
        }
    }
}