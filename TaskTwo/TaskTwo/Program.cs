using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = Path.GetFullPath("..//..//..//Drivers");
            IWebDriver driver = new ChromeDriver(path);
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            //Selection Element
            IWebElement el1 = driver.FindElement(By.XPath("//h5[contains(text(),'Elements')]"));
            IWebElement el2 = driver.FindElement(By.XPath("//div[@class=\"card-body\"]/child::h5[contains(text(),'Element')]"));
            IWebElement el3 = driver.FindElement(By.XPath("//div[@class='avatar mx - auto white']/following-sibling::div/h5[contains(text(),'Element')]"));
            IWebElement el = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]/preceding-sibling::div/div/div[@class='card-body']/h5"));


            //Selection Forms
            IWebElement el1 = driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]"));
            IWebElement el2 = driver.FindElement(By.XPath("//div[@class=\"card-body\"]/child::h5[contains(text(),'Forms')]"));
            IWebElement el3 = driver.FindElement(By.XPath("//div[@class='avatar mx - auto white']/following-sibling::div/h5[contains(text(),'Forms')]"));
            IWebElement el = driver.FindElement(By.XPath("//div[@class='card mt - 4 top - card'][3]/preceding-sibling::div/div/div[@class='card-body']/h5"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(13000);
            el.Click();
            driver.Close();


        }
    }
}
