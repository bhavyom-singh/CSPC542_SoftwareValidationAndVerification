using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareValidationAndVerificationProject.Configuration
{
    public interface IConfigure
    {
        public IWebDriver Setup();
        public void Quit();
    }
}
