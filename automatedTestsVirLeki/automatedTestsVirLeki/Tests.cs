using System;
using automatedTestsVirLeki.PageObjects;
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
        static Helper helper;
        static PartnersSectioncs partnersSectioncs;
        static Head head;
             

        [TestInitialize]
        public void SetupTests()
        {
            this.Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            navBar = new NavBar(this.Driver);
            helper = new Helper(this.Driver);
            partnersSectioncs = new PartnersSectioncs(this.Driver);
            head = new Head(this.Driver);


        }

        [TestCleanup]
        public void TearDownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void LogoButtonUpFunnction()
        {
            helper.Navigate();
            string headTitleBeforeTest = head.GetHeaderOfSectionText();
            navBar.PartnersButtonClick();
            string sectionHeader = partnersSectioncs.GetHeaderOfSectionText();
            Assert.AreEqual("Partners", sectionHeader);
            navBar.LogoButtonClick();
            string headTitleAfterTest = head.GetHeaderOfSectionText();
            Assert.AreEqual(headTitleBeforeTest, headTitleAfterTest);
        }
    }
}
