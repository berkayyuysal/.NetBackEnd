using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sınırına ulaşıldı";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten vardır.";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "UserRegistered ";
        public static string UserNotFound = "UserNotFound ";
        public static string PasswordError = "PasswordError ";
        public static string SuccessfulLogin = "SuccessfulLogin ";
        public static string UserAlreadyExists = "UserAlreadyExists ";
        public static string AccessTokenCreated = "AccessTokenCreated ";
    }
}
