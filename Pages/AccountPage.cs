using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class AccountPage : BasePage
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public AccountPage()
		{
			driver = null;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="webDriver">webDriver</param>
		public AccountPage(IWebDriver webDriver)
		{
			driver = webDriver;
		}
		//Locators
		By orderHistoryLink = By.XPath("//a[@title = 'Order history']");
		By wishListLink = By.XPath("//a[@data-original-title = 'My wish list']");
		By addressBookLink = By.XPath("//a[@data-original-title = 'Manage Address Book']");

		/// <summary>
		/// Metoda koja klikne na order history link
		/// </summary>
		public void ClickOnOrderHistory()
		{
			ClickElement(orderHistoryLink);
		}

		/// <summary>
		/// Metoda koja klikne na my wishlist link
		/// </summary>
		public void ClickOnMyWishList()
		{
			ClickElement(wishListLink);
		}
		
		/// <summary>
		/// Metoda koja klikne na manage address book link
		/// </summary>
		public void ClickOnManageAddressBook()
		{
			ClickElement(addressBookLink);
		}
	}
}
