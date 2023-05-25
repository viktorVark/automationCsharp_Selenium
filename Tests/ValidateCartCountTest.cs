using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class ValidateCartCountTest : BaseTest
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
        public void ValidateCartCount()
        {
            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();

            // Increment counter
            ++TestData.TestData.CartCounter.cartCounter;

            // Check values
            Assert.IsTrue(Pages.AddItemToCartPage.GetQuantityInt() == TestData.TestData.CartCounter.cartCounter);

            // Click on home page logo
            Pages.HomePage.ClickOnLogoLink();

            // Add new to cart
            Pages.AddItemToCartPage.AddItemToCart();

            // Increment counter
            ++TestData.TestData.CartCounter.cartCounter;

            // Check values
            Assert.IsTrue(Pages.AddItemToCartPage.GetQuantityInt() == TestData.TestData.CartCounter.cartCounter);

            // Set quantity to one
            Pages.AddItemToCartPage.EnterNewQuantity();

            // Update cart
            Pages.AddItemToCartPage.ClickOnCartUpdate();

            // Decrement counter
            --TestData.TestData.CartCounter.cartCounter;

            // Test assert
            Assert.IsTrue(Pages.AddItemToCartPage.GetQuantityInt() == TestData.TestData.CartCounter.cartCounter);
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
