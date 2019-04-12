using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageObjectsTest.Utils;

namespace PageObjectsTest.Pages
{
    public class VirlekiPage
    {
        static string url = "http://localhost/zmwpi/";
        private static string title = "VirLeki Innovative VR Gaming Platform for Patients Rehabilitation";
        private IWebDriver Driver { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "phone")]
        public IWebElement PhoneField { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement MessageField { get; set; }

        [FindsBy(How = How.Id, Using = "sendMessageButton")]
        public IWebElement SendMsgBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactForm']/div/div[1]/div[1]/p/ul/li")]
        public IWebElement NameErrMsg { get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='success']/div/strong")]
        public IWebElement SuccessMsg { get; }

        public VirlekiPage(IWebDriver dr)
        {
            this.Driver = dr;
            PageFactory.InitElements(dr, this);
        }


        public IWebDriver GetDriver()
        {
            return Driver;
        }

        public void Load()
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            Driver.Close();
        }

        public void Quit()
        {
            Driver.Quit();
        }

        public void Dispose()
        {
            Driver.Dispose();
        }


        public bool IsLoaded
        {
            get { return Driver.Title.Equals(title); }
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element;
        }

        public bool ClickElement(By locator)
        {
            bool returnValue = false;
            try
            {
                WaitForElementVisible(locator).Click();
                returnValue = true;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Elementu " + locator + "nie znaleziono na stronie " + Driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił nieznany błąd " + e.Message + " na stronie " + Driver.Title);
                returnValue = false;
            }
            return returnValue;
        }

        public bool IsElementVisible(By locator)
        {
            bool returnValue = false;
            try
            {
                returnValue = WaitForElementVisible(locator).Displayed;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Elementu " + locator + "nie znaleziono na stronie " + Driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił nieznany błąd " + e.Message + " na stronie " + Driver.Title);
                returnValue = false;
            }
            return returnValue;
        }

        public VirlekiPage SubmitDataToContactForm(string name, string email, string phone, string message)
        {
            NameField.SendKeys(name);
            EmailField.SendKeys(email);
            PhoneField.SendKeys(phone);
            MessageField.SendKeys(message);
            Driver.WaitUntilElementValueEquals(NameField, name);
            Driver.WaitUntilElementValueEquals(EmailField, email);
            Driver.WaitUntilElementValueEquals(PhoneField, phone);
            Driver.WaitUntilElementValueEquals(MessageField, message);
            SendMsgBtn.Submit();
            return new VirlekiPage(Driver);
        }

        public VirlekiPage SubmitNoDataToContactForm()
        {
            NameField.Clear();
            EmailField.Clear();
            PhoneField.Clear();
            MessageField.Clear();
            SendMsgBtn.Submit();
            return new VirlekiPage(Driver);
        }

        public bool IsValidName(string s)
        {
            bool isValid = Regex.IsMatch(s, @"^[a-zA-Z0-9\_]{2,40}$", RegexOptions.IgnoreCase);
            return isValid;
        }


        public bool IsValidPhoneNumber(string s) {

            bool isValid = Regex.IsMatch(s, @"^[0-9\-\+\_]{7,20}$", RegexOptions.IgnoreCase);
            return isValid;
        }

        public bool IsValidEmail(string s)
        {
            bool isValid = Regex.IsMatch(s, @"^[a-z][a-z0-9_]*@[a-z0-9]*\.[a-z]{2,3}$", RegexOptions.IgnoreCase);
            return isValid;
        }


    }
}
