namespace Despise
{
    public class Generator : GeneratorBase<int>
    {
        public override int Generate()
        {
            return Generate(int.MinValue, int.MaxValue);
        }

        public override int Generate(int from, int to)
        {
            return Random.Next(from, to);
        }
    }
}