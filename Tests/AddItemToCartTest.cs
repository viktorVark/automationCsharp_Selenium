using AutomationFramework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AutomationFramework.Tests
{
    public class AddItemToCartTest : BaseTest
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
        public void AddItemToCart()
        {
            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();

            // Assert test
            Assert.AreEqual(AppConstants.Constants.GenericMessages.addToCartFirstItemName, Pages.AddItemToCartPage.GetFirstCartTableItemName());
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
