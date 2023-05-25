using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
	public class AddToWishListPage : BasePage
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public AddToWishListPage()
		{
			driver = null;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="webDriver">webDriver</param>
		public AddToWishListPage(IWebDriver webDriver)
		{
			driver = webDriver;
		}

		//Locators
		By productLink = By.XPath("//div[@class='fixed']/a[@title='Brunette expressions Conditioner']");
		By addToWishListLink = By.XPath("//*[@id='product']/fieldset/div[@class='wishlist']/a[contains(.,'Add to wish list')]");
		By removeFromWishListLink = By.XPath("//*[@id='product']/fieldset/div[@class='wishlist']/a[contains(.,'Remove from wish list')]");
		By lastAddedRowText = By.XPath("//div[@class='contentpanel']/div/table/tbody/tr[last()]/td[2]");

		/// <summary>
		/// Method used to click on product link
		/// </summary>
		private void ClickOnProductLink()
		{
			ClickElement(productLink);
		}

		/// <summary>
		/// Method that clicks on add to wishlist link
		/// </summary>
		private void ClickOnAddToWishList()
		{
			if(driver.FindElement(addToWishListLink).Displayed)
			{
				ClickElement(addToWishListLink);
			}
			else
			{
				ClickElement(removeFromWishListLink);
				
				ClickElement(addToWishListLink);
			}
		}

		/// <summary>
		/// Cita ime proizvoda iz poslednjeg reda wish lista
		/// </summary>
		/// <returns></returns>
		public string GetLastAddedFromWishList()
		{
			WaitElementVisibility(lastAddedRowText);
			return CommonMethods.ReadTextFromElement(driver, lastAddedRowText);
		}

		/// <summary>
		/// Metoda koja dodaje proizvod u wishlist
		/// </summary>
		public void AddItemToWishList()
		{
			ClickOnProductLink();
			ClickOnAddToWishList();
		}
	}
}
