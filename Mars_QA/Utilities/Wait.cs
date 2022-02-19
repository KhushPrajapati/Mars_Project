using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_QA.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, String locatorValue, int Seconds)
        {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
        }
    }
}
