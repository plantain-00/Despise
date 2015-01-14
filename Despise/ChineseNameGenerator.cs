namespace Despise
{
    public class ChineseNameGenerator : GeneratorBase<string>
    {
        private readonly ChineseCharGenerator _chineseCharGenerator;

        public ChineseNameGenerator()
        {
            _chineseCharGenerator = new ChineseCharGenerator();
        }

        public override string Generate()
        {
            var result = _chineseCharGenerator.GenerateMany(2, 4);
            return new string(result);
        }
    }
}