using CommonLibrary.Utility;
using POMForEPam.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamPagesTest.PageTests
{
    public class ResultPageTest
    {
        HomePage homePage=new HomePage();
        [SetUp]
        public void StartTest()
        {
            BasePage basePage = new BasePage();
            basePage.SetDriver();
            basePage.Start();
            homePage.clickOnTheMagnifierButton();
            homePage.clickOnDeveops();
            homePage.clickOnTheFindButton();

        }
        ResultPage resultPage = new ResultPage();
        bool isTotalNoGreaterThanTen;

        [Test]
        public void TestHomePage()
        {
            resultPage.GetSearchElement();
            isTotalNoGreaterThanTen=resultPage.GetTotalNoOfResult();
            //Assert(isTotalNoGreaterThanTen);
            int x = 0;
        }
    }
}
