using System.Collections.Generic;

namespace Despise
{
    public class PasswordGenerator : GeneratorBase<string>
    {
        public int Number { get; set; }

        public override string Generate()
        {
            if (Number < 4)
            {
                Number = 16;
            }

            var list = new List<char>(Number);
            var specialCharGenerator = Get<SpecialCharGenerator>();
            var numberCharGenerator = Get<NumberCharGenerator>();
            var upperCaseCharGenerator = Get<EnglishUpperCaseCharGenerator>();
            var lowerCaseCharGenerator = Get<EnglishLowerCaseCharGenerator>();
            var mixCharGenerator = Get<MixCharGenerator>();
            mixCharGenerator.Add(specialCharGenerator);
            mixCharGenerator.Add(numberCharGenerator);
            mixCharGenerator.Add(upperCaseCharGenerator);
            mixCharGenerator.Add(lowerCaseCharGenerator);

            list.Add(specialCharGenerator.Generate());
            list.Add(numberCharGenerator.Generate());
            list.Add(lowerCaseCharGenerator.Generate());
            list.Add(upperCaseCharGenerator.Generate());
            list.AddRange(mixCharGenerator.GenerateMany(Number - 4));

            var result = new List<char>(Number);
            while (list.Count > 0)
            {
                var index = Random.Next(0, list.Count);
                result.Add(list[index]);
                list.RemoveAt(index);
            }
            return new string(result.ToArray());
        }

        public class SpecialCharGenerator : CharGenerator
        {
            private const string SPECIAL_CHARS = "!#$%@";

            public override char this[int index]
            {
                get
                {
                    return SPECIAL_CHARS[index];
                }
            }
            public override int RangeCount
            {
                get
                {
                    return SPECIAL_CHARS.Length;
                }
            }

            public override char Generate()
            {
                return SPECIAL_CHARS[Random.Next(0, SPECIAL_CHARS.Length)];
            }
        }
    }
}