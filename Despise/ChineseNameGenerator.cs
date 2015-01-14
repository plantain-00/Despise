using System;

namespace Despise
{
    public class ChineseNameGenerator : IGenerator<string>
    {
        private const int START_CHAR = 0x4E00;
        private const int END_CHAR = 0x9FA5;
        private readonly Random _random;

        public ChineseNameGenerator()
        {
            _random = new Random();
        }

        public string Generate()
        {
            var number = _random.Next(2, 4);
            var result = "";
            for (var i = 0; i < number; i++)
            {
                result += (char) _random.Next(START_CHAR, END_CHAR);
            }
            return result;
        }

        public string[] GenerateMany(int number)
        {
            var result = new string[number];
            for (var i = 0; i < number; i++)
            {
                result[i] = Generate();
            }
            return result;
        }
    }
}