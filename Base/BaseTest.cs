using System;
using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using NUnit.Framework;

namespace neocoypu.Base
{
    public class BaseTest
    {
        public BrowserSession browser;

        [SetUp]
        public void Setup()
        {
            var configs = new SessionConfiguration 
            {
                AppHost = "www.saucedemo.com/",
                SSL = true,
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                Timeout = TimeSpan.FromSeconds(10),
            };

            browser = new BrowserSession(configs);  
            browser.MaximiseWindow();         
        }

        [TearDown]
        public void Finaliza()
        {
            browser.Dispose();
        }
    }
}