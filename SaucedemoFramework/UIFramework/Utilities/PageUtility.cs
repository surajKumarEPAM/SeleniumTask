using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.BasicSetUp;

namespace UIFramework.Utilities
{
    public class PageUtility : Driver
    {

        public static IWebElement GetElement(By element)
        {
            return Driver.driver.FindElement(element);
        }

        public static void NavigateToUrl(string url)
        {
            Driver.driver.Navigate().GoToUrl(url);
        }

        public static void ClickOnElement(By element)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(element).Click();
        }

        public static void MaximizeThePage()
        {
            Driver.driver.Manage().Window.Maximize();
        }

        public static IList<IWebElement> GetElementsList(By element)
        {
            return Driver.driver.FindElements(element);
        }

        public static void SendKeysToTextFiled(By element, string text)
        {
            Driver.driver.FindElement(element).SendKeys(text);
        }

        public static string TitleOfThePage()
        {
            string str = Driver.driver.Title;
            return str;
        }

    }
}
