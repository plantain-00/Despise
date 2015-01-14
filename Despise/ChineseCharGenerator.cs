using System;

namespace Despise
{
    public class ChineseCharGenerator : IGenerator<char>
    {
        private const int START_CHAR = 0x4E00;
        private const int END_CHAR = 0x9FA5;
        private readonly Random _random;

        public ChineseCharGenerator()
        {
            _random = new Random();
        }

        public Random Random
        {
            get
            {
                return _random;
            }
        }

        public char Generate()
        {
            return (char) _random.Next(START_CHAR, END_CHAR);
        }

        public char[] GenerateMany(int number)
        {
            var result = new char[number];
            for (var i = 0; i < number; i++)
            {
                result[i] = Generate();
            }
            return result;
        }

        public char[] GenerateMany(int from, int to)
        {
            var number = _random.Next(from, to);
            return GenerateMany(number);
        }
    }
}