using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SoftwareValidationAndVerificationProject.Configuration;

namespace SoftwareValidationAndVerificationProject.EquivalanceClasses.LandingPage
{
    public class LandingPage
    {
        private IWebDriver _webDriver;

        public LandingPage()
        {
            _webDriver = Configure.Setup();
        }
        [Test]
        public void LandedOnlandingPage()
        {
            try
            {
                var test = _webDriver.FindElement(By.CssSelector(".welcome"));
                Assert.IsTrue(test.Displayed);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
            finally 
            {
                Configure.Quit();
            }
            
        }
    }
}
