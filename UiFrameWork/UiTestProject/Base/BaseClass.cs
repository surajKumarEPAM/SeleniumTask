using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using UILibraryProject;
using OpenQA.Selenium.IE;

namespace UiTestProject.Base
{
     public class BaseClass
    {
        //public static IWebDriver driver;

        public static void InvokeBrowser()
        {
            string driverPath = "..\\..\\..\\..\\Drivers";
           // string browserName = ConfigurationManager.AppSettings["browser"];
            string browserName = "Chrome";
            InitilizeBrowser(browserName, driverPath);
            BrowserElement.driver.Navigate().GoToUrl("https:\\www.google.com");
            BrowserElement.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            BrowserElement.driver.Manage().Window.Maximize();
        }
        public IWebDriver GetDriver()
        {
            return BrowserElement.driver;
        }
        public static void InitilizeBrowser(string browserName, string driverPath)
        {
            switch (browserName)
            {
                case "Chrome":
                    BrowserElement.driver = new ChromeDriver(driverPath); break;
                    
                case "Firefox":
                    BrowserElement.driver = new FirefoxDriver(driverPath); break;
                case "Edge":
                    BrowserElement.driver = new EdgeDriver(driverPath); break;
            }
        }

    }
}
