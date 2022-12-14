using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UILibraryProject.Pages
{
    public class SignInPage
    {
        #region Locators : 

        By emailIdText = By.XPath("//input[@type='email']");
        By nextButton = By.XPath("//span[contains(text(),'Next')]");

        #endregion


        #region Action

        public IWebElement GetEmailText()
        {
            return BrowserElement.driver.FindElement(emailIdText);
        }
        public IWebElement GetNextButton()
        {
            return BrowserElement.driver.FindElement(nextButton);
        }
        #endregion
    }
}
