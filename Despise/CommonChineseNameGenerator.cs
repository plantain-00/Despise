namespace Despise
{
    public class CommonChineseNameGenerator : GeneratorBase<string>
    {
        public override string Generate()
        {
            var surname = Get<CommonChineseSurnameGenerator>().Generate();
            var name = Get<CommonChineseCharGenerator>().GenerateMany(1, 3);
            return surname + new string(name);
        }
    }
}