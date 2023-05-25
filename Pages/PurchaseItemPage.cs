using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class PurchaseItemPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PurchaseItemPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public PurchaseItemPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By confirmOrderButton = By.Id("checkout_btn");
        By dropDownPayment = By.XPath("//ul[@class='nav language pull-left']/li[@class='dropdown hover']");
        By euroLink = By.XPath("//a[@href='https://automationteststore.com/index.php?rt=checkout/confirm&currency=EUR']");
        By poundSterling = By.XPath("//a[@href='https://automationteststore.com/index.php?rt=account/login&currency=GBP']");
        By orderIdMessage = By.XPath("//div[@class='contentpanel']//p[2]");
        By accountLink = By.XPath("//ul[@class='info_links_footer']//li[contains(.,'Account')]");
        By tableP = By.XPath("//p[contains(., 'You can view your order details by')]");

        /// <summary>
        /// Method used to click on "Confirm Order" button
        /// </summary>
        public void ClickOnConfirmOrderButton()
        {
            WaitElementToBeClickable(confirmOrderButton);
            ClickElement(confirmOrderButton);
        }

        /// <summary>
        /// Method that checks whether message is visible
        /// </summary>
        /// <returns></returns>
        public bool isSuccessMessageVisible()
        {
            WaitElementVisibility(tableP);

            bool isDisplayed = false;

            IWebElement tableDiv = driver.FindElement(tableP);
            
            if (tableDiv.Displayed)
            {
                isDisplayed = true;
            }

            return isDisplayed;
        }

        /// <summary>
        /// Metoda koja cite ordeid
        /// </summary>
        /// <returns></returns>
        public string ReadOrderId()
        {
			
			string[] message = driver.FindElement(orderIdMessage).Text.Split(' ');
            return message[2];
        }

        /// <summary>
        /// Metoda koja klikne na account link
        /// </summary>
        public void ClickOnAccountLink()
        {
            ClickElement(accountLink);
        }


        /// <summary>
        /// Method that clicks on dropdown list and selects euro as payment
        /// </summary>
        public void ClickOnDropDownPaymentEuro()
        {
            WaitElementToBeClickable(dropDownPayment);
            ClickElement(dropDownPayment);
            WaitElementToBeClickable(euroLink);
            ClickElement(euroLink);
            
        }

        /// <summary>
        /// Method that clicks on dropdown list and selects pourt sterling as payment
        /// </summary>
        public void ClickOnDropDownPaymentPountSterling()
        {
            WaitElementToBeClickable(dropDownPayment);
            ClickElement(dropDownPayment);
            WaitElementToBeClickable(poundSterling);
            ClickElement(poundSterling);
        }

    }
}
