using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductCountOfCategoryError = "Product count in a category is at maximum level";
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product is invalid";
        public static string MaintenanceTime = "System is not available due to maintaining";
        public static string ProductListed = "Products listed.";
        public static string ProductNameAlreadyExists = "Product name is already exists, please give other name";
        internal static string CategoryLimitExceeded = "Category limit exceeded";
    }
}
