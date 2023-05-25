namespace AutomationFramework.TestData
{
    /// <summary>
    /// Class used to store all of the test data
    /// </summary>
    public class TestData
    {
        public static class RegisterUserTestData
        {
            public const string firstName = "TestingFirstName",
                                lastName = "TestingLastName",
                                email = "testingemail123@gmail.com",
                                telephone = "321235324",
                                fax = "2312321",
                                companyName = "TestingCompanyName",
                                address1 = "TestingAddress1",
                                address2 = "TestingAdress2",
                                city = "TestingCity",
                                zipCode = "123123",
                                loginName = "TestLoginName",
                                password = "TestPassword123";
        }

        public static class LogOffTestData
        {
            public const string userName = "PetarMilovanovic",
                                password = "Petar123";
        }

        public static class EnquiryTestData
        {
            public const string enquiry = "Test message";
        }

        public static class CartCounter
        {
            public static int cartCounter = 0;
        }

        public static class SearchProductName
        {
            public const string searchProductName = "Brunette";
        }
        
        public static class AddToWishList
        {
            public const string productName = "Brunette expressions Conditioner";
        }
    }
}

