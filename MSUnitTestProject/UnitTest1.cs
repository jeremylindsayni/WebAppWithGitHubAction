using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassingTest()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
