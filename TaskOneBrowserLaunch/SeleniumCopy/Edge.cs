using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;


namespace SeleniumCopy
{
    internal class Edge
    {
        public void EdgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            signInBtn.Click();
            Console.WriteLine(driver.Title);
            IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            if (EmailOrPhone.Displayed)
            {
                Console.WriteLine("Email or Phone input box is displayed on sign page");
            }
            else
            {
                Console.WriteLine("Email or Phone input box is not displayed on the sign page");
            }
            Console.ReadLine();
            driver.Close();
        }
    }
}
