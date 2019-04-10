using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatedTestsVirLeki.PageObjects
{
    class Head
    {
        private readonly IWebDriver webDriver;


        public Head(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        protected HeadElementsMap Map
        {
            get
            {
                return new HeadElementsMap(this.webDriver);
            }
        }

        public string GetHeaderOfSectionText()
        {
            string text = this.Map.HeaderOfHeadSection.Text;
            return text;
        }
    }
}

