using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatedTestsVirLeki.PageObjects
{
    class Helper
    {
        public IWebDriver browser;
        public string url = @"https://veramaryenko.github.io/bootstrap/";

        public Helper(IWebDriver browser)
        {
            this.browser = browser;
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
            this.browser.Manage().Window.Maximize();
        }
    }
}
