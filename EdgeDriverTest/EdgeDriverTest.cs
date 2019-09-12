using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace FireFoxDriverTest
{
    [TestClass]
    public class ChromeDriverTest
    {
        [TestMethod]
        public void TestWithChromeDriver()
        {
            using (var driver = new ChromeDriver(@"C:\SeleniumWebDrivers\ChromeDriver\"))
            {
                driver.Navigate().GoToUrl(@"https://www.bing.com");

                Assert.AreEqual("Bing", driver.Title);
            }
        }
    }
}
