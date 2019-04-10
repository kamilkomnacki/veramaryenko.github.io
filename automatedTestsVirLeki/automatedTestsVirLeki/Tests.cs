using System;
using autoTestsVirleki.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace automatedTestsVirLeki
{
    [TestClass]
    public class Tests
    {
        public RemoteWebDriver Driver { get; set; }
        static NavBar navBar;

        [TestInitialize]
        public void SetupTests()
        {
            this.Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navBar = new NavBar(this.Driver);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void LogoButtonClick()
        {
            navBar.LogoButtonClick();

        }
    }
}
