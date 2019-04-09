using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Runtime;
using System.Threading;

namespace PageObjectsTest.menutests
{
    [TestFixture]
    public class MenuTests
    {
        private VirlekiPage page = new VirlekiPage();

        public static void Main(string[] args)
        {

        }


        [SetUp]
        public void TestSetup()
        {
            page.Load();
            //page.GetDriver().Manage().Window.FullScreen();


        }

        [TearDown]
        public void Cleanup()
        {
            //page.Quit();
        }


        [Test]
        public void AboutMenuTest()
        {
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
            page.Quit();
        }

    }
}
