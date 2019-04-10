using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsTest.Utils
{
    public static class WaitHelper
    {
        private static TimeSpan AmountOfTime { get; } = TimeSpan.FromSeconds(5);

        public static void WaitUntilElementValueEquals(this IWebDriver driver, IWebElement element, string valueToCheck )
        {
            var wait = new WebDriverWait(driver, AmountOfTime);
            wait.Until(x => element.GetAttribute("value")==valueToCheck);
        }

    }
}
