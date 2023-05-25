using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class LogInPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LogInPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public LogInPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By loginNameField = By.Id("loginFrm_loginname");
        By passwordField = By.Id("loginFrm_password");
        By loginButton = By.XPath("//button[contains(., 'Login')]");
        By loginRegisterButton = By.XPath("//a[contains(., 'Login or register')]");
        By forgotPasswordLink = By.XPath("//a[contains(., 'Forgot your password?')]");
        By fortogLoginLink = By.XPath("//a[contains(., 'Forgot your login?')]");
        By guestCheckoutRadio = By.Id("accountFrm_accountguest");
        By continueButton = By.XPath("//button[@title='Continue']");


        /// <summary>
        /// Method used to click on "Login or register" button
        /// </summary>
        private void ClickOnLoginRegisterButton()
        {
            CommonMethods.ClickOnElement(driver, loginRegisterButton);
        }

        /// <summary>
        /// Method used to enter provided text into "Login Name" text field
        /// </summary>
        /// <param name="loginName">Login name</param>
        public void EnterLoginName(string loginName) 
        { 
            WriteText(loginNameField, loginName);
        }

        /// <summary>
        /// Method used to enter provided text into "Password" text field
        /// </summary>
        /// <param name="password">Password</param>
        public void EnterPassword(string password)
        {
            WriteText(passwordField, password);
        }

        /// <summary>
        /// Method used to click on "Login or register" button
        /// </summary>
        private void ClickOnLoginButton()
        {
            ClickElement(loginButton);
        }

        /// <summary>
        /// Method used to click on "Forgot your password?" link
        /// </summary>
        public void ClickOnForgotPasswordLink()
        {
            ClickElement(forgotPasswordLink);
        }

        /// <summary>
        /// Method used to click on "Forgot your login?" link
        /// </summary>
        public void ClickOnForgotLoginLink()
        {
            ClickElement(fortogLoginLink);
        }
        /// <summary>
        /// Method used to click on "Guest Checkout" radio
        /// </summary>
        public void ClickOnGuestCheckoutRadio()
        {
            ClickElement(guestCheckoutRadio);
        }

        public void ClickOnContinueButton()
        {
            ClickElement(continueButton);
        }

        /// <summary>
        /// Method used to log in user
        /// </summary>
        /// <param name="loginName">Login name</param>
        /// <param name="password">Password</param>
        public void LoginUser(string loginName, string password)
        {
            ClickOnLoginRegisterButton();
            EnterLoginName(loginName);
            EnterPassword(password);
            ClickOnLoginButton();
        }
    }
}