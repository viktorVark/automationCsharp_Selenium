using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationFramework.Pages
{
    public class BasePage
    {
        // Driver
        public IWebDriver? driver;
        public WebDriverWait wait;


        /// <summary>
        /// Method used to check visibility of an element
        /// </summary>
        public void WaitElementVisibility(By elementBy)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementBy));
        }

        /// <summary>
        /// Method used to click on an element
        /// </summary>
        public void ClickElement(By element)
        {
            WaitElementVisibility(element);
            CommonMethods.ClickOnElement(driver, element);
        }

        /// <summary>
        /// Method used to write text to an element
        /// </summary>
        public void WriteText(By element, string text)
        {
            WaitElementVisibility(element);
            CommonMethods.WriteTextToElement(driver, element, text);
        }         
    }    
}
