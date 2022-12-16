using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.BasicSetUp;

namespace UIFramework.Extensions
{
    public class CustumTimeSpan
    {
        WebDriverWait wait;
        IWebElement webElement;

        public void LongWaitForDriver()
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromMinutes(1));
        }

        public void ShortWaitForDriver()
        {
            wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
        }

    }
}
