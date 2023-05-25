using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ForgotPasswordTest : BaseTest
    {
        string userName = CommonMethods.GenerateRandomUsername("TestUserName");
        string email = CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName);

        [SetUp]
        public void SetUp()
        {
            // Click on "Login or register" button
            Pages.HomePage.ClickOnLoginRegisterButton();

            // Registering a new user
            Pages.RegisterUserPage.RegisterUser(
                TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.lastName,
                email,
                TestData.TestData.RegisterUserTestData.address1,
                TestData.TestData.RegisterUserTestData.city,
                TestData.TestData.RegisterUserTestData.zipCode,
                userName,
                TestData.TestData.RegisterUserTestData.password,
                true
                );

            // Click on "Logoff" button
            Pages.HomePage.LogOffUser();
        }

        [Test]
        public void ForgotPassword()
        {
            // Click on "Login or register" button and "Forgot your password" link
            Pages.HomePage.ClickOnLoginRegisterButton();
            Pages.LogInPage.ClickOnForgotPasswordLink();

            // Filling out the "Forgot password" form
            Pages.ForgotPasswordPage.ForgotPassword(userName, email);

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.forgotPasswordSuccessMessage, Pages.ForgotPasswordPage.GetForgotPasswordSuccessMessage());
        }
    }
}
