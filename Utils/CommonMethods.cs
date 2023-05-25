
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutomationFramework.Utils
{
    public class CommonMethods
    {
        /// <summary>
        /// Method used to click on an element
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="element">Element</param>
        public static void ClickOnElement(IWebDriver driver, By element)
        {
            driver.FindElement(element).Click();
        }

        /// <summary>
        /// Method used to write text to an element
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="element">Element</param>
        /// <param name="text">Text</param>
        public static void WriteTextToElement(IWebDriver driver, By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Method used to read text from an element
        /// </summary>
        public static string ReadTextFromElement(IWebDriver driver, By element, uint timeSpan = 20)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeSpan));
            return driver.FindElement(element).Text;
        }

        /// <summary>
        /// Method used to read first row of cells of a table
        /// </summary>
        /// <returns>Values of first row of a table</returns>
        public static List<string> GetValuesFromFirstTableRow(IWebDriver driver)
        {
            List<string> values = new List<string>();
            ReadOnlyCollection<IWebElement> rows = driver.FindElements(By.XPath("//tr[@class='success']"));

            try
            {
                IWebElement firstRow = rows[0];
                ReadOnlyCollection<IWebElement> cells = driver.FindElements(By.XPath("//tr[@class='success']/td"));

                foreach (IWebElement cell in cells)
                {
                    values.Add(cell.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return values;
        }

        /// <summary>
        /// Method used to generate unique username by adding random numbers to provided string
        /// </summary>
        /// <returns>Unique username</returns>
        public static string GenerateRandomUsername(string randomName)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 9999);
            string username = randomName + randomNumber;
            return username;
        }

        /// <summary>
        /// Method used to generate unique email by adding random numbers to provided string
        /// </summary>
        /// <returns>Unique username</returns>
        public static string GenerateRandomEmail(string randomName)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 9999);
            string email = randomName + randomNumber + "@email.com";
            return email;
        }

        /// <summary>
        /// Method used to generate random number
        /// </summary>
        /// <param name="from">From</param>
        /// <param name="to">To</param>
        /// <returns>Random number</returns>
        public static int GenerateRandomNumber(int from, int to)
        {
            Random random = new Random();
            int randomNumber = random.Next(from, to);
            return randomNumber;
        }

        /// <summary>
        /// Method used to check if an element is displayed on a page
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="element">By element locator</param>
        /// <returns>True if element is displayed on a page</returns>
        public static bool IsElementDisplayed(IWebDriver driver, By element, uint timeoutInSeconds = 20)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return driver.FindElement(element).Displayed;

            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Method used to get all options of a Select element
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="element">Element locator</param>
        /// <returns>List of options</returns>
        public static List<string> GetAllOptionsFromSelect(IWebDriver driver, By element)
        {
            List<string> optionsList = new List<string>();

            try
            {
                ReadOnlyCollection<IWebElement> options = driver.FindElements(element);

                foreach (IWebElement option in options)
                {
                    if (!option.Text.Contains("--- Please Select ---"))
                    {
                        optionsList.Add(option.Text);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return optionsList;
        }

        /// <summary>
        /// Method used to get radnom value from a list
        /// </summary>
        /// <param name="list">List</param>
        /// <returns>Random value form a list</returns>
        public static string GetRandomItemFromList(List<string> list)
        {
            Random rnd = new Random();
            return list[rnd.Next(0, list.Count - 1)];
        }

        /// <summary>
        /// Method used to click on a provided radio button
        /// </summary>
        /// <param name="driver">Driver</param>
        /// <param name="radioButton">Radio Button</param>
        public static void ClickOnRadioButtonOrCheckBox(IWebDriver driver, By radioButton)
        {
            driver.FindElement(radioButton).Click();
        }

        /// <summary>
        /// Method used to click on "Login or register" button
        /// </summary>
        public static void ClickOnLoginRegisterButton(IWebDriver driver, By loginRegisterButton)
        {
            CommonMethods.ClickOnElement(driver, loginRegisterButton);
        }
    }
}
