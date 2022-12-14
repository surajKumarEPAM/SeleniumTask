using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILibraryProject.Extensions
{
    public class ExtensionMethod
    {
        WebDriverWait wait;
        IWebElement webElement;
        public void LongWaitForDriver()
        {
             wait = new WebDriverWait(BrowserElement.driver, TimeSpan.FromMinutes(2));
            

        }
        public void ShortWaitForDriver()
        {
            wait = new WebDriverWait(BrowserElement.driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement FindElementByXpath(string elementLocator)
        {
            return BrowserElement.driver.FindElement(By.XPath(elementLocator));
        }
        public IWebElement FindElementByCSS(string elementLocator)
        {
            return BrowserElement.driver.FindElement(By.CssSelector(elementLocator));
        }
        public IWebElement FindElement(string elementLocator)
        { 
            if(elementLocator.StartsWith("\\"))
            {
               return FindElementByXpath(elementLocator);
            }
            else
               return FindElementByCSS(elementLocator);
        }
    }
}
