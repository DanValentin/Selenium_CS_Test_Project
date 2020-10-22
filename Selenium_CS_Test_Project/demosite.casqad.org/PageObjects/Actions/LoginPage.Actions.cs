using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_CS_Test_Project.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

            // setam driverul sa stea cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }

        public void AuthenticateUser(string user, string password)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            AuthenticateButton.Click();

        }


    }
}