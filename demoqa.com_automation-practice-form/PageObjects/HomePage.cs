﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoqa.com_automation_practice_form.PageObjects
{
    class HomePage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement FormPage => _driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));

        public void ClickOnFormButton()
        {
            FormPage.Click();
        }
    }
}
