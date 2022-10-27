using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SoftwareValidationAndVerificationProject.Configuration
{
    public static class Configure //: IConfigure
    {
        //Browser Driver
        private static readonly IWebDriver _webDriver = new ChromeDriver();
        
        //public Configure()
        //{
        //    _webDriver = new ChromeDriver();
        //}
        [SetUp]
        public static IWebDriver Setup()
        {
            //Navigate to Url
            _webDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/what-is-new.html");
            return _webDriver;
        }

        [TearDown]
        public static void Quit()
        {
            _webDriver.Quit();
        }
    }
}
