using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;

namespace NunitWait
{
   
    public class ImplicitWait
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            String driverPath = Path.GetFullPath("..//..//..//Drivers");
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");

        }

        [Test]
        public void TestMethodForImplicitWait()
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromMilliseconds(13000);
               
                Console.WriteLine("Title of the page " + driver.Title);
                Console.WriteLine("Length of the title " + driver.Title.Length);
                Console.WriteLine("The Url of the page is " + driver.Url);
                Console.WriteLine("The Url of the page is " + driver.Url.Length);
                String pagesource = driver.PageSource;
                int pageSourceLength = pagesource.Length;
                Console.WriteLine("the pagesouce is");
                Console.WriteLine(pagesource);
                Console.WriteLine("The length of pagesource is " + pageSourceLength);

            }
            catch (Exception ex)
            {
               
                Assert.Fail(ex.Message);
            }
            finally 
            { 
                driver.Quit(); 
            }
            
          
        }
        
    }
    public class ExplicitWait
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            String driverPath = "C:\\Users\\Suraj_Kumar\\Downloads\\Drivers";
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");

        }

        [Test]
        public void TestMethodForExplicitWait()
        {
            try
            {
                WebDriverWait wait=new WebDriverWait(driver, TimeSpan.FromMilliseconds(13000));
            
                //IWebElement ele= ExplicitWaitMethod(driver, "1234");
                Console.WriteLine("Title of the page " + driver.Title);
                Console.WriteLine("Length of the title " + driver.Title.Length);
                Console.WriteLine("The Url of the page is " + driver.Url);
                Console.WriteLine("The Url of the page is " + driver.Url.Length);
                String pagesource = driver.PageSource;
                int pageSourceLength = pagesource.Length;
                Console.WriteLine("the pagesouce is");
                Console.WriteLine(pagesource);
                Console.WriteLine("The length of pagesource is " + pageSourceLength);

            }
            catch (Exception ex)
            {

                Assert.Fail(ex.Message);
            }
            finally
            {
                driver.Quit();
            }

            //public static IwebElement ExplicitWaitMethod(IWebDriver driver,String id)
            //{
            //    return new WebDriverWait(driver,TimeSpan.FromMilliseconds(10000)).Until(Ex)
            //}
        }

    }
}