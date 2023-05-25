using NUnit.Framework;

namespace AutomationFramework.Tests
{
	public class AddNewAddressTest : BaseTest
	{
		[SetUp]
		public void SetUp()
		{
			// Log in
			Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

			// Goes to manage address book
			Pages.AccountPage.ClickOnManageAddressBook();
		}

		[Test]
		public void AddNewAddressToBook()
		{
			Pages.AddNewAddressPage.CLickOnNewAddressButton();

			Pages.AddNewAddressPage.EnterAllFieldsForAddress(
				TestData.TestData.RegisterUserTestData.firstName,
				TestData.TestData.RegisterUserTestData.lastName,
				TestData.TestData.RegisterUserTestData.companyName,
				TestData.TestData.RegisterUserTestData.address1,
				TestData.TestData.RegisterUserTestData.zipCode,
				TestData.TestData.RegisterUserTestData.city
				);

			Assert.AreEqual(AppConstants.Constants.GenericMessages.addNewAddresSuccessMessage, Pages.AddNewAddressPage.ReadSuccessAlert());
		}
	}
}
