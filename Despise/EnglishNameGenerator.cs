namespace Despise
{
    public class EnglishNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Generate("00", "0000000");
        }

        public override string Generate(string from, string to)
        {
            var result = Get<EnglishLowerCaseCharGenerator>().GenerateMany(from.Length, to.Length);
            return Get<EnglishUpperCaseCharGenerator>().Generate() + new string(result);
        }
    }
}