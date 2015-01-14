namespace Despise
{
    public class EnglishUpperCaseCharGenerator : GeneratorBase<char>
    {
        public override char Generate()
        {
            return Generate('A', '[');
        }

        public override char Generate(char from, char to)
        {
            return (char) Random.Next(from, to);
        }
    }
}