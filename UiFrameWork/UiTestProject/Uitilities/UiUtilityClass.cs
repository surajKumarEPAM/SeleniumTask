using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILibraryProject;
using UiTestProject.Base;

namespace UiTestProject.Uitilities
{
    public class UiUtilityClass
    {

        private static IJavaScriptExecutor executor = (IJavaScriptExecutor)BrowserElement.driver;
        
        
        public static void SendKeysAsAText(IWebElement searchBoxElement,string searchText)
        {
            searchBoxElement.SendKeys(searchText);
            //executor.ExecuteScript("arguments[0].click()", searchBoxElement);
        }
        public static void ClickOnElement(IWebElement element)
        {
            executor.ExecuteScript("arguments[0].click()", element);

        }

    }
}
