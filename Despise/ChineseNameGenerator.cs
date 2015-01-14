namespace Despise
{
    public class ChineseNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var result = ChineseChar.GenerateMany(2, 4);
            return new string(result);
        }
    }
}