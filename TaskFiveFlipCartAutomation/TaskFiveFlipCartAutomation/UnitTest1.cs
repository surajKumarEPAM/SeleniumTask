using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Overlay;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace TaskFiveFlipCartAutomation
{
    public class Tests
    {
        String driverPath = "..//..//..//Drivers";
        ChromeDriver driver;
        [SetUp]
        public void Setup()
        {
            
            driver= new ChromeDriver(driverPath);
            //driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(50);
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click(); //dismiss the login pop-up
            //ReadOnlyCollection<String> allWindows=driver.WindowHandles;
            //Console.WriteLine(driver.CurrentWindowHandle);
            //Console.WriteLine(allWindows.);
            //foreach (String str in allWindows)
            //{
            //    Console.WriteLine(str);
            //}
            //IWebElement element = driver.FindElement(By.XPath("//input[@class='_2IX_2- _2LYh3d VJZDxU']"));
            //element.SendKeys("Ankesha");
            //IWindow win=driver.SwitchTo().ActiveElement();

            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);
            //IWebElement element1 = driver.FindElement(By.XPath("//span[contains(text(),'Login')]"));
            //element.Click();
            //IWebElement searchElement = driver.FindElement(By.XPath("//input[@title='Search for products, brands and more']"));
            //searchElement.SendKeys("Phone");
            //driver.FindElement(By.XPath("//button[@class=\"L0Z3Pu\"]/child::*")).Click();  //clicking on the search icon
            //Assert.IsTrue();
            //IsElementPresent
            

           // List<WebElement> list = driver.findElements(By.xpath("//*[contains(text(),'" + text + "')]"));
           // Assert.assertTrue("Text not found!", list.size() > 0);

        }

        [Test]
        public void FindMobileTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Mobiles')]"));
           
            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindFashionTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Fashion')]"));
           
            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindElectronicsTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Electronics')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindHomeTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Home')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindTravelTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Travel')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindAppliancesTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Appliances')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindFurnitureTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Furniture')]"));

            Assert.IsFalse(list.Count() > 0);

        }
        [Test]
        public void FindBeautyToyAndMoreTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Beauty, Toys & More')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void FindGroceryTab()
        {
            ReadOnlyCollection<IWebElement> list = driver.FindElements(By.XPath("//div[contains(text(),'Grocery')]"));

            Assert.IsTrue(list.Count() > 0);

        }
        [Test]
        public void ClickingElectronicsTab()
        {
            IWebElement electronicsElement =driver.FindElement(By.XPath("//div[contains(text(),'Electronics')]"));
            electronicsElement.Click();

        }
        [Test]
        public void SelectingSplitAcFromTV()
        {
            IWebElement element;
            element= driver.FindElement(By.XPath("//div[@class='xtXmba' and contains(text(),'Appliances')]"));
            element.Click();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            element = driver.FindElement(By.XPath("//span[contains(text(),'TVs & Appliances')]"));
            element.Click();
            element = driver.FindElement(By.XPath("//a[@title='Split ACs']"));
            element.Click();
            element = driver.FindElement(By.XPath("//div[@class='_1YokD2 _3Mn1Gg']/child::div[2]//div[@class='_30jeq3 _1_WHN1']"));
            String priceBeforeClick = element.Text;
            element = driver.FindElement(By.XPath("//div[@class='_1YokD2 _3Mn1Gg']/child::div[2]"));
            element.Click();
            WebDriverWait wait=new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            element = driver.FindElement(By.XPath("//div[@class='_30jeq3 _16Jk6d']"));
            String priceAfterClick= element.Text;
            //Assert.AreEqual(priceBeforeClick, priceAfterClick);
            Assert.That(priceBeforeClick,Is.EqualTo(priceAfterClick));
            element.Click();

        }




























        //[Test]
        //public void SelectSplitAcTab()
        //{
        //    IWebElement electronicsElement = driver.FindElement(By.XPath("//div[contains(text(),'Appliances')]"));
        //    electronicsElement.Click();
        //    IWebElement tvAndAppliances = driver.FindElement(By.XPath("//span[contains(text(),'TVs & Appliances')]"));
        //    tvAndAppliances.FindElement(By.XPath("//a[contains(text()='Split')]")).Click();
        //    IWebElement splitAc = driver.FindElement(By.XPath("//a[contains(text()='Split')]"));
        //    splitAc.Click();
        //}
    }
}