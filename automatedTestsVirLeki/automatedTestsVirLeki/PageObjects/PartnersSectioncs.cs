using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatedTestsVirLeki.PageObjects
{
    class PartnersSectioncs
    {
        private readonly IWebDriver webDriver;


        public PartnersSectioncs(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        protected PartnersSectionMap Map
        {
            get
            {
                return new PartnersSectionMap(this.webDriver);
            }
        }

        public string GetHeaderOfSectionText()
        {
            string text = this.Map.HeaderPartnersSection.Text;
            return text;
        }
    }
}
