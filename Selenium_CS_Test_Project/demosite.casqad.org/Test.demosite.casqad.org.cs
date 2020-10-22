using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using Selenium_CS_Test_Project.PageObjects;

namespace Selenium_CS_Test_Project
{
    [TestFixture]
    class TestGoolge : Hooks
    {
        [Test, Category("Login")]
        public void MyFirstTest()
        {
            // Arrante
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));

            Thread.Sleep(1000);
        }

    }
}