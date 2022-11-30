using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;


namespace SeleniumCopy
{
    internal class Chrome
    {
        public void ChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver();
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
            driver.Close();
            Console.ReadLine();
        }
    }
}
