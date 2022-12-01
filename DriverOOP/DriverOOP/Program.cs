using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;

namespace DriverOOP
{
    class BrowserAction
    {
        public IWebDriver driver;
        String driverPath;
        public String Setup()
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
    class Chrome : BrowserAction
    {
        public void Chromelaunch()
        {
            driver = new ChromeDriver(Setup());
            
        }
        
    }
    class Edge : BrowserAction
    {
        public void EdgeLaunch()
        {
            driver = new EdgeDriver(Setup());
            
        }

    }
    class Firefox : BrowserAction
    {
        public void FirefoxLaunch()
        {
            driver = new FirefoxDriver(Setup());
           
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chrome chrome=new Chrome();
            //chrome.Chromelaunch();
            //chrome.Navigating();
            //chrome.CloseDriver();


            //Firefox firefox=new Firefox();
            //firefox.FirefoxLaunch();
            //firefox.Navigating();
            //firefox.CloseDriver();


            Edge edge = new Edge();
            edge.EdgeLaunch();
            edge.Navigating();
            edge.CloseDriver();
        }
    }
}
