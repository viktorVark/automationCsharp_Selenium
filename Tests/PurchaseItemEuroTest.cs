using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

            Thread.Sleep(2500);

            // Click on confirm order button
            Pages.PurchaseItemPage.ClickOnConfirmOrderButton();

            Thread.Sleep(2000);

            // Test assert
            Assert.IsTrue(Pages.PurchaseItemPage.isSuccessMessageVisible());
        }
    }
}
