// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Selenium_CS_Test_Project;
using teatrulsicaalexandrescu.ro.PageObjects;

namespace teatrulsicaalexandrescu.ro
{
    [TestFixture]
    public class TestClass : Hooks
    {
        [Test, Category("GoogleSearchKeyword")]
        public void SpectacolTeatru()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            ActorPage actorPage = new ActorPage(Driver);
            homePage.ClickOnTeamLinkButton();

            //Act
            actorPage.ClickOnActorImage();
            actorPage.ClickOnSpectacolButton();

            //Assert
            //Assert.IsTrue(!homePage.ImageSelectedFrame.Displayed);

        }

    }
}
