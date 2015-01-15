namespace Despise
{
    public abstract class CharGenerator : GeneratorBase<char>
    {
        public char Generate(char from, char to)
        {
            return (char)Random.Next(from, to);
        }
    }
}