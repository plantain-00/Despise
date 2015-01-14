namespace Despise
{
    public class EnglishNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var result = EnglishLowerCaseChar.GenerateMany(2, 7);
            return EnglishUpperCaseChar.Generate() + new string(result);
        }
    }
}