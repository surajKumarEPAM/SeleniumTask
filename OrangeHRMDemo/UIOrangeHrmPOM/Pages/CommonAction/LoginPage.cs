using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.Utilities;

namespace UIOrangeHrmPOM.Pages.CommonAction
{
    public class LoginPage : BasePage
    {
        #region Locator
        By loginButton = By.XPath("//button[@type='submit']");
        By titlePath=By.XPath("//h6[contains(text(),'Dashboard')]");
        #endregion

        #region Actions
        string userNameLocator = "Username", userPasswordLocator = "Password";
        public By LocateByPlaceholderName(string placeholderName)
        {
            string xpathLocator = $"//input[@placeholder='{placeholderName}']";
            return By.XPath(xpathLocator);
        }

        public void SendUserNameToUserTextBox(string userName)
        {
            report.test = report._extentReports.CreateTest("Login to the page ").Info("Test Started");
            SendKeysToTextFiled(LocateByPlaceholderName(userNameLocator), userName);
            report.test.Log(Status.Info, "successfully " + userName + " username sent the the user-name text field");
        }

        public void SendPasswordToPasswordTextBox(string password)
        {
            SendKeysToTextFiled(LocateByPlaceholderName(userPasswordLocator), password);
            report.test.Log(Status.Info, "successfully password " + password + " sent the the password text field");
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(loginButton);
            report.test.Log(Status.Info, "successfully clicked on the login button");
        }

        public void WaitForPageLoade()
        {
            WaitUnitlElementFound();
        }

        public string TitleOfThePage()
        {
            return GetElement(titlePath).Text;
        }

        public bool CheckUrlContains(string expectedUrlText)
        {
           string actualPageUrl = GetPageUrl();
           return actualPageUrl.Contains(expectedUrlText);
        }

        #endregion
    }
}
