using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace BrowserWithNunit
{
    //public class Tests
    //{
    //    IWebDriver driver;
    //    [SetUp]
    //    public void Setup()
    //    {
    //        driver = new ChromeDriver();
    //    }

    //    [Test]
    //    public void Test1()
    //    {
    //        driver.Navigate().GoToUrl("https://www.google.com");
    //        driver.Manage().Window.Maximize();
    //        Console.WriteLine(driver.Title);
    //        IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
    //        signInBtn.Click();
    //        Console.WriteLine(driver.Title);
    //        IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
    //        Assert.Pass();
    //    }
    //    [TearDown]
    //    public void TearDown()
    //    {
    //        driver.Quit();
    //    }

    //}
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Firefox"+driver.Title);
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            signInBtn.Click();
            Console.WriteLine("FireFox"+driver.Title);
            IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
 }