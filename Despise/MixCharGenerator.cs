using System;
using System.Collections.Generic;
using System.Linq;

namespace Despise
{
    public class MixCharGenerator : GeneratorBase<char>
    {
        private List<CharGenerator> _charGenerators;

        public MixCharGenerator Add<T>() where T : CharGenerator, new()
        {
            if (_charGenerators == null)
            {
                _charGenerators = new List<CharGenerator>();
            }
            if (_charGenerators.All(c => typeof (T) != c.GetType()))
            {
                _charGenerators.Add(Get<T>());
            }
            return this;
        }

        public override char Generate()
        {
            if (_charGenerators == null
                || _charGenerators.Count == 0)
            {
                throw new Exception("empty");
            }
            var index = Random.Next(0, _charGenerators.Count);
            return _charGenerators[index].Generate();
        }
    }
}