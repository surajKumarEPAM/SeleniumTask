using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitOPP
{
    
        public class BrowserAction
        {
            public IWebDriver driver;
            String driverPath;
            public String SetupPath()
            {
                driverPath = Path.GetFullPath("..//..//..//Drivers");
                return driverPath;

            }
            public void Navigating()
            {
                driver.Navigate().GoToUrl("https://www.google.com");
                driver.Manage().Window.Maximize();
                Console.WriteLine(driver.Title);
                IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
                signInBtn.Click();
                Console.WriteLine(driver.Title);
                IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
                
            }
            public void CloseDriver()
            {
                driver.Close();
            }
        }
    
}
