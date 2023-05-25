using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class ForgotPasswordPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ForgotPasswordPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public ForgotPasswordPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By loginNameField = By.Id("forgottenFrm_loginname");
        By emailField = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button[@title='Continue']");
        By forgotPasswordSuccessMessage = By.XPath("//div[@class='alert alert-success']");

        /// <summary>
        /// Method used to enter login name into a "Login name" text field
        /// </summary>
        /// <param name="loginName">Login name</param>
        private void EnterLoginName(string loginName)
        {
            WriteText(loginNameField, loginName);
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
        public string GetForgotPasswordSuccessMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, forgotPasswordSuccessMessage);
        }

        /// <summary>
        /// Method used to recover forgotten password
        /// </summary>
        /// <param name="loginName">Login name</param>
        /// <param name="email">Email</param>
        public void ForgotPassword(string loginName, string email)
        {
            EnterLoginName(loginName);
            EnterEmail(email);
            ClickOnContinueButton();
        }
    }
}
