using NUnit.Framework;

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
