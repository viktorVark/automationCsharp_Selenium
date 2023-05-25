using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LogInTest : BaseTest
    {
        string userName = CommonMethods.GenerateRandomUsername("TestUserName");

        [SetUp]
        public void SetUp()
        {
            // Click on "Login or register" button
            Pages.HomePage.ClickOnLoginRegisterButton();

            // Registering a new user
            Pages.RegisterUserPage.RegisterUser(
                TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.lastName,
                CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName),
                TestData.TestData.RegisterUserTestData.address1,
                TestData.TestData.RegisterUserTestData.city,
                TestData.TestData.RegisterUserTestData.zipCode,
                userName,
                TestData.TestData.RegisterUserTestData.password
                , true);

            // Click on "Logoff" button
            Pages.HomePage.LogOffUser();
        }

        [Test]
        public void LogInUser()
        {
            // User login
            Pages.LogInPage.LoginUser(userName, TestData.TestData.RegisterUserTestData.password);

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.welcomeBackUserMessage + TestData.TestData.RegisterUserTestData.firstName, Pages.HomePage.GetWelcomeUserText());
        }
    }
}
