namespace Despise
{
    public class BoolGenerator : GeneratorBase<bool>
    {
        public override bool Generate()
        {
            return Random.NextDouble() > 0.5;
        }
    }
}