using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coypu;
using Coypu.Drivers;

namespace SpecFlowDemo
{
    [TestClass]
    public class _34ProtonsLogin
    {
        private BrowserSession browser;
        private SessionConfiguration sessionConfiguration = new SessionConfiguration
        {
            AppHost = "www.34protons.co.uk",
            SSL = false
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
        public void _34ProtonsLoginTest1()
        {
            BeforeTest();
            browser.Visit("/demo_2_0/login.php");
            browser.FillIn("username").With("user");
            browser.FillIn("password").With("123");
            browser.ClickButton("Submit");
            browser.HasNoContent("Login page", new Options { Timeout = TimeSpan.FromSeconds(6) });
            Assert.AreEqual(browser.Title, "Demo page for selenium code");
            AfterTest();
        }
    }
}
