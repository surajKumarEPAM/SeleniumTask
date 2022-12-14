using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiTestProject.Test.BaseTest;
using UiTestProject.Uitilities;
using UILibraryProject.Pages;
using UiTestProject.Base;
using AventStack.ExtentReports;

namespace UiTestProject.Test
{
    internal class SearchPageTest
    {
        BaseTestForBrowser baseTestForBrowser=new BaseTestForBrowser();
        SearchPage searchPage=new SearchPage();
        ExtentReportGenerator report = new ExtentReportGenerator();

        [Test]
        public void ActionsOnSearchPage()
        {
            report.ExtentReportStart();
            report.test = report._extentReports.CreateTest("SearchTest").Info("Test Started");
            baseTestForBrowser.Stepup();
            report.test.Log(Status.Info, "Browser is launched and Navigated successfully");

            UiUtilityClass.SendKeysAsAText(searchPage.GetSearchBar(), "Epam");
            report.test.Log(Status.Info, "Successfully sended the keys in searchbox");


            UiUtilityClass.ClickOnElement(searchPage.GetSearchButton());
            report.test.Log(Status.Info, "Successfully Click on search button and got the result");
            TakeScreenshot screeshot = new TakeScreenshot();
            screeshot.TakeSecreenShot();
            report.test.Log(Status.Info, "Screenshot is taken successfully");

            report.test.Log(Status.Pass, "Searching test case paassed");
            report.ExtentReportClose();
        }
      
    }
}
