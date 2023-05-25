using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        /// <summary>
        /// Method used to click on "Confirm Order" button
        /// </summary>
        public void ClickOnConfirmOrderButton()
        {
            ClickElement(confirmOrderButton);
        }

        /// <summary>
        /// Method that checks whether message is visible
        /// </summary>
        /// <returns></returns>
        public bool isSuccessMessageVisible()
        {
            bool isDisplayed = false;

            IWebElement tableDiv = driver.FindElement(By.XPath("//p[contains(., 'You can view your order details by')]"));

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
            ClickElement(dropDownPayment);
            ClickElement(euroLink);
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Method that clicks on dropdown list and selects pourt sterling as payment
        /// </summary>
        public void ClickOnDropDownPaymentPountSterling()
        {
            ClickElement(dropDownPayment);
            ClickElement(poundSterling);
        }

    }
}
