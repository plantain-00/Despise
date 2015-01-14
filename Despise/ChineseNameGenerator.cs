namespace Despise
{
    public class ChineseNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Generate("00", "0000");
        }

        public override string Generate(string from, string to)
        {
            var result = Get<ChineseCharGenerator>().GenerateMany(from.Length, to.Length);
            return new string(result);
        }
    }
}