using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace NUnitOPP
{
   
    public class Chrome : BrowserAction
    {
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(SetupPath());
        }

       
        [Test]
        public void Test1()
        {
            Navigating();
            Console.WriteLine("Chrome Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown] 
        public void closeChrome()
        {
            CloseDriver();
        }
    }
    public class Edge : BrowserAction
    {
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver(SetupPath());
        }


        [Test]
        public void Test1()
        {
            Navigating();
            Console.WriteLine("Edge Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown]
        public void closeEdge()
        {
            CloseDriver();
        }
    }
    public class Firefox : BrowserAction
    {
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver(SetupPath());
        }


        [Test]
        public void Test1()
        {
            Navigating();
            Console.WriteLine("Firefox Lauched and Navigated Successfully");
            Assert.Pass();
        }
        [TearDown]
        public void closeFirefox()
        {
            CloseDriver();
        }
    }
}