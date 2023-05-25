using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFramework.Tests
{
    public class SearchProductTest : BaseTest
    {
        [Test]
        public void SearchProduct()
        {
            // Enter search product name
            Pages.HomePage.CompleteSearch(TestData.TestData.SearchProductName.searchProductName);

            // Test assert
            Assert.IsTrue(Pages.HomePage.IsItemShown());
        }
    }
}
