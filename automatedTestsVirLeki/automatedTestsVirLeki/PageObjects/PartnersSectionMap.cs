using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatedTestsVirLeki.PageObjects
{
    class PartnersSectionMap
    {
        private readonly IWebDriver webDriver;

        public PartnersSectionMap(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement HeaderPartnersSection
        {
            get
            {
                return this.webDriver.FindElement(By.XPath("//h2[contains(text(),'Partners')]"));
            }
        }


    }
}
