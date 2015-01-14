namespace Despise
{
    public class NumberCharGenerator:CharGenerator
    {
        public override char Generate()
        {
            return Generate('0', ':');
        }
    }
}