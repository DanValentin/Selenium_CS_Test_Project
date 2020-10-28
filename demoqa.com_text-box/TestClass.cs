// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using demoqa.com_text_box.PageObjects;
using NUnit.Framework;
using Selenium_CS_Test_Project;

namespace demoqa.com_text_box
{
    [TestFixture]
    public class TestClass : Hooks
    { 
        [Test, Category("Login")]
        public void SubmitForm()
        {
            // Arrange
            Homepage homepage = new Homepage(Driver);
            Text_BoxPage text_BoxPage = new Text_BoxPage(Driver);
            homepage.ClickOnTextBoxLinkButton();

            //Act
            text_BoxPage.EnterFirstName("Dan");
            text_BoxPage.EnterAddress("test@test.com");
            text_BoxPage.EnterAddress("address 1");
            text_BoxPage.EnterPermanentAddress("address 2");
            text_BoxPage.SubmitForm();

            //Assert
            Assert.IsTrue(text_BoxPage.VerifyElementIsDisplayed(text_BoxPage.VerifyIfInputFieldIsSubmmited));
        }
    }
}
