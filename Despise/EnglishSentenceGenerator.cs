namespace Despise
{
    public class EnglishSentenceGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Generate("000", "000000000000000");
        }

        public override string Generate(string from, string to)
        {
            var words = Get<EnglishWordGenerator>().GenerateMany(from.Length, to.Length);
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