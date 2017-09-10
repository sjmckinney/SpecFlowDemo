using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coypu;
using Coypu.Drivers;
using System.Threading;

namespace SpecFlowDemo
{
    [TestClass]
    public class CoypuUnitTest
    {
        private BrowserSession browser;
        private SessionConfiguration sessionConfiguration = new SessionConfiguration
        {
            AppHost = "www.34protons.co.uk",
            SSL = true
        };

        public void BeforeTest()
        {
            sessionConfiguration.Browser = Browser.Chrome;
            browser = new BrowserSession(sessionConfiguration);
            Console.WriteLine($"browser configuration: {browser}");
            var selenium = ((OpenQA.Selenium.Remote.RemoteWebDriver)browser.Native);
            Console.WriteLine($"Underlying IWebDriver object configuration: {selenium}");
            //Breakpoint
            //Inspect extended values of objects in debug immediate window
            //Thread.Sleep(100);
        }

        public void AfterTest()
        {
            browser.Dispose();
        }

        [TestMethod]
        public void CoypuTest1()
        {
            BeforeTest();
            browser.Visit("/");
            Console.WriteLine($"Window title is {browser.Title}");
            Console.WriteLine($"SessionConfiguration.SSL is {sessionConfiguration.SSL}");
            Console.WriteLine($"Window url is {browser.Location}");
            AfterTest();
        }
    }
}
