namespace Despise
{
    public class EnglishLowerCaseCharGenerator : GeneratorBase<char>
    {
        public override char Generate()
        {
            return Generate('a', '{');
        }

        public override char Generate(char from, char to)
        {
            return (char) Random.Next(from, to);
        }
    }
}