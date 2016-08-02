
namespace Selenium
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.PhantomJS;
    using System;

    [TestClass]
    public class UnitTest1
    {
        private string baseURL = "http://google.it/";
        private RemoteWebDriver driver;
        private string browser;
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("IE")]

        public void TireSearch_Any()
        {
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

            driver = new InternetExplorerDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30)); 
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElementById("lst-ib").Clear();
            driver.FindElementById("lst-ib").SendKeys("tire");
            driver.FindElementByName("btnG").Click();
            //do other Selenium things here!
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }
    }
}

