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
            //Using Chrome Driver
            //Chrome chrome= new Chrome();
            //chrome.ChromeBrowser();
            //Using Edge Driver
            //Edge edge = new Edge();
            //edge.EdgeBrowser();
            //Using Firefox driver
            FireFox fireFox = new FireFox();
            fireFox.FireFoxBrowser();
            Console.ReadLine();
            
        }
    }
}
