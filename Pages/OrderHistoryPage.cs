using Microsoft.CodeAnalysis.CSharp.Syntax;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
	public class OrderHistoryPage : BasePage
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public OrderHistoryPage()
		{
			driver = null;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="webDriver">webDriver</param>
		public OrderHistoryPage(IWebDriver webDriver)
		{
			driver = webDriver;
		}

		//Locators
		By orderIDFields = By.XPath("//div[@class='contentpanel']/div/div[contains(.,'Order ID:')]"); 
		
		/// <summary>
		/// Metoda koja uporedjuje order id-jeve da datom order id-jom
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns></returns>
		public bool CompareOrderIDs(string orderId)
		{
			bool containsOrderID = false;
			ReadOnlyCollection<IWebElement> orderIDsCollection = driver.FindElements(orderIDFields);

			foreach(IWebElement element in orderIDsCollection)
			{
				if(element.Text.Contains(orderId))
				{
					containsOrderID= true;
					break;
				}
				else
				{
					containsOrderID = false;
				}
			}

			return containsOrderID;
		}
	}
}
