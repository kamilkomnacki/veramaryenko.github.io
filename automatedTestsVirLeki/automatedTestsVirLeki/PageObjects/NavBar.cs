using OpenQA.Selenium;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace autoTestsVirleki.PageObjects
{
    class NavBar
    {
        private readonly IWebDriver webDriver;
        

        public NavBar(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        protected NavBarElementsMap Map
        {
            get
            {
                return new NavBarElementsMap(this.webDriver);
            }
        }

        public void LogoButtonClick()
        {
            this.Map.LogoButton.Click();
        }

        public void PartnersButtonClick()
        {
            this.Map.PartnersButton.Click();
        }
    }
}
