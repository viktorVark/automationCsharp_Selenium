using OpenQA.Selenium;
using AutomationFramework.Utils;

namespace AutomationFramework.Pages
{
    public class ContactUsPage : BasePage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactUsPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="webDriver">webDriver</param>
        public ContactUsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locatiors

        By firstNameField = By.Id("ContactUsFrm_first_name");
        By emailField = By.Id("ContactUsFrm_email");
        By enquiryTextArea = By.Id("ContactUsFrm_enquiry");
        By submitButton = By.XPath("//button[@title='Submit']");
        By contactUsSuccessMessage = By.XPath("//p[contains(., 'Your enquiry has been successfully sent to the store owner!')]");

        /// <summary>
        /// Method used to enter first name int "First name" field
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteText(firstNameField, firstName);
        }
        /// <summary>
        /// Method used to enter first name int "First name" field
        /// </summary>
        /// <param name="email">Email</param>
        private void EnterEmail(string email)
        {
            WriteText(emailField, email);
        }

        /// <summary>
        /// Method used to enter first name int "First name" textarea
        /// </summary>
        /// <param name="enquiry">Enquiry</param>
        private void EnterEnquiry(string enquiry)
        {
            WriteText(enquiryTextArea, enquiry);
        }

        /// <summary>
        /// Method used to click on "Submit" button
        /// </summary>
        private void ClickOnSubmitButton()
        {
            ClickElement(submitButton);
        }
        
        /// <summary>
        /// Method used to get contact us success message
        /// </summary>
        /// <returns></returns>
        public string GetContactUsSuccessMessage()
        {
            return CommonMethods.ReadTextFromElement(driver, contactUsSuccessMessage);
        }
        /// <summary>
        /// Method that enters values in elements
        /// </summary>
        /// <param name="firstName">firstName</param>
        /// <param name="email">email</param>
        /// <param name="enquiry">enquiry</param>
        public void ContactUs(string firstName, string email, string enquiry)
        {
            EnterFirstName(firstName);
            EnterEmail(email);
            EnterEnquiry(enquiry);
            ClickOnSubmitButton();
        }
    }
}
