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

        [TestMethod]
        public void CanGetManyMixChar()
        {
            var generator = new Generator();
            var mixCharGenerator = generator.Get<MixCharGenerator>();
            mixCharGenerator.Add<NumberCharGenerator>();
            mixCharGenerator.Add<EnglishLowerCaseCharGenerator>();
            mixCharGenerator.Add<EnglishUpperCaseCharGenerator>();
            mixCharGenerator.Add<ChineseCharGenerator>();
            var chars = mixCharGenerator.GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyEmails()
        {
            var generator = new Generator();
            var numbers = generator.Get<EmailGenerator>().GenerateMany(10, 20);
        }
    }
}