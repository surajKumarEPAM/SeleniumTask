using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UiSaucedemoPOM.Pages
{
    public class CommonActionPage : BasePage
    {
        #region Locators
       
        By AddButtonElement => By.XPath("//button[contains(text(),'Add to cart')]");
        By cartIcon => By.ClassName("shopping_cart_link");
        #endregion

        #region Actions
        string userNameTextBox = "user-name", userPasswordTextBox = "password", loginButton = "login-button";
        public By LocateByID(string idName)
        {
            return By.Id(idName);
        }
        public void SendUserNameToUserTextBox(string userName)
        {
            SendKeysToTextFiled(LocateByID(userNameTextBox), userName);
        }

        public void SendPasswordToPasswordTextBox(string password)
        {
            SendKeysToTextFiled(LocateByID(userPasswordTextBox), password);
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(LocateByID(loginButton));
        }

        public void AddAllItemsInTheCart()
        {
            IList<IWebElement> addButtonElementList = GetElementsList(AddButtonElement);
            foreach (IWebElement addButtonElement in addButtonElementList)
            {
                addButtonElement.Click();
            }
        }

        public void ClickOnTheCartIcon()
        {
            ClickOnElement(cartIcon);
        }

        #endregion
    }
}

