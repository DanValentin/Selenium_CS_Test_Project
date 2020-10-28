using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CS_Test_Project
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");
        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                 Driver.Quit();
            }
        }
    }
}