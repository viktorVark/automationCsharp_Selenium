using AutomationFramework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
