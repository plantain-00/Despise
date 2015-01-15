namespace Despise
{
    public class PhoneNumberGenerator : StringGenerator<NumberCharGenerator>
    {
        public override string Generate()
        {
            return Generate("00000000", "00000000000");
        }
    }
}