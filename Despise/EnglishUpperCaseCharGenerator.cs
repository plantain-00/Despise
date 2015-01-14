namespace Despise
{
    public class EnglishUpperCaseCharGenerator : CharGenerator
    {
        public override char Generate()
        {
            return Generate('A', '[');
        }
    }
}