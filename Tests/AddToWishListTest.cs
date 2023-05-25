using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
	public class AddToWishListTest : BaseTest
	{
		[SetUp]
		public void SetUp()
		{
			// Log in
			Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

			// Return to home page
			Pages.HomePage.ClickOnLogoLink();
		}

		[Test]
		public void AddToWishList()
		{

			// Add item to wishlist
			Pages.AddToWishListPage.AddItemToWishList();

			// Goes to account page
			Pages.PurchaseItemPage.ClickOnAccountLink();

			// Goes to my wishlist page
			Pages.AccountPage.ClickOnMyWishList();

			//Assert
			
			Assert.AreEqual(TestData.TestData.AddToWishList.productName, Pages.AddToWishListPage.GetLastAddedFromWishList());
		}
	}
}
