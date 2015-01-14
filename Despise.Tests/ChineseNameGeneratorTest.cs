using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Despise.Tests
{
    [TestClass]
    public class ChineseNameGeneratorTest
    {
        [TestMethod]
        public void CanGetManyChineseName()
        {
            var generator = new ChineseNameGenerator();
            var names = generator.GenerateMany(10, 20);
        }

        [TestMethod]
        public void CanGetManyEnglishName()
        {
            var generator = new EnglishNameGenerator();
            var names = generator.GenerateMany(10, 20);
        }
    }
}