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
    public class PurchaseItemPoundSterlingTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            // Add item to cart
            Pages.AddItemToCartPage.AddItemToCart();

            //Click on checkout link
            Pages.AddItemToCartPage.ClickOnCheckoutLink();
        }

        [Test]
        public void PurchaseItemPoundSterling()
        {
            // Clikc on drop down list and select pount sterling as payment
            Pages.PurchaseItemPage.ClickOnDropDownPaymentPountSterling();

            // Click on guest checkout radio
            Pages.LogInPage.ClickOnGuestCheckoutRadio();

            // Click on continue button
            Pages.LogInPage.ClickOnContinueButton();

            // Filling out necessary text fields
            Pages.GuestCheckoutPage.EnterAllFields(
                TestData.TestData.RegisterUserTestData.firstName,
                TestData.TestData.RegisterUserTestData.lastName,
                CommonMethods.GenerateRandomEmail(TestData.TestData.RegisterUserTestData.firstName),
                TestData.TestData.RegisterUserTestData.address1,
                TestData.TestData.RegisterUserTestData.zipCode,
                TestData.TestData.RegisterUserTestData.city
                );

            // Click on confirm order
            Pages.GuestCheckoutPage.ClickOnConfirmOrderButton();

            Thread.Sleep(2000);

            // Test assert
            Assert.IsTrue(Pages.PurchaseItemPage.isSuccessMessageVisible());
        }
    }
}
