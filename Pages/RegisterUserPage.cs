using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace AutomationFramework.Pages
{
    public class RegisterUserPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterUserPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public RegisterUserPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By continueToRegistrationButton = By.XPath("//button[contains(., 'Continue')]");
        By firstNameField = By.Id("AccountFrm_firstname");
        By lastNameField = By.Id("AccountFrm_lastname");
        By emailField = By.Id("AccountFrm_email");
        By telephoneField = By.Id("AccountFrm_telephone");
        By faxField = By.Id("AccountFrm_fax");
        By companyField = By.Id("AccountFrm_company");
        By addres1Field = By.Id("AccountFrm_address_1");
        By address2Field = By.Id("AccountFrm_address_2");
        By cityField = By.Id("AccountFrm_city");
        By stateDropdown = By.Id("AccountFrm_zone_id");
        By stateDropdownOptions = By.XPath("//select[@id='AccountFrm_zone_id']/option");
        By zipCodeField = By.Id("AccountFrm_postcode");
        By loginNameField = By.Id("AccountFrm_loginname");
        By passwordField = By.Id("AccountFrm_password");
        By passwordConfirmField = By.Id("AccountFrm_confirm");
        By newsLetterYesRadio = By.Id("AccountFrm_newsletter1");
        By newsLetterNoRadio = By.Id("AccountFrm_newsletter0");
        By privacyPolicyCheckbox = By.Id("AccountFrm_agree");
        By continueButton = By.XPath("//button[@title='Continue' and @type='submit']");
        By registrationSuccessTitle = By.XPath("//h1[@class='heading1']/span[position()=1]");

        /// <summary>
        /// Method used to click on "Continue" button on login/register page
        /// </summary>
        public void ClickOnContinueToRegistrationButton()
        {
            ClickElement(continueToRegistrationButton);
        }

        /// <summary>
        /// Method used to enter first name into a "First Name" field
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteText(firstNameField, firstName);
        }

        /// <summary>
        /// Method used to enter last name into a "Last Name" field
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            WriteText(lastNameField, lastName);
        }

        /// <summary>
        /// Method used to enter email into a "Email" field
        /// </summary>
        /// <param name="email">Email</param>
        private void EnterEmail(string email)
        {
            WriteText(emailField, email);
        }

        /// <summary>
        /// Method used to enter phone number into a "Telephone" field
        /// </summary>
        /// <param name="telephoneNumber">Telephone number</param>
        private void EnterTelephoneNumber(string telephoneNumber)
        {
            WriteText(telephoneField, telephoneNumber);
        }

        /// <summary>
        /// Method used to enter fax number into a "Fax" field
        /// </summary>
        /// <param name="fax">Fax</param>
        private void EnterFaxNumber(string fax)
        {
            WriteText(faxField, fax);
        }

        /// <summary>
        /// Method used to enter company name into a "Company" field
        /// </summary>
        /// <param name="companyName">Company name</param>
        private void EnterCompanyName(string companyName)
        {
            WriteText(companyField, companyName);
        }

        /// <summary>
        /// Method used to enter first address into a "Address 1" field
        /// </summary>
        /// <param name="firstAddress">First address</param>
        private void EnterFirstAddress(string firstAddress)
        {
            WriteText(addres1Field, firstAddress);
        }

        /// <summary>
        /// Method used to enter second address into a "Address 2" field
        /// </summary>
        /// <param name="firstAddress">Second address</param>
        private void EnterSecondAddress(string secondAddress)
        {
            WriteText(address2Field, secondAddress);
        }

        /// <summary>
        /// Method used to enter city into a "City" field
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            WriteText(cityField, city);
        }

        /// <summary>
        /// Method used to get all of the states from a select element,
        /// to initialize a C# select object and to select a random state from aforementioned list
        /// </summary>
        private void SelectState()
        {
            List<string> stateList = CommonMethods.GetAllOptionsFromSelect(driver, stateDropdownOptions);
            SelectElement select = new SelectElement(driver.FindElement(stateDropdown));
            select.SelectByText(CommonMethods.GetRandomItemFromList(stateList));
        }

        /// <summary>
        /// Method used to enter zip code into a "ZIP Code" field
        /// </summary>
        /// <param name="zipCode">Zip Code</param>
        private void EnterZipCode(string zipCode)
        {
            WriteText(zipCodeField, zipCode);
        }

        /// <summary>
        /// Method used to enter login name into a "Login name" field
        /// </summary>
        /// <param name="loginName">Login name</param>
        private void EnterLoginName(string loginName)
        {
            WriteText(loginNameField, loginName);
        }

        /// <summary>
        /// Method used to enter password into a "Password" field
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterPassword(string password)
        {
            WriteText(passwordField, password);
        }

        /// <summary>
        /// Method used to confirm password
        /// </summary>
        /// <param name="passwordConfirmation">Password confirmation</param>
        private void EnterPasswordConfirmation(string passwordConfirmation)
        {
            WriteText(passwordConfirmField, passwordConfirmation);
        }

        /// <summary>
        /// Method used to select "Yes" in radio button newsletter subscription section
        /// </summary>
        private void ClickOnNewsLetterRadioYes()
        {
            CommonMethods.ClickOnRadioButtonOrCheckBox(driver, newsLetterYesRadio);
        }

        /// <summary>
        /// Method used to select "No" in radio button newsletter subscription section
        /// </summary>
        private void ClickOnNewsLetterRadioNo()
        {
            CommonMethods.ClickOnRadioButtonOrCheckBox(driver, newsLetterNoRadio);
        }

        /// <summary>
        /// Method used to check the "Privacy Policy" checkbox
        /// </summary>
        private void ClickOnPrivacyPolicyCheckbox()
        {
            CommonMethods.ClickOnRadioButtonOrCheckBox(driver, privacyPolicyCheckbox);
        }

        /// <summary>
        /// Method used to click on "Continue" button
        /// </summary>
        private void ClickOnContinue()
        {
            ClickElement(continueButton);
        }

        /// <summary>
        /// Method used to get registration success message title
        /// </summary>
        /// <returns>Registration success message title</returns>
        public string GetRegistrationSuccessMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, registrationSuccessTitle);
        }

        /// <summary>
        /// Method used to register user with all of the text fields filled out
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="email">E-Mail</param>
        /// <param name="telephone">Telephone</param>
        /// <param name="fax">Fax Number</param>
        /// <param name="companyName">Company Name</param>
        /// <param name="address1">Address 1</param>
        /// <param name="address2">Address 2</param>
        /// <param name="city">City</param>
        /// <param name="zipCode">Zip Code</param>
        /// <param name="password">Password</param>
        /// <param name="newsLetter">Newsletter Subscription?</param>
        public void RegisterUserFull(
            string firstName, string lastName,
            string email, string telephone,
            string fax, string companyName,
            string address1, string address2,
            string city, string zipCode,
            string loginName,
            string password, bool newsLetter)
        {
            ClickOnContinueToRegistrationButton();
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterEmail(email);
            EnterTelephoneNumber(telephone);
            EnterFaxNumber(fax);
            EnterCompanyName(companyName);
            EnterFirstAddress(address1);
            EnterSecondAddress(address2);
            EnterCity(city);
            SelectState();
            EnterZipCode(zipCode);
            EnterLoginName(loginName);
            EnterPassword(password);
            EnterPasswordConfirmation(password);
            if(newsLetter == true)
            {
                ClickOnNewsLetterRadioYes();
            }
            else
            {
                ClickOnNewsLetterRadioNo();
            }
            ClickOnPrivacyPolicyCheckbox();
            ClickOnContinue();
        }

        /// <summary>
        /// Method used to register user with necessary text fields filled out
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="email">E-Mail</param>
        /// <param name="address">Address</param>
        /// <param name="city">City</param>
        /// <param name="zipCode">Zip Code</param>
        /// <param name="password">Password</param>
        /// <param name="newsLetter">Newsletter Subscription?</param>
        public void RegisterUser(
            string firstName, string lastName,
            string email,string address, 
            string city, string zipCode,
            string loginName,
            string password, bool newsLetter)
        {
            ClickOnContinueToRegistrationButton();
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterEmail(email);
            EnterFirstAddress(address);
            EnterCity(city);
            SelectState();
            EnterZipCode(zipCode);
            EnterLoginName(loginName);
            EnterPassword(password);
            EnterPasswordConfirmation(password);
            if (newsLetter == true)
            {
                ClickOnNewsLetterRadioYes();
            }
            else
            {
                ClickOnNewsLetterRadioNo();
            }
            ClickOnPrivacyPolicyCheckbox();
            ClickOnContinue();
        }
    }
}
