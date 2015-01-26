using System;
using System.Collections.Generic;
using System.Linq;

namespace Despise
{
    public class MixCharGenerator : GeneratorBase<char>
    {
        private List<CharGenerator> _charGenerators;
        public MixStrategy Strategy { get; set; }

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

        public MixCharGenerator Add<T>(T charGenerator) where T : CharGenerator, new()
        {
            if (_charGenerators == null)
            {
                _charGenerators = new List<CharGenerator>();
            }
            if (_charGenerators.All(c => typeof (T) != c.GetType()))
            {
                _charGenerators.Add(charGenerator);
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

            if (Strategy == MixStrategy.Char)
            {
                var index = Random.Next(0, _charGenerators.Sum(c => c.RangeCount));
                foreach (var charGenerator in _charGenerators)
                {
                    if (index < charGenerator.RangeCount)
                    {
                        return charGenerator[index];
                    }
                    index -= charGenerator.RangeCount;
                }
                throw new Exception("index overflow");
            }
            else
            {
                var index = Random.Next(0, _charGenerators.Count);
                return _charGenerators[index].Generate();
            }
        }
    }

    public enum MixStrategy
    {
        Char,
        Element
    }
}