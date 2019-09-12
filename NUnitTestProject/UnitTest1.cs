using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void FailingTest()
        {
            Assert.AreEqual(1, 1);
        }
    }
}