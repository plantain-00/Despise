namespace Despise
{
    public class EnglishLowerCaseCharGenerator : CharGenerator
    {
        public override char Generate()
        {
            return Generate('a', '{');
        }
    }
}