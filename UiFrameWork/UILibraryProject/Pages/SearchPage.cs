using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UILibraryProject.Pages
{
    public class SearchPage
    {
        #region Locators

        By searchBar = By.Name("q");
        By searchButton = By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@value='Google Search']");
        By signInButton = By.XPath("//div[@class='gb_We']/a[contains(text(),'Sign in')]");
        

        #endregion

        #region Actions

        public IWebElement GetSearchBar()
        {
            

            return BrowserElement.driver.FindElement(searchBar);


        }
        public IWebElement GetSearchButton()
        {
            BrowserElement.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return BrowserElement.driver.FindElement(searchButton);
        }
        public IWebElement GetSignInButton()
        {
            return BrowserElement.driver.FindElement(signInButton);
        }
        #endregion
    }
}
