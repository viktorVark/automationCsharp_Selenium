using AutomationFramework.Utils;
using OpenQA.Selenium;
using System;

namespace AutomationFramework.Pages
{
    public class AddItemToCartPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AddItemToCartPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public AddItemToCartPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By productLink = By.XPath("//div[@class='fixed']/a[@title='Brunette expressions Conditioner']");
        By cartLink = By.XPath("//*[@id='main_menu_top']/li[3]/a/span");
        By addToCartLink = By.XPath("//*[@id='product']/fieldset/div[4]/ul/li/a");
        By firstIteminCartName = By.XPath("//td[@class='align_left']/a");
        By removeItemFromCartLink = By.XPath("//td[@class='align_center']/a[@href='https://automationteststore.com/index.php?rt=checkout/cart&remove=72']");
        By checkoutLink = By.Id("cart_checkout1");
        By unitPrice = By.XPath("//*[@id='cart']/div/div[1]/table/tbody/tr[2]/td[4]");
        By totalPrice = By.XPath("//*[@id='cart']/div/div[1]/table/tbody/tr[2]/td[6]");
        By quantity = By.XPath("//*[@id='cart_quantity72']");
        By cartUpdate = By.Id("cart_update");
        By tableP = By.XPath("//div[@class='contentpanel' and contains(., 'Your shopping cart is empty!')]");

        /// <summary>
        /// Method used to click on product link
        /// </summary>
        private void ClickOnProductLink()
        {
            
            ClickElement(productLink);
        }

        /// <summary>
        /// Method that clicks on cart link
        /// </summary>
        public void ClickOnCart()
        {
            ClickElement(cartLink);
        }

        /// <summary>
        /// Method used to click on "Add to cart" link
        /// </summary>
        private void ClickOnAddToCart()
        {
            ClickElement(addToCartLink);
        }

        /// <summary>
        /// Method used to get first card table item name
        /// </summary>
        /// <returns></returns>
        public string GetFirstCartTableItemName()
        {
            return CommonMethods.ReadTextFromElement(driver, firstIteminCartName);
        }

        /// <summary>
        /// Method that clicks on "Remove item" link
        /// </summary>
        private void ClickOnRemoveItemLink()
        {
            WaitElementToBeClickable(removeItemFromCartLink);
            ClickElement(removeItemFromCartLink);
        }

        /// <summary>
        /// Method that checks whether the shopping cart is empty
        /// </summary>
        /// <returns></returns>
        public bool IsShoppingCartEmptyMessage()
        {
            WaitElementVisibility(tableP);

            bool isDisplayed = false;

            IWebElement tableDiv = driver.FindElement(tableP);

            if(tableDiv.Displayed)
            {
                isDisplayed = true;
            }

            return isDisplayed;
        }

        /// <summary>
        /// Method that gets price text
        /// </summary>
        /// <returns></returns>
        private string GetUnitPriceText()
        {
            WaitElementVisibility(unitPrice);
            return CommonMethods.ReadTextFromElement(driver, unitPrice);
        }

        /// <summary>
        /// Method that gets quantity text
        /// </summary>
        /// <returns></returns>
        private string GetQuantityText()
        {
            WaitElementVisibility(By.Id("cart_quantity72"));
            IWebElement el = driver.FindElement(By.Id("cart_quantity72"));

            string quant = el.GetAttribute("value");

            return quant;
        }

        /// <summary>
        /// Method that parses quantity text to int
        /// </summary>
        /// <returns></returns>
        public int GetQuantityInt()
        {
            int quant = int.Parse(GetQuantityText());

            return quant;
        }

        /// <summary>
        /// Method that changes quantity to one
        /// </summary>
        public void EnterNewQuantity()
        {
            WaitElementVisibility(By.Id("cart_quantity72"));
            IWebElement clearInput = driver.FindElement(By.Id("cart_quantity72"));

            clearInput.Clear();

            CommonMethods.WriteTextToElement(driver, quantity, "1");
        }

        /// <summary>
        /// Method that clicks on "Update cart" link
        /// </summary>
        public void ClickOnCartUpdate()
        {
            ClickElement(cartUpdate);
        }

        /// <summary>
        /// Method that gets the total price amount
        /// </summary>
        /// <returns></returns>
        private string GetTotalText()
        {
            WaitElementVisibility(totalPrice);
            return CommonMethods.ReadTextFromElement(driver, totalPrice);
        }

        /// <summary>
        /// Method that clicks on "Checkout" link
        /// </summary>
        public void ClickOnCheckoutLink()
        {
            ClickElement(checkoutLink);
        }

        /// <summary>
        /// Method that adds item to cart
        /// </summary>
        public void AddItemToCart()
        {
            ClickOnProductLink();
            ClickOnAddToCart();
        }

        /// <summary>
        /// Method that removes item from cart
        /// </summary>
        public void RemoveItemFromCart()
        {
            
            ClickOnRemoveItemLink();
        }

        /// <summary>
        /// Method that checks whether the price is doubled
        /// </summary>
        /// <returns></returns>
        public bool IsPriceDoubled()
        {
            bool isDoubled = false;

            string unitPriceString = GetUnitPriceText().Substring(1);

            string totalString = GetTotalText().Substring(1);

            double unitPrice = Double.Parse(unitPriceString);

            double total = Double.Parse(totalString);

            if(unitPrice * 2 == total)
            {
                isDoubled = true;
            }

            return isDoubled;
        }

        /// <summary>
        /// Method that checks whether the price is same
        /// </summary>
        /// <returns></returns>
        public bool IsPriceTheSame()
        {
            bool isTheSame = false;

            string unitPriceString = GetUnitPriceText().Substring(1);

            string totalString = GetTotalText().Substring(1);

            double unitPrice = Double.Parse(unitPriceString);

            double total = Double.Parse(totalString);

            if (unitPrice == total)
            {
                isTheSame = true;
            }

            return isTheSame;
        }
    }
}
