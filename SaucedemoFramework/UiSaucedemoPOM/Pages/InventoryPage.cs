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
    public class InventoryPage : BasePage
    {
        #region Locators
        By AddButtonElement => By.XPath("//button[contains(text(),'Add to cart')]");
        By RemoveButton => By.XPath("//button[contains(text(),'Remove')]");
        static By productNameText => By.XPath("//div[@class='inventory_item_name']");
        #endregion
       
        #region Actions
        public By LocateByXPath(string idName)
        {
            return By.Id(idName);
        }
        public void AddProductToCart()
        {
            report.test = report._extentReports.CreateTest("Inventory Page Test").Info("Test Started");
            IList<IWebElement> addButtonElementList = GetElementsList(AddButtonElement);
            foreach (IWebElement addButtonElement in addButtonElementList)
            {
                addButtonElement.Click();
            }
            report.test.Log(Status.Info, "Add to the cart buttons clicked on the inventory page successfully");
        }

        public void verifyAddButton(string expectedText)
        {
            string actualText;
            int count = 0;
            IList<IWebElement> removeButtonElementList = GetElementsList(RemoveButton);
            foreach (IWebElement removeButtonElement in removeButtonElementList)
            {
                actualText = removeButtonElement.Text;
                if (actualText.Equals(removeButtonElement.Text))
                {
                    count++;
                }
            }
            if (count == removeButtonElementList.Count)
            {
                report.test.Log(Status.Pass, "All item Successfully added into the cart");
            }
            else
            {
                report.test.Log(Status.Fail, "There was some problem in adding item in the cart");
            }
        }

        public static string[] GetAllElementsNameFromInVentoryPage(int noOfCartItems)
        {
            string[] productName = new string[noOfCartItems];
            IList<IWebElement> removeButtonElementList = GetElementsList(productNameText);
            int index = 0;
            foreach (var element in removeButtonElementList)
            {
                productName[index++] = element.Text;
            }
            return productName;
        }

        public IWebElement GetRemoveButton()
        {
            return GetElement(RemoveButton);
        }
        #endregion
    }
}
