using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UIFramework.Utilities;
using UiSaucedemoPOM.Pages;

namespace UiSaucedemoTest.StepDefination
{
    [Binding]
    public class Inventory
    {
        LoginPage loginPage = new LoginPage();
        InventoryPage inventoryPage = new InventoryPage();
        string actualText;

        [Given(@"I Navigated to the Inventory page")]
        public void GivenINavigatedToTheInventoryPage()
        {
            loginPage.SendUserNameToUserTextBox("standard_user");
            loginPage.SendPasswordToPasswordTextBox("secret_sauce");
            loginPage.ClickOnLoginButton();
        }

        [When(@"I click on the add to cart")]
        public void WhenIClickOnTheAddToCart()
        {
            inventoryPage.AddProductToCart();
        }

        [Then(@"That button text should become ""([^""]*)""")]
        public void ThatButtonTextShouldBecome(string expectedText)
        {
            inventoryPage.verifyAddButton(expectedText);
        }

    }
}
