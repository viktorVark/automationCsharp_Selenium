using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace AutomationFramework.Pages
{
    public class AddNewAddressPage : BasePage
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public AddNewAddressPage()
		{
			driver = null;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="webDriver">webDriver</param>
		public AddNewAddressPage(IWebDriver webDriver)
		{
			driver = webDriver;
		}

		//Locators
		By newAddressButton = By.XPath("//a[@title = 'New Address']");
		By firstNameField = By.Id("guestFrm_firstname");
		By lastNameField = By.Id("guestFrm_lastname");
		By companyField = By.Id("guestFrm_company");
		By addres1Field = By.Id("guestFrm_address_1");
		By cityField = By.Id("guestFrm_city");
		By stateDropdown = By.Id("guestFrm_zone_id");
		By stateDropdownOptions = By.XPath("//select[@id='guestFrm_zone_id']/option");
		By zipCodeField = By.Id("guestFrm_postcode");
		By countryDropdown = By.Id("guestFrm_country_id");
		By countryDropdownOptions = By.XPath("//select[@id='guestFrm_country_id']/option");
		By continueButton = By.XPath("//button[@title='Continue' and @type='submit']");
		By successAlert = By.XPath("//div[@class='alert alert-success']");


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
		/// Method used to get all of the countries from a select element,
		/// to initialize a C# select object and to select a random country from aforementioned list
		/// </summary>
		private void SelectCountry()
		{
			List<string> countryList = CommonMethods.GetAllOptionsFromSelect(driver, countryDropdownOptions);
			SelectElement select = new SelectElement(driver.FindElement(countryDropdown));
			select.SelectByText(CommonMethods.GetRandomItemFromList(countryList));
		}

		/// <summary>
		/// Method used to click on "Continue" button
		/// </summary>
		private void ClickOnContinue()
		{
			ClickElement(continueButton);
		}

		/// <summary>
		/// Metoda koja klikne na new addres dugme
		/// </summary>
		public void CLickOnNewAddressButton()
		{
			ClickElement(newAddressButton);
		}

		public string ReadSuccessAlert()
		{
			return CommonMethods.ReadTextFromElement(driver, successAlert);
		}

		/// <summary>
		/// Metoda koja puni formu za adresu
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="companyName"></param>
		/// <param name="addres1"></param>
		/// <param name="zipCode"></param>
		/// <param name="city"></param>
		public void EnterAllFieldsForAddress(
			string firstName,
			string lastName,
			string companyName,
			string addres1,
			string zipCode,
			string city
			)
		{
			EnterFirstName(firstName);
			EnterLastName(lastName);
			EnterCompanyName(companyName);
			EnterFirstAddress(addres1);
			EnterZipCode(zipCode);
			EnterCity(city);

			SelectCountry();
			Thread.Sleep(1000);
			SelectState();

			ClickOnContinue();
		}
	}
}
