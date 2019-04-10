using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectsTest.Pages;

namespace PageObjectsTest.Tests
{
    [TestFixture]
    public class MenuTests
    {
        private VirlekiPage page;
        IWebDriver driver;

        public static void Main(string[] args)
        {

        }


        [SetUp]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            page = new VirlekiPage(driver);
            page.Load();
            driver.Manage().Window.Maximize();
        }


        //[Test]
        //public void AllMenuTest()
        //{
        //    Assert.IsTrue(page.IsLoaded);

        //    // About
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='services']/div/div/div/h2")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='services']/div/div/div/h2")));

        //    // History
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='about']/div/div[1]/div/h2")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='about']/div/div[1]/div/h2")));

        //    // Background
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='background']/div/div[1]/div/h2")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='background']/div/div[1]/div/h2")));

        //    // Product
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='product']/div/div[1]/div/h2")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='product']/div/div[1]/div/h2")));

        //    // Team
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[5]/a")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[5]/a")));


        //    // Partners
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[6]/a")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[6]/a")));

        //    // Contacts
        //    Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
        //    Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
        //}

        [Test]
        public void AboutMenuTest()
        {
            Assert.True(page.IsLoaded);
            Assert.True(page.ClickElement(By.XPath("//*[@id='services']/div/div/div/h2")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='services']/div/div/div/h2")));
        }

        [Test]
        public void HistoryMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='about']/div/div[1]/div/h2")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='about']/div/div[1]/div/h2")));
        }

        [Test]
        public void BackgroundMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='background']/div/div[1]/div/h2")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='background']/div/div[1]/div/h2")));
        }

        [Test]
        public void ProductMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='product']/div/div[1]/div/h2")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='product']/div/div[1]/div/h2")));
        }

        [Test]
        public void TeamMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[5]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[5]/a")));
        }

        [Test]
        public void PartnersMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[6]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[6]/a")));
        }

        [Test]
        public void ContactsMenuTest()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
        }


        [TearDown]
        public void Cleanup()
        {
            driver.Dispose();
        }

    }
}
