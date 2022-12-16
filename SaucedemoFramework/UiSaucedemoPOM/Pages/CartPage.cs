using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIFramework.ReportGenerator.ExtentReportGenerator;
using UIFramework.Utilities;

namespace UiSaucedemoPOM.Pages
{
    public class CartPage : BasePage
    {
        #region Locators
        By cartIcon => By.ClassName("shopping_cart_link");
        By itemName => By.ClassName("inventory_item_name");
        #endregion

        #region Actions
        int cartIndexIncrement = 0, countOfProdutsInTheCart = 0;
        string[] productsNameAddedInTheCart;

        public void clickOnTheCartIcon()
        {
            report.test = report._extentReports.CreateTest("Cart Page Test").Info("Test Started");
            ClickOnElement(cartIcon);
            report.test.Log(Status.Info, "successfully clicked on the cart icon");
        }

        public void veryfyTheItemInTheCart()
        {
            IList<IWebElement> products = GetElementsList(itemName);
            productsNameAddedInTheCart = InventoryPage.GetAllElementsNameFromInVentoryPage(products.Count);

            foreach (var element in products)
            {
                if (productsNameAddedInTheCart[cartIndexIncrement++].Equals(element.Text))
                {
                    countOfProdutsInTheCart++;
                }
            }

            if (countOfProdutsInTheCart == (productsNameAddedInTheCart.Length))
            {
                report.test.Log(Status.Pass, "Each item matches in the cart which is added in the inventory page");
            }
            else
            {
                report.test.Log(Status.Fail, "Some item is missing in that cart which is added in the inventory page");
            }
        }
        #endregion
    }
}

