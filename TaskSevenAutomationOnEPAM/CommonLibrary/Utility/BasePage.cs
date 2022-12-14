using CommonLibrary.BasicSetUp;
using CommonLibrary.SourceForSetUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Utility
{
    public class BasePage : PageUtilityMehods
    {
        public IWebDriver driver = DriverClass.driver;

        public string GetTitle => DriverClass.driver.Title;

        public string GetUrl => DriverClass.driver.Url;

        public string GetPageSource => DriverClass.driver.PageSource;

        public  void SetDriver()
        {
            DriverClass driverClass = new DriverClass();
            driverClass.SetAnyDriver();
        }

        public void Start()
        {
            NavigateToUrl(SourceClass.NavigationUrl);
            MaximizeThePage();
        }
    }
}
