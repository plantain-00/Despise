namespace Despise
{
    public class ChineseSentenseGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Get<ChinesePhraseGenerator>().Generate(3, 15) + "。";
        }
    }
}