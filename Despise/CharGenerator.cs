namespace Despise
{
    public abstract class CharGenerator : GeneratorBase<char>
    {
        public abstract char this[int index] { get; }

        public abstract int RangeCount { get; }

        public char Generate(char from, char to)
        {
            return (char) Random.Next(from, to);
        }
    }
}