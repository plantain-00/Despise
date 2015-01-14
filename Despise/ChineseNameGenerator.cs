using System;

namespace Despise
{
    public class ChineseNameGenerator : IGenerator<string>
    {
        private readonly ChineseCharGenerator _chineseCharGenerator;

        public ChineseNameGenerator()
        {
            _chineseCharGenerator = new ChineseCharGenerator();
        }

        public Random Random
        {
            get
            {
                return _chineseCharGenerator.Random;
            }
        }

        public string Generate()
        {
            var number = _chineseCharGenerator.Random.Next(2, 4);
            var result = _chineseCharGenerator.GenerateMany(number);
            return new string(result);
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