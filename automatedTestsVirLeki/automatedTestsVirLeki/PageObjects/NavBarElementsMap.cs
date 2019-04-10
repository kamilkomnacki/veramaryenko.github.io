using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace autoTestsVirleki.PageObjects
{
    class NavBarElementsMap
    {
        private readonly IWebDriver webDriver;

        public NavBarElementsMap(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement LogoButton
        {
            get
            {
                return this.webDriver.FindElement(By.XPath("//a[@class='navbar-brand js-scroll-trigger text-uppercase']"));
            }
        }
    }
}
