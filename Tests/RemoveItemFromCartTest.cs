using AutomationFramework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

            Thread.Sleep(2000);
        }

        [Test]
        public void RemoveItemFromCart()
        {
            // Remove item from cart
            Pages.AddItemToCartPage.RemoveItemFromCart();

            Thread.Sleep(2000);

            // Test assert
            Assert.IsTrue(Pages.AddItemToCartPage.IsShoppingCartEmptyMessage());          
        }
    }
}
