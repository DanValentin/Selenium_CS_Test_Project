using System.Collections;
using System.Collections.Generic;
using GoogleHomeWork.PageObjects.Pages;
using NUnit.Framework;
using Selenium_CS_Test_Project;

namespace GoogleHomeWork
{
    [TestFixture]
    public class TestClass : Hooks
    {
            [Test, Category("GoogleSearchKeyword")]
            public void GoogleSearchKeyword()
            {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            ImagePage imagePage = new ImagePage(Driver);
            homePage.SwitchToIframe();
            homePage.SendKeywordToTextField("paris");


            //Act
            homePage.ClickOnImagineTab();
            imagePage.ClickOnFirstImage();
            imagePage.ReturnToImagePage();

            //Assert
            Assert.IsTrue(! homePage.ImageSelectedFrame.Displayed);
        }
        }
    }

