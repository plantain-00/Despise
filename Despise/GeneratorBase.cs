using System;

namespace Despise
{
    public abstract class GeneratorBase<T>
    {
        private BoolGenerator _bool;
        private ChineseCharGenerator _chineseChar;
        private EnglishLowerCaseCharGenerator _englishLowerCaseChar;
        private EnglishUpperCaseCharGenerator _englishUpperCaseChar;

        protected GeneratorBase()
        {
            Random = new Random();
        }

        public Random Random { get; private set; }

        public ChineseCharGenerator ChineseChar
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
        public EnglishUpperCaseCharGenerator EnglishUpperCaseChar
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
        public EnglishLowerCaseCharGenerator EnglishLowerCaseChar
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
        public BoolGenerator Bool
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