using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.False(1 == 0);
        }
    }
}
