using CommonLibrary.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMForEPam.Pages
{
    public class HomePage : BasePage
    {
        #region Locators
        By magnifierElement = By.XPath("//button[@class='header-search__button header__icon']");
        By devopsListElement = By.XPath("//li[contains(text(),'DevOps')]");
        By findButton = By.XPath("//button[contains(text(),'Find')]");
        By searchResultItem = By.XPath("//h2[@class='search-results__counter']");
        #endregion

        #region Actions
        public void clickOnTheMagnifierButton()
        {
            ClickOnElement(magnifierElement); 
        }
        public void clickOnTheFindButton()
        {
            ClickOnElement(findButton);
        }
        public void clickOnDeveops()
        {
            ClickOnElement(devopsListElement);
        }

        #endregion

    }
}

