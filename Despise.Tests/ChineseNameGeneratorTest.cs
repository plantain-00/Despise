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

        [TestMethod]
        public void CanGetManyDateTimes()
        {
            var generator = new Generator();
            var numbers = generator.Get<DateTimeGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyEnglishSentences()
        {
            var generator = new Generator();
            var numbers = generator.Get<EnglishSentenceGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyChineseSentences()
        {
            var generator = new Generator();
            var numbers = generator.Get<ChineseSentenseGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyCommonChineseChars()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonChineseCharGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyCommonChineseNames()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonChineseNameGenerator>().GenerateMany(20, 40);
        }

        [TestMethod]
        public void CanGetManyCommonChineseSentences()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonChineseSentenseGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyCommonEnglishWords()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonEnglishWordGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyCommonEnglishSentences()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonEnglishSentenceGenerator>().GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyCommonEnglishNames()
        {
            var generator = new Generator();
            var numbers = generator.Get<CommonEnglishNameGenerator>().GenerateMany(10, 20);
        }
    }
}