using AutomationFramework.Pages;
using SeleniumExtras.PageObjects;
using System;

namespace AutomationFramework.Utils
{
    /// <summary>
    /// Class used to initialize pages
    /// </summary>
    public class AllPages
    {
        public AllPages(Browsers browser)
        {
            _browser = browser;
        }
        Browsers _browser { get; }
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.GetDriver);
            PageFactory.InitElements(_browser.GetDriver, page);
            return page;
        }

        // Pages
        public HomePage HomePage => GetPages<HomePage>();
        public RegisterUserPage RegisterUserPage => GetPages<RegisterUserPage>();
        public LogInPage LogInPage => GetPages<LogInPage>();
        public ForgotPasswordPage ForgotPasswordPage => GetPages<ForgotPasswordPage>();
        public ForgotLoginPage ForgotLoginPage => GetPages<ForgotLoginPage>();
        public ContactUsPage ContactUsPage => GetPages<ContactUsPage>();
        public AddItemToCartPage AddItemToCartPage => GetPages<AddItemToCartPage>();
        public PurchaseItemPage PurchaseItemPage => GetPages<PurchaseItemPage>();
        public GuestCheckoutPage GuestCheckoutPage => GetPages<GuestCheckoutPage>();
        public AccountPage AccountPage => GetPages<AccountPage>();
        public OrderHistoryPage OrderHistoryPage => GetPages<OrderHistoryPage>();
        public AddToWishListPage AddToWishListPage => GetPages<AddToWishListPage>();
        public AddNewAddressPage AddNewAddressPage => GetPages<AddNewAddressPage>();
    }
}