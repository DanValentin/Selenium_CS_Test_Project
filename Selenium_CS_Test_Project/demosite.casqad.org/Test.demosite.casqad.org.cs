using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using Selenium_CS_Test_Project.PageObjects;
using Selenium_CS_Test_Project.demosite.casqad.org.PageObjects.Actions;
using Selenium_CS_Test_Project.demosite.casqad.org.PageObjects.Pages;

namespace Selenium_CS_Test_Project
{
    [TestFixture]
    class TestDemoSite : Hooks
    {
        [Test, Category("Login")]
        public void LoginIntoApplication()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("test3@gmail.com", "123456");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));
        }
        [Test, Category("Adding in basket")]
        public void AddingItemsInBasketAsUser()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            LaptopPage laptopPage = new LaptopPage(Driver);

            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("test3@gmail.com", "123456");
            homePage.NavigateToLaptopsPage();
            Assert.IsTrue(laptopPage.VerifyElementIsDisplayed(laptopPage.VerifyIfLaptopIsPresentOnThePage));
            laptopPage.ClickOnProductDetails();
            laptopPage.AddLaptopIntoBasket();

            //Assert
            Assert.IsTrue(laptopPage.VerifyElementIsDisplayed(laptopPage.VerifyThatLaptopIsPressentOnBasket));
        }

        [Test, Category("Signup")]
        public void SignUpIntoApplication()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToRegisterPage();

            //Act
            RegisterPage registerPage = new RegisterPage(Driver);
            registerPage.RegisterUser("DanPopa", "test4@gmail.com", "0123654789", "Bucuresti sector4", "123456");
            registerPage.ClickOnSubmitButton();
            loginPage.AuthenticateUser("test4@gmail.com", "123456");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));
        }
        
    }
}