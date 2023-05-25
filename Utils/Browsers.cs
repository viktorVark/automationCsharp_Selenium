using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutomationFramework.Utils
{
    /// <summary>
    /// Class used to configure browser 
    /// </summary>
    public class Browsers
    {
        private IWebDriver webDriver;
        private string baseURL = "https://automationteststore.com/";

        /// <summary>
        /// Metoda koja pravi objekat odredjenog Browser-a, maximizira prozor i navigira na baseURL
        /// </summary>
        public void Init()
        {
            var chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("ignore-certificate-errors");
            chromeOptions.AddArgument("start-maximized");
            webDriver = new ChromeDriver(chromeOptions);

            Goto(baseURL);
        }

        /// <summary>
        /// Getter method for webDriver
        /// </summary>
        public IWebDriver GetDriver
        {
            get { return webDriver; }
        }

        /// <summary>
        /// Method used to navigate Driver to URL
        /// </summary>
        /// <param name="url">URL</param>
        public void Goto(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Method used to close down Driver
        /// </summary>
        public void Close()
        {
            webDriver.Quit();
        }
    }
}