using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using SeleniumCopy;

namespace SeleniumCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chrome chrome= new Chrome();
            //chrome.ChromeBrowser();
            //Edge edge = new Edge();
            //edge.EdgeBrowser();
            FireFox fireFox = new FireFox();
            fireFox.FireFoxBrowser();
            Console.ReadLine();
            
        }
    }
}
