using Core.Entities.Concrete;
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
        public static string CategoryLimitExceeded = "Category limit exceeded";
        public static string AuthorizationDenied = "Authorization is denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User can not be found";
        public static string PasswordError = "Password is incorrect";
        public static string SuccessfulLogin = "Successfull login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
