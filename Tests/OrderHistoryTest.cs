using NUnit.Framework;
using System.Threading;

namespace AutomationFramework.Tests
{
	public class OrderHistoryTest : BaseTest
	{
		[SetUp]
		public void SetUp()
		{
			// Log in
			Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

			// Return to home page
			Pages.HomePage.ClickOnLogoLink();

			// Add item to cart
			Pages.AddItemToCartPage.AddItemToCart();

			// Click on checkout link
			Pages.AddItemToCartPage.ClickOnCheckoutLink();

			Thread.Sleep(2500);

			// Click on confirm order button
			Pages.PurchaseItemPage.ClickOnConfirmOrderButton();
		}

		[Test]
		public void OrderHistory()
		{
			//cita order id
			Thread.Sleep(2000);
			string orderId = Pages.PurchaseItemPage.ReadOrderId();

			//ide na account page
			Pages.PurchaseItemPage.ClickOnAccountLink();
			
			//ide na order history page
			Pages.AccountPage.ClickOnOrderHistory();

			//Assert
			Assert.IsTrue(Pages.OrderHistoryPage.CompareOrderIDs(orderId));
		}
	}
}
