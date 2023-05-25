using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class LogOutTest : BaseTest
    {
        string userName = CommonMethods.GenerateRandomUsername("TestUserName");

        [SetUp]
        public void SetUp()
        {
            // Log in
            Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);
        }

        [Test]
        public void LogOffUser()
        {
            // Click on "Logoff" button
            Pages.HomePage.LogOffUser();

            // Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.loginOrRegisterButtonText, Pages.HomePage.GetLoginOrRegisterText());
        }
    }
}
