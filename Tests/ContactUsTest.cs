using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ContactUsTest : BaseTest
    {
        string userName = CommonMethods.GenerateRandomUsername("TestUserName");
        string email = CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName);

        [SetUp]
        public void SetUp()
        {
            //Log in
            Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

            // Click on "Logoff" button
            Pages.HomePage.LogOffUser();
        }

        [Test]
        public void ContactUs()
        {
            //Click on "Contact Us" link
            Pages.HomePage.ClickOnCOntactUsLink();

            //Filling the "Contact Us" form
            Pages.ContactUsPage.ContactUs(TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.email,
                TestData.TestData.EnquiryTestData.enquiry);

            //Test assert
            Assert.AreEqual(AppConstants.Constants.GenericMessages.contactUsSuccessMessage, Pages.ContactUsPage.GetContactUsSuccessMessage());
        }
    }
}
