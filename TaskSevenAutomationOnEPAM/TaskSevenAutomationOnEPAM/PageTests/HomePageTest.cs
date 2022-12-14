using CommonLibrary.Utility;
using POMForEPam.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamPagesTest.PageTests
{
    internal class HomePageTest
    {
       
        [SetUp]
        public void StartTest()
        {
            BasePage basePage= new BasePage();
            basePage.SetDriver();
            basePage.Start();

        }
        HomePage homePage = new HomePage();

        [Test]
        public void TestHomePage()
        {
            homePage.clickOnTheMagnifierButton();
            homePage.clickOnTheMagnifierButton();
            homePage.clickOnDeveops();
            homePage.clickOnTheFindButton();
        }
      

    }

}
