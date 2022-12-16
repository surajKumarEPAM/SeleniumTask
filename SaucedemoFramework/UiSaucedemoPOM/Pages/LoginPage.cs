using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Audits;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UIFramework.ReportGenerator.ExtentReportGenerator;
using UIFramework.ReportGenerator.ScreenShotsTaker;
using UIFramework.Utilities;

namespace UiSaucedemoPOM.Pages
{
    public class LoginPage : BasePage
    {
        
        #region Actions

        string userNameLocator = "user-name", userPasswordLocator = "password", loginButtonLocator = "login-button";
        public By LocateByID(string idName)
        {
            return By.Id(idName);
        }

        public void SendUserNameToUserTextBox(string userName)
        {
            report.test = report._extentReports.CreateTest("Login Page Test").Info("Test Started");
            SendKeysToTextFiled(LocateByID(userNameLocator), userName);
            report.test.Log(Status.Info, "successfully " + userName + " username sent the the user-name text field");
        }

        public void SendPasswordToPasswordTextBox(string password)
        {
            SendKeysToTextFiled(LocateByID(userPasswordLocator), password);
            report.test.Log(Status.Info, "successfully password " + password + " sent the the password text field");
        }

        public string GetUserName()
        {
            return GetElement(LocateByID(userNameLocator)).Text;
        }

        public void ClickOnLoginButton()
        {
            ClickOnElement(LocateByID(loginButtonLocator));
            report.test.Log(Status.Info, "successfully clicked on the login button");
        }

        public void VerifyTheValidUser(string expecterUrlKeyword)
        {
            string actualUrl = GetUrl;
            var urlToValidate = actualUrl.Contains(expecterUrlKeyword);

            if (urlToValidate)
            {
                report.test.Log(Status.Pass, "VALID LOGIN");
            }
            else
            {
                report.test.Log(Status.Fail, "INVALID LOGIN");
            }

            if (report.test.Status == Status.Fail)
            {
                MyScreenshot.TakeSecreenShot();
                report.test.AddScreenCaptureFromPath(MyScreenshot.screenShotPath);
            }

        }

        public string GetTitleOfThePage()
        {
            return TitleOfThePage();
        }

        #endregion
    }
}
