namespace Despise
{
    public class EmailGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var head = new string(Get<EnglishLowerCaseCharGenerator>().GenerateMany(4, 10));
            var middle = new string(Get<EnglishLowerCaseCharGenerator>().GenerateMany(3, 7));
            var tail = new string(Get<EnglishLowerCaseCharGenerator>().GenerateMany(2, 4));

            var result = string.Format("{0}@{1}.{2}", head, middle, tail);
            return result;
        }
    }
}