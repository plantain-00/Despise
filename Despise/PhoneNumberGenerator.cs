namespace Despise
{
    public class PhoneNumberGenerator : StringGenerator<NumberCharGenerator>
    {
        public override string Generate()
        {
            return Generate(8, 12);
        }
    }
}