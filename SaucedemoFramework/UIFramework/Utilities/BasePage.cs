using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.BasicSetUp;
using UIFramework.ReportGenerator.ExtentReportGenerator;
using UIFramework.SourceForSetUp;

namespace UIFramework.Utilities
{
    public class BasePage : PageUtility
    {
        Driver driverClass = new Driver();
        public IWebDriver driver = Driver.driver;
        public string GetTitle => Driver.driver.Title;
        public string GetUrl => Driver.driver.Url;
        public string GetPageSource => Driver.driver.PageSource;

        public void SetDriver()
        {
            driverClass.SetAnyDriver();
        }

        public void Start()
        {
            NavigateToUrl(Source.NavigationUrl);
            MaximizeThePage();
        }

        public void Stop()
        {
            driverClass.CloseDriver();
        }
        
    }
}

