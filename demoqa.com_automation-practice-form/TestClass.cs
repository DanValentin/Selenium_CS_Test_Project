// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using demoqa.com_automation_practice_form.PageObjects;
using NUnit.Framework;
using Selenium_CS_Test_Project;

namespace demoqa.com_automation_practice_form
{
    [TestFixture]
    public class TestClass : Hooks
    {
        [Test, Category("Login")]
        public void SubmitForm()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            PracticeFormPage practiceFormPage = new PracticeFormPage(Driver);
            homePage.ClickOnFormButton();

            //Act
            practiceFormPage.EnterFirstName("Dan");
            practiceFormPage.EnterLastName("Popa");
            practiceFormPage.EnterEmail("test@mail.com");
            practiceFormPage.ClickOnMaleRadioButton();
            practiceFormPage.EnderPhoneNumber("0123654879");
           //practiceFormPage.SelectDateOfBirth();
            practiceFormPage.EnterSubject("Math");
            practiceFormPage.SelectHobbies();
            //practiceFormPage.UploadPicture();
            practiceFormPage.EnterAddress("asfdklgnsfdkn sdgertg");
            practiceFormPage.SelectStateFromDropDown("NCR");
            practiceFormPage.SelectCityFromDropDown("Delhi");
            practiceFormPage.SubmitAction();


            //Assert
            Assert.IsTrue(practiceFormPage.VerifyElementIsDisplayed(practiceFormPage.ConfirmationThatFormWasSubmmited));
        }
    }
}
