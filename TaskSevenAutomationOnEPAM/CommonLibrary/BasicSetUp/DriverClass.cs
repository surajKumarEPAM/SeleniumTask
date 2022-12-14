using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.BasicSetUp
{
    public class DriverClass
    {
        [ThreadStatic]
        public static IWebDriver driver;

        public  IWebDriver GetDriver()
        {
            return driver;
        }
        public void SetAnyDriver()
        {
            string currentDirectroy=Directory.GetCurrentDirectory();
            string parentDriverPath = Directory.GetParent(currentDirectroy).Parent.Parent.Parent.FullName;
            string driverPath = parentDriverPath + "\\CommonLibrary\\Drivers\\";
            // string driverPath = Path.GetFullPath("..\\..\\..\\..\\Drivers");
            string browserName = ConfigurationManager.AppSettings["browser"];
           // string browserName = "Chrome";
            
            switch (browserName)
            {
                case "Chrome":
                    driver=new ChromeDriver(driverPath);
                    break;
                case "Firefox":
                    driver=new FirefoxDriver(driverPath);
                    break;
                case "Edge":
                    driver=new EdgeDriver(driverPath);
                    break;

            }
        }
        public void CloseDriver()
        {
            driver.Close();
        }
    }
}
