namespace Despise
{
    public class CommonEnglishNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Get<CommonEnglishFirstNameGenerator>().Generate() + " " + Get<CommonEnglishSurnameGenerator>().Generate();
        }
    }
}