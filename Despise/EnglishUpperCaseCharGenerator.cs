namespace Despise
{
    public class EnglishUpperCaseCharGenerator : GeneratorBase<char>
    {
        private const int START_CHAR_UPPER_CASE = 65;
        private const int END_CHAR_UPPER_CASE = 91;

        public override char Generate()
        {
            return (char) Random.Next(START_CHAR_UPPER_CASE, END_CHAR_UPPER_CASE);
        }
    }
}