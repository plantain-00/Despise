using System;
using System.Collections.Generic;

namespace Despise
{
    public abstract class GeneratorBase<T>
    {
        private Dictionary<Type, object> _factory;

        protected GeneratorBase()
        {
            Random = new Random();
        }

        public Random Random { get; private set; }

        public TGenerator Get<TGenerator>() where TGenerator : class, new()
        {
            if (_factory == null)
            {
                _factory = new Dictionary<Type, object>();
            }
            var type = typeof (TGenerator);
            if (!_factory.ContainsKey(type))
            {
                _factory.Add(type, new TGenerator());
            }
            return _factory[type] as TGenerator;
        }

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