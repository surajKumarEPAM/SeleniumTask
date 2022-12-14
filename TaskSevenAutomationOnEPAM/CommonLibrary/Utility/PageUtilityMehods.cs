using CommonLibrary.BasicSetUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Utility
{
    public class PageUtilityMehods
    {
       
        public static IWebElement GetElement(By element)
        {
            return DriverClass.driver.FindElement(element);
        }
        public static void NavigateToUrl(string url)
        {
            DriverClass.driver.Navigate().GoToUrl(url);
        }

        public static void ClickOnElement(By element)
        {
            DriverClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DriverClass.driver.FindElement(element).Click();
        }

        public static void MaximizeThePage()
        {
            DriverClass.driver.Manage().Window.Maximize();
        }
        public static IList<IWebElement> GetElementsList(By element)
        {   
            return DriverClass.driver.FindElements(element);
        }
        public static void SendKeysToTextFiled(By element, string text)
        {
            DriverClass.driver.FindElement(element).SendKeys(text);
        }
    }
}
