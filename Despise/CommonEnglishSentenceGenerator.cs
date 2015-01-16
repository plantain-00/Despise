namespace Despise
{
    public class CommonEnglishSentenceGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var words = Get<CommonEnglishWordGenerator>().GenerateMany(4, 16);
            var name = "";
            foreach (var word in words)
            {
                name += word + " ";
            }
            name = char.ToUpper(name[0]) + name.Substring(1).Trim() + ". ";
            return name;
        }
    }
}