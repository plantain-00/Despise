namespace Despise
{
    public abstract class StringGenerator<T> : GeneratorBase<string> where T : CharGenerator, new()
    {
        public string Generate(int count)
        {
            var result = Get<T>().GenerateMany(count);
            return new string(result);
        }

        public string Generate(int from, int to)
        {
            var result = Get<T>().GenerateMany(from, to);
            return new string(result);
        }
    }
}