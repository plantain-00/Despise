namespace Despise
{
    public abstract class StringGenerator<T> : GeneratorBase<string> where T : CharGenerator, new()
    {
        public override string Generate(string from, string to)
        {
            var result = Get<T>().GenerateMany(from.Length, to.Length);
            return new string(result);
        }
    }
}