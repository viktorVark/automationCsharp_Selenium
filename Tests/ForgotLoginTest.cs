using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ForgotLoginTest : BaseTest
    {
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
                CommonMethods.GenerateRandomUsername("TestUserName"),
                TestData.TestData.RegisterUserTestData.password
                , true);

            // Click on "Logoff" button
            Pages.HomePage.LogOffUser();
        }

        [Test]
        public void ForgotLogin()
        {
            // Click on "Login or register" button and "Forgot your login" link
            Pages.HomePage.ClickOnLoginRegisterButton();
            Pages.LogInPage.ClickOnForgotLoginLink();

            // Filling out the "Forgot login" form
            Pages.ForgotLoginPage.ForgotLogin(TestData.TestData.RegisterUserTestData.lastName, email);

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.forgotLoginSuccessMessage, Pages.ForgotPasswordPage.GetForgotPasswordSuccessMessage());
        }
    }
}
