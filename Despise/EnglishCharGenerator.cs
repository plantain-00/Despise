namespace Despise
{
    public class EnglishCharGenerator : GeneratorBase<char>
    {
        private const int START_CHAR_UPPER_CASE = 65;
        private const int END_CHAR_UPPER_CASE = 91;
        private const int START_CHAR_LOWER_CASE = 97;
        private const int END_CHAR_LOWER_CASE = 123;

        public override char Generate()
        {
            return Random.Next(0, 2) == 0 ? (char) Random.Next(START_CHAR_UPPER_CASE, END_CHAR_UPPER_CASE) : (char) Random.Next(START_CHAR_LOWER_CASE, END_CHAR_LOWER_CASE);
        }
    }
}