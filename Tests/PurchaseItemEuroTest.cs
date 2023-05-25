using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class PurchaseItemEuroTest : BaseTest
    {
        [SetUp]
        public void SetUpDollar()
        {
            // Log in
            Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

            // Return to home page
            Pages.HomePage.ClickOnLogoLink();

            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();
        }

        [Test]
        public void PurchaseItemDollar()
        {
            // Click on checkout link
            Pages.AddItemToCartPage.ClickOnCheckoutLink();
            
            // Click on drop down list and select euro as payment
            Pages.PurchaseItemPage.ClickOnDropDownPaymentEuro();

            // Click on confirm order button
            Pages.PurchaseItemPage.ClickOnConfirmOrderButton();

            // Test assert
            Assert.IsTrue(Pages.PurchaseItemPage.isSuccessMessageVisible());
        }
    }
}
