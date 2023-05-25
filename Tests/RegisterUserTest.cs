using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class RegisterUserTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            // Click on "Login or register" button
            Pages.HomePage.ClickOnLoginRegisterButton();
        }

        [Test]
        public void RegisterUserFull()
        {
            // Filling out all of the text fields
            Pages.RegisterUserPage.RegisterUserFull(
                TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.lastName,
                CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName),
                TestData.TestData.RegisterUserTestData.telephone,
                TestData.TestData.RegisterUserTestData.fax,
                TestData.TestData.RegisterUserTestData.companyName,
                TestData.TestData.RegisterUserTestData.address1,
                TestData.TestData.RegisterUserTestData.address2,
                TestData.TestData.RegisterUserTestData.city,
                TestData.TestData.RegisterUserTestData.zipCode,
                CommonMethods.GenerateRandomUsername("TestUserName"),
                TestData.TestData.RegisterUserTestData.password, true);

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.registrationSuccessMessage, Pages.RegisterUserPage.GetRegistrationSuccessMessage());
        }

        [Test]
        public void RegisterUser()
        {
            // Filling out necessary text fields
            Pages.RegisterUserPage.RegisterUser(
                TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.lastName,
                CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName),
                TestData.TestData.RegisterUserTestData.address1,
                TestData.TestData.RegisterUserTestData.city,
                TestData.TestData.RegisterUserTestData.zipCode,
                CommonMethods.GenerateRandomUsername("TestUserName"),
                TestData.TestData.RegisterUserTestData.password, true);

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.registrationSuccessMessage, Pages.RegisterUserPage.GetRegistrationSuccessMessage());
        }
    }
}
