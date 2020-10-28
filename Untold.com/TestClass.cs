// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Selenium_CS_Test_Project;
using Untold.com.PageObjects;

namespace Untold.com
{
    [TestFixture]
    public class TestClass : Hooks
    {
        [Test, Category("Login")]
        public void UntoldHomePage()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.ClickOnMenuButton();

            //Act
            homePage.ClickOnHomePageButton();
            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.HomePageLogo));
        }
    }
}
