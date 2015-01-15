namespace Despise
{
    public class EnglishSentenceGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var words = Get<EnglishWordGenerator>().GenerateMany(3, 15);
            var name = Get<EnglishNameGenerator>().Generate();
            foreach (var word in words)
            {
                name += " " + word;
            }
            name = name.Trim() + ". ";
            return name;
        }
    }
}