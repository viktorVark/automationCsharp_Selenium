using AutomationFramework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
	public class AddNewAddressPage : BasePage
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
		By firstNameField = By.Id("AddressFrm_firstname");
		By lastNameField = By.Id("AddressFrm_lastname");
		By companyField = By.Id("AddressFrm_company");
		By addres1Field = By.Id("AddressFrm_address_1");
		By cityField = By.Id("AddressFrm_city");
		By stateDropdown = By.Id("AddressFrm_zone_id");
		By stateDropdownOptions = By.XPath("//select[@id='AddressFrm_zone_id']/option");
		By zipCodeField = By.Id("AddressFrm_postcode");
		By countryDropdown = By.Id("AddressFrm_country_id");
		By countryDropdownOptions = By.XPath("//select[@id='AddressFrm_country_id']/option");
		By cityField = By.Id("AddressFrm_city");
		By stateDropdown = By.Id("AddressFrm_zone_id");
		By stateDropdownOptions = By.XPath("//select[@id='AddressFrm_zone_id']/option");
		By zipCodeField = By.Id("AddressFrm_postcode");
		By countryDropdown = By.Id("AddressFrm_country_id");
		By countryDropdownOptions = By.XPath("//select[@id='AddressFrm_country_id']/option");
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
			WaitElementVisibility(stateDropdownOptions);
			List<string> stateList = CommonMethods.GetAllOptionsFromSelect(driver, stateDropdownOptions);

			WaitElementVisibility(stateDropdown);
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
			WaitElementVisibility(countryDropdownOptions);
			List<string> countryList = CommonMethods.GetAllOptionsFromSelect(driver, countryDropdownOptions);

			WaitElementVisibility(countryDropdown);
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
			
			SelectState();

			ClickOnContinue();
		}
	}
}
