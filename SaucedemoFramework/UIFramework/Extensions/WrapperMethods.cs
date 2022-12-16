using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.BasicSetUp;

namespace UIFramework.Extensions
{
    public class WrapperMethods
    {
        IWebDriver driver;

        public IWebElement FindElementByXpath(string elementLocator)
        {
            return driver.FindElement(By.XPath(elementLocator));
        }

        public IWebElement FindElementByCSS(string elementLocator)
        {
            return driver.FindElement(By.CssSelector(elementLocator));
        }

        public IWebElement FindElement(string elementLocator)
        {
            if (elementLocator.StartsWith("\\"))
            {
                return FindElementByXpath(elementLocator);
            }
            else
                return FindElementByCSS(elementLocator);
        }

        public void CustomClickWithWait(IWebElement element, int sec)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds((sec)));
            wait.Until(c => element.Enabled);
        }

    }
}
