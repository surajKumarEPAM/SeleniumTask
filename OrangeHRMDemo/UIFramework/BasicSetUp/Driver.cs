using AventStack.ExtentReports;
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
using UIFramework.ReportGenerator.ExtentReport;

namespace UIFramework.BasicSetUp
{
    public class Driver
    {
        [ThreadStatic]
        public static IWebDriver driver;
        public static ExtentReportGenerator report = new ExtentReportGenerator();

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void SetAnyDriver()
        {
            string currentDirectroy = Directory.GetCurrentDirectory();
            string parentDriverPath = Directory.GetParent(currentDirectroy).Parent.Parent.Parent.FullName;
            string driverPath = parentDriverPath + "\\UIFramework\\Drivers\\";
            string browserName = ConfigurationManager.AppSettings["browser"];

            switch (browserName)
            {
                case "Chrome":
                    driver = new ChromeDriver(driverPath);
                    break;
                case "Firefox":
                    driver = new FirefoxDriver(driverPath);
                    break;
                case "Edge":
                    driver = new EdgeDriver(driverPath);
                    break;
            }
            report.ExtentReportStart();
        }

        public void CloseDriver()
        {
            report.ExtentReportClose();
            driver.Close();
        }

    }
}
