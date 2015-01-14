namespace Despise
{
    public class EnglishLowerCaseCharGenerator : GeneratorBase<char>
    {
        private const int START_CHAR_LOWER_CASE = 97;
        private const int END_CHAR_LOWER_CASE = 123;

        public override char Generate()
        {
            return (char) Random.Next(START_CHAR_LOWER_CASE, END_CHAR_LOWER_CASE);
        }
    }
}