using CommonLibrary.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMForEPam.Pages
{
    public class ResultPage :BasePage
    {
        #region Locators
        By resultText =By.XPath("//h2[@class='search-results__counter']");

        #endregion
        #region Actions
        IWebElement searchElement;
        int totalNoOfResult;
        public void GetSearchElement()
        {
            searchElement=GetElement(resultText);

        }
        public bool GetTotalNoOfResult()
        {
            String resultHeadlingText = searchElement.Text;
            string[] splitText = resultHeadlingText.Split(" ");
            string result = splitText[0];
          
            totalNoOfResult = Convert.ToInt32(result);
            if(totalNoOfResult>0)
                return true;
            else 
                return false;
        }
        #endregion
    }
}
