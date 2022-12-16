using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UiSaucedemoPOM.Pages;

namespace UiSaucedemoTest.StepDefination
{
    [Binding]
    public class Cart
    {
        CartPage cartPage=new CartPage();
      
        [When(@"I click on the cart icon")]
        public void WhenIClickOnTheCartIcon()
        {
            cartPage.clickOnTheCartIcon();
        }

        [Then(@"All item added in the cart should display")]
        public void ThenAllItemAddedInTheCartShouldDisplay()
        {
            cartPage.veryfyTheItemInTheCart();
        }

    }
}
