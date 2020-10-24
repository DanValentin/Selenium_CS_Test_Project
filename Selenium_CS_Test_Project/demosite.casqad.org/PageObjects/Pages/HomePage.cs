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
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement AuthenticationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        private IWebElement SignUpButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButon => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement ButonDeconectare => _driver.FindElement(By.XPath("//a[contains(text(),'Deconectare')]"));


    public void GoToRegisterPage()
        {
            SignUpButton.Click();
        }
        public void GoToAuthentication()
        {
            AuthenticationButton.Click();
        }

        public bool VerifyIfLoginWasOk()
        {
            return _driver.FindElement((By)ButonDeconectare).Displayed;
        }

        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

    }
}