namespace Despise
{
    public class CommonChineseSentenseGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Get<CommonChinesePhraseGenerator>().Generate(3, 15) + "。";
        }
    }
}