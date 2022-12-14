using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UILibraryProject.Pages;
using UiTestProject.Base;
using UiTestProject.Test.BaseTest;
using UiTestProject.Uitilities;

namespace UiTestProject.Test
{
    internal class SignInPageTest
    {
        BaseTestForBrowser baseTestForBrowser = new BaseTestForBrowser();
        SignInPage signInPage = new SignInPage();
        ExtentReportGenerator report = new ExtentReportGenerator();

        [Test]
        public void ActionOnSignInPage()
        {
            report.ExtentReportStart();
            report.test = report._extentReports.CreateTest("SearchTest").Info("Test Started");
            baseTestForBrowser.Stepup();
            report.test.Log(Status.Info, "Browser is launched and Navigated successfully");

            UiUtilityClass.ClickOnElement(new SearchPage().GetSignInButton());
            report.test.Log(Status.Info, "Successfully Navigated to the sign page");

            UiUtilityClass.SendKeysAsAText(signInPage.GetEmailText(), "xyz@gmail.com");
            report.test.Log(Status.Info, "Successfully sended the email in emailBox");
            TakeScreenshot screeshot = new TakeScreenshot();
            screeshot.TakeSecreenShot();
            report.test.Log(Status.Info, "Screenshot is taken successfully");

            UiUtilityClass.ClickOnElement(signInPage.GetNextButton());
            report.test.Log(Status.Info, "Successfully displayed invalid email id");
            report.test.Log(Status.Pass, "login for invaild credentials test case paassed");
            report.ExtentReportClose();

        }
       
    }
}
