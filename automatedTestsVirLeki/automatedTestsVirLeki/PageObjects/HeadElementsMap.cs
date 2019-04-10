using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatedTestsVirLeki.PageObjects
{
    class HeadElementsMap
    {
        private readonly IWebDriver webDriver;

        public HeadElementsMap(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement HeaderOfHeadSection
        {
            get
            {
                return this.webDriver.FindElement(By.XPath("//div[@class='intro-lead-in']"));
            }
        }
    }
}
