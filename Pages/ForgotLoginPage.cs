using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class ForgotLoginPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ForgotLoginPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public ForgotLoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By lastNameField = By.Id("forgottenFrm_lastname");
        By emailField = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button[@title='Continue']");
        By forgotLoginSuccessMessage = By.XPath("//div[@class='alert alert-success']");


        /// <summary>
        /// Method used to enter last name into a "Last name" text field
        /// </summary>
        /// <param name="lastName">Login name</param>
        private void EnterlastName(string lastName)
        {
            WriteText(lastNameField, lastName);
        }

        /// <summary>
        /// Method used to enter email into a "Email" text field
        /// </summary>
        /// <param name="email">Email</param>
        private void EnterEmail(string email)
        {
            WriteText(emailField, email);
        }

        /// <summary>
        /// Method used to click on "Continue" button
        /// </summary>
        private void ClickOnContinueButton()
        {
            ClickElement(continueButton);
        }

        /// <summary>
        /// Method used to get success message
        /// </summary>
        /// <returns>Success message</returns>
        public string GetForgotLoginSuccessMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, forgotLoginSuccessMessage);
        }

        /// <summary>
        /// Method used to recover forgotten login info
        /// </summary>
        /// <param name="lastName">Last name</param>
        /// <param name="email">Email</param>
        public void ForgotLogin(string lastName, string email)
        {
            EnterlastName(lastName);
            EnterEmail(email);
            ClickOnContinueButton();
        }
    }
}