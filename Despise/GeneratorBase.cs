using System;

namespace Despise
{
    public abstract class GeneratorBase<T>
    {
        private GeneratorBase<bool> _bool;
        private GeneratorBase<char> _chineseChar;
        private GeneratorBase<char> _englishLowerCaseChar;
        private GeneratorBase<char> _englishUpperCaseChar;

        protected GeneratorBase()
        {
            Random = new Random();
        }

        public Random Random { get; private set; }

        public GeneratorBase<char> ChineseChar
        {
            get
            {
                if (_chineseChar == null)
                {
                    _chineseChar = new ChineseCharGenerator();
                }
                return _chineseChar;
            }
        }
        public GeneratorBase<char> EnglishUpperCaseChar
        {
            get
            {
                if (_englishUpperCaseChar == null)
                {
                    _englishUpperCaseChar = new EnglishUpperCaseCharGenerator();
                }
                return _englishUpperCaseChar;
            }
        }
        public GeneratorBase<char> EnglishLowerCaseChar
        {
            get
            {
                if (_englishLowerCaseChar == null)
                {
                    _englishLowerCaseChar = new EnglishLowerCaseCharGenerator();
                }
                return _englishLowerCaseChar;
            }
        }
        public GeneratorBase<bool> Bool
        {
            get
            {
                if (_bool == null)
                {
                    _bool = new BoolGenerator();
                }
                return _bool;
            }
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