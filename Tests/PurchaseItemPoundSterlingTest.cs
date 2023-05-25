using AutomationFramework.Utils;
using NUnit.Framework;

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

            // Test assert
            Assert.IsTrue(Pages.PurchaseItemPage.isSuccessMessageVisible());
        }
    }
}
