using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;

namespace Saucedemo
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait;
        IJavaScriptExecutor executor;
        [SetUp]
        public void Setup()
        {
            String driverPath = "..//..//..//Drivers";
            driver = new ChromeDriver(driverPath);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void DifferntActions()
        {
            IWebElement userBox = driver.FindElement(By.Id("user-name"));
            userBox.SendKeys("standard_user");
            IWebElement passwordBox = driver.FindElement(By.Id("password"));
            passwordBox.SendKeys("secret_sauce");
            IWebElement clickbutton = driver.FindElement(By.Id("login-button"));
            clickbutton.Click();
            IWebElement priceElement = driver.FindElement(By.XPath("//div[@class='inventory_list']/child::div[1]//div[@class='inventory_item_price']"));
            String priceBeforeCLick=priceElement.Text;
            Console.WriteLine(priceBeforeCLick);
            IWebElement elementAddToCart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            elementAddToCart.Click();
            IWebElement elementCart = driver.FindElement(By.Id("shopping_cart_container"));
            elementCart.Click();
           
            IWebElement priceElementAfterClick = driver.FindElement(By.XPath("//div[@class='inventory_item_price']"));
            String priceAfterElement= priceElementAfterClick.Text;
            Assert.That(priceBeforeCLick,Is.EqualTo(priceAfterElement));
            IWebElement checkOutButton = driver.FindElement(By.Id("checkout"));
            checkOutButton.Click();
            IWebElement firstNameElement = driver.FindElement(By.Id("first-name"));
            firstNameElement.SendKeys("Suraj");
            IWebElement lastNameElement = driver.FindElement(By.Id("last-name"));
            lastNameElement.SendKeys("Kumar");
            IWebElement zipCodeElement = driver.FindElement(By.Id("postal-code"));
            zipCodeElement.SendKeys("805107");
            Thread.Sleep(1000);
            IWebElement continurButton = driver.FindElement(By.Id("continue"));
            continurButton.Click();
            IWebElement priceElementAfterCheckout = driver.FindElement(By.XPath("//div[@class='inventory_item_price']"));
            String priceAfterCheckout = priceElementAfterCheckout.Text;
            Assert.That(priceAfterElement,Is.EqualTo(priceAfterCheckout));
            IWebElement finishButton = driver.FindElement(By.Id("finish"));
           
            finishButton.Click();
           
        }
        [TearDown]
        public void CloseDriver()
        {
            driver.Close(); 
        }
    }
}