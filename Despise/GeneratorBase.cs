using System;

namespace Despise
{
    public abstract class GeneratorBase<T>
    {
        protected GeneratorBase()
        {
            Random = new Random();
        }

        public Random Random { get; private set; }

        public abstract T Generate();

        public T[] GenerateMany(int number)
        {
            var result = new T[number];
            for (var i = 0; i < number; i++)
            {
                result[i] = Generate();
            }
            return result;
        }

        public T[] GenerateMany(int from, int to)
        {
            var number = Random.Next(from, to);
            return GenerateMany(number);
        }
    }
}