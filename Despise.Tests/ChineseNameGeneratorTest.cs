using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Despise.Tests
{
    [TestClass]
    public class ChineseNameGeneratorTest
    {
        [TestMethod]
        public void CanGetManyChineseName()
        {
            var generator = new Generator();
            var names = generator.Get<ChineseNameGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyEnglishName()
        {
            var generator = new Generator();
            var names = generator.Get<EnglishNameGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyPhoneNumber()
        {
            var generator = new Generator();
            var numbers = generator.Get<PhoneNumberGenerator>().GenerateMany(10, 20);
        }
    }
}