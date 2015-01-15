namespace Despise
{
    public class ChineseSentenseGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Generate("000", "000000000000000");
        }

        public override string Generate(string from, string to)
        {
            return Get<ChinesePhraseGenerator>().Generate(from, to) + "。";
        }
    }
}