﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
	public class AddNewAddressTest : BaseTest
	{
		[SetUp]
		public void SetUp()
		{
			// Log in
			Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

			// Return to home page
			Pages.HomePage.ClickOnLogoLink();

			//Goes to account page
			Pages.PurchaseItemPage.ClickOnAccountLink();

			// Goes to manage address book
			Pages.AccountPage.ClickOnManageAddressBook();
		}

		[Test]
		public void AddNewAddressToBook()
		{
			Pages.AccountPage.ClickOnManageAddressBook();
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
