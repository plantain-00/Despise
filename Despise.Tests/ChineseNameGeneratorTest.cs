using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Despise.Tests
{
    [TestClass]
    public class ChineseNameGeneratorTest
    {
        [TestMethod]
        public void CanGetAChineseName()
        {
            var generator = new ChineseNameGenerator();
            var name = generator.Generate();
        }

        [TestMethod]
        public void CanGetManyChineseName()
        {
            var generator = new ChineseNameGenerator();
            var names = generator.GenerateMany(10, 20);
        }
    }
}