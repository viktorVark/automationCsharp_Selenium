using NUnit.Framework;
using System.Threading;

namespace AutomationFramework.Tests
{
    public class ValidateCartPriceTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            //Log in
            Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

            // Return to home page
            Pages.HomePage.ClickOnLogoLink();
        }

        [Test]
        public void ValidateCardPriceTest()
        {
            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();

            Thread.Sleep(2000);

            // Return to home page
            Pages.HomePage.ClickOnLogoLink();

            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();

            Thread.Sleep(2000);

            // Test assert
            Assert.IsTrue(Pages.AddItemToCartPage.IsPriceDoubled());

            // Return quantity to one
            Pages.AddItemToCartPage.EnterNewQuantity();

            Thread.Sleep(2000);

            // Update cart
            Pages.AddItemToCartPage.ClickOnCartUpdate();

            Thread.Sleep(2000);

            // Test assert
            Assert.IsTrue(Pages.AddItemToCartPage.IsPriceTheSame());
        }

        [TearDown]
        public void EmptyCart()
        {
            // Click on cart link
            Pages.AddItemToCartPage.ClickOnCart();

            // Remove item from cart
            Pages.AddItemToCartPage.RemoveItemFromCart();
        }
    }
}
