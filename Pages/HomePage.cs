using AutomationFramework.Utils;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class HomePage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public HomePage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By loginRegisterButton = By.XPath("//a[contains(., 'Login or register')]");
        By logOutButton = By.XPath("//a[@data-toggle='tooltip' and @href='https://automationteststore.com/index.php?rt=account/logout']");
        By welcomeUserButton = By.XPath("//div[@class='menu_text']");
        By contactUsLink = By.XPath("//a[contains(., 'Contact Us')]");
        By logoLink = By.XPath("//a[@class='logo']");
        By searchKeywords = By.Id("filter_keyword");
        By searchDiv = By.XPath("//div[@class='button-in-search']");

        /// <summary>
        /// Method used to click on "Login or register" button
        /// </summary>
        public void ClickOnLoginRegisterButton()
        {
            WaitElementVisibility(loginRegisterButton);
            CommonMethods.ClickOnElement(driver, loginRegisterButton);
        }

        /// <summary>
        /// Method used to click on "Logoff" button
        /// </summary>
        public void LogOffUser()
        {
            ClickElement(welcomeUserButton);
            ClickElement(logOutButton);
        }

        /// <summary>
        /// Method used to get "Welcome back user" message from top of the page in order to verify
        /// user login
        /// </summary>
        /// <returns></returns>
        public string GetWelcomeUserText()
        {
            return CommonMethods.ReadTextFromElement(driver, welcomeUserButton);
        }

        /// <summary>
        /// Method used to get "Login or register" message from top of the page in order to verify
        /// user logout
        /// </summary>
        /// <returns></returns>
        public string GetLoginOrRegisterText()
        {
            return CommonMethods.ReadTextFromElement(driver, loginRegisterButton);
        }

        /// <summary>
        /// Method used to enter searched word into element
        /// </summary>
        /// <param name="search"></param>
        private void EnterSearchWord(string search)
        {
            WriteText(searchKeywords, search);
        }

        /// <summary>
        /// Method that clicks on search word div
        /// </summary>
        private void ClickOnDiv()
        {
            ClickElement(searchDiv);
        }

        /// <summary>
        /// Method that checks whether the searched item is displayed on the screen
        /// </summary>
        /// <returns></returns>
        public bool IsItemShown()
        {
            bool isDisplayed = false;

            IWebElement tableDiv = driver.FindElement(By.XPath("//p[contains(., 'YOUR HAIR')]"));

            if (tableDiv.Displayed)
            {
                isDisplayed = true;
            }

            return isDisplayed;
        }

        /// <summary>
        /// Mehod used to click on "Contact Us" link
        /// </summary>
        public void ClickOnCOntactUsLink()
        {
            ClickElement(contactUsLink);
        }

        /// <summary>
        /// Method that clicks on home page logo link
        /// </summary>
        public void ClickOnLogoLink()
        {
            ClickElement(logoLink);
        }

        /// <summary>
        /// Method that completes the word search
        /// </summary>
        /// <param name="search">searched word</param>
        public void CompleteSearch(string search)
        {
            EnterSearchWord(search);
            ClickOnDiv();
        }
    }
}
