using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using SeleniumTestProject.PageObjects;
using OpenQA.Selenium;

namespace SeleniumTestProject
{
    [TestFixture]
    {[TestFixture]
    class Tests : Hooks
    {
        [Test]
        public void MyFirstTest()
        {
            HomePage myPage = new HomePage(Driver);
            myPage.AutentificationButton.Click();
            Thread.Sleep(1000);
        }
        [Test]
        public void MySecondTest()
        {
            Thread.Sleep(1000);
        }
    }
}
}