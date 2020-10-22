using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CS_Test_Project.PageObjects
{
    partial class HomePage
    {
        public void GoToAuthentication()
        {
            AuthenticationButton.Click();
        }

        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

    }
}