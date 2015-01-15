namespace Despise
{
    public class Generator : GeneratorBase<int>
    {
        public override int Generate()
        {
            return Random.Next(int.MinValue, int.MaxValue);
        }
    }
}