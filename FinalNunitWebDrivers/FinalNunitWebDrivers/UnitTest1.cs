using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace FinalNunitWebDrivers
{
    
    public class EdgeBrowserTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var driverpath = Path.GetFullPath("..\\..\\..\\Drivers");
            driver = new EdgeDriver(driverpath);
        }

        [Test]
        public void EdgeLaunchTest()
        {
           
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            signInBtn.Click();
            Console.WriteLine(driver.Title);
            IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            Console.WriteLine("Edge Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown]
        public void closeDriver() 
        {
            driver.Close(); 
        }
    }
    public class ChromeBrowserTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var driverpath = Path.GetFullPath("..\\..\\..\\Drivers");
            driver = new ChromeDriver(driverpath);
        }

        [Test]
        public void ChromeLaunchTest()
        {

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            signInBtn.Click();
            Console.WriteLine(driver.Title);
            IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            Console.WriteLine("Chrome Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown]
        public void closeDriver()
        {
            driver.Close();
        }
    }
    public class FirefoxBrowserTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var driverpath = Path.GetFullPath("..\\..\\..\\Drivers");
            driver = new FirefoxDriver(driverpath);
        }

        [Test]
        public void FirefoxLaunchTest()
        {

            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            signInBtn.Click();
            Console.WriteLine(driver.Title);
            IWebElement EmailOrPhone = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            Console.WriteLine("Firefox Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown]
        public void closeDriver()
        {
            driver.Close();
        }
    }
}