namespace Despise
{
    public class PhoneNumberGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            return Generate("00000000", "00000000000");
        }

        public override string Generate(string from, string to)
        {
            var result = Get<NumberCharGenerator>().GenerateMany(from.Length, to.Length);
            return new string(result);
        }
    }
}