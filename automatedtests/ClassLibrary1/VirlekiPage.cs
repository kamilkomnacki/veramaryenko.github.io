using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace PageObjectsTest

{
    public class VirlekiPage
    {
        static string url = "http://localhost/zmwpi/";
        private static string title = "VirLeki Innovative VR Gaming Platform for Patients Rehabilitation";
        private IWebDriver driver;

        public VirlekiPage()
        {
            driver = new ChromeDriver();
        }


        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void Load()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            driver.Close();
        }

        public void Quit()
        {
            driver.Quit();
        }


        public bool IsLoaded
        {
            get { return driver.Title.Equals(title); }
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
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
                Console.WriteLine("Elementu " + locator + "nie znaleziono na stronie " + driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił nieznany błąd " + e.Message + " na stronie " + driver.Title);
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
                Console.WriteLine("Elementu " + locator + "nie znaleziono na stronie " + driver.Title);
                returnValue = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił nieznany błąd " + e.Message + " na stronie " + driver.Title);
                returnValue = false;
            }
            return returnValue;
        }

    }
}
