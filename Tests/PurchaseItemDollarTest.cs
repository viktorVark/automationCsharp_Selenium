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
    public class PurchaseItemDollarTest : BaseTest
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

            // Click on confirm order button
            Pages.PurchaseItemPage.ClickOnConfirmOrderButton();

            // Test assert
            Assert.IsTrue(Pages.PurchaseItemPage.isSuccessMessageVisible());
        }    
    }
}
