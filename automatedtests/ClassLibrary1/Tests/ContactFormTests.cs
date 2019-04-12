using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectsTest.Pages;
using System;

namespace PageObjectsTest.Tests
{
    [TestFixture]
    class ContactFormTests
    {
        private IWebDriver driver;
        VirlekiPage page;


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

        [TearDown]
        public void Cleanup()
        {
            driver.Dispose();
        }

        [Test]
        public void ScrollToContacts_SubmitCorrectData_CheckVAlidation()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            page.SubmitDataToContactForm("User Test", "tester@gmail.com", "689345092", "Test Message");
            Assert.IsTrue(page.IsElementVisible(By.XPath("//*[@id='success']/div/strong")));
            string username = driver.FindElement(By.XPath("//*[@id='success']/div/strong")).Text.Substring(0, driver.FindElement(By.XPath("//*[@id='success']/div/strong")).Text.IndexOf(" "));
            string errmsg = "Sorry " + username + ", it seems that my mail server is not responding. Please try again later!";
            Assert.AreEqual(driver.FindElement(By.XPath("//*[@id='success']/div/strong")).Text, @"Your message has been sent.");

        }

        [Test]
        public void ScrollToContacts_SubmitNoData_CheckVAlidation()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            page.SubmitNoDataToContactForm();
            IWebElement NameErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[1]/p/ul/li"));
            IWebElement EmailErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[2]/p/ul/li"));
            IWebElement PhoneErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[3]/p/ul/li"));
            IWebElement MessageErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[2]/div/p/ul/li"));
            Assert.AreEqual(NameErrMsg.Text, "Please enter your name.");
            Assert.AreEqual(EmailErrMsg.Text, "Please enter your email address.");
            Assert.AreEqual(PhoneErrMsg.Text, "Please enter your phone number.");
            Assert.AreEqual(MessageErrMsg.Text, "Please enter a message.");
            Assert.IsFalse(page.IsElementVisible(By.XPath("//*[@id='success']/div/strong")));
        }

        [Test]
        public void ScrollToContacts_SubmitIncorrectEmailNoOtherData_CheckVAlidation()
        {
            Assert.True(page.ClickElement(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            Assert.True(page.IsElementVisible(By.XPath("//*[@id='navbarResponsive']/ul/li[7]/a")));
            page.SubmitDataToContactForm("", "tester@com", "", "");
            IWebElement NameErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[1]/p/ul/li"));
            IWebElement EmailErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[2]/p/ul/li"));
            IWebElement PhoneErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[1]/div[3]/p/ul/li"));
            IWebElement MessageErrMsg = driver.FindElement(By.XPath("//*[@id='contactForm']/div/div[2]/div/p/ul/li"));
            Assert.AreEqual(NameErrMsg.Text, "Please enter your name.");
            Assert.AreEqual(EmailErrMsg.Text, "Not a valid email address");
            Assert.AreEqual(PhoneErrMsg.Text, "Please enter your phone number.");
            Assert.AreEqual(MessageErrMsg.Text, "Please enter a message.");
            Assert.IsFalse(page.IsElementVisible(By.XPath("//*[@id='success']/div/strong")));
            //Assert.AreEqual(page.SuccessMsg.Text, "Your message has been sent.");
            
        }
    }
}
