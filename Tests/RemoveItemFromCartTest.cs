using AutomationFramework.Utils;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class RemoveItemFromCartTest : BaseTest
    {
        string userName = CommonMethods.GenerateRandomUsername("TestUserName");
        string email = CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName);

        [SetUp]
        public void SetUp()
        {
            // Log in
            Pages.LogInPage.LoginUser(TestData.TestData.LogOffTestData.userName, TestData.TestData.LogOffTestData.password);

            // Return to home page
            Pages.HomePage.ClickOnLogoLink();

            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();
        }

        [Test]
        public void RemoveItemFromCart()
        {
            // Remove item from cart
            Pages.AddItemToCartPage.RemoveItemFromCart();

            // Test assert
            Assert.IsTrue(Pages.AddItemToCartPage.IsShoppingCartEmptyMessage());          
        }
    }
}
