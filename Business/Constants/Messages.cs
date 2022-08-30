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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime="Sistem Bakimda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist="Bu isimde zaten baska bir ürün var";
        public static string CategoryLimitExceded= "Kategori Limiti asildigi icin yeni urun eklenemiyor";
        public static string AuthorizationDenied="Authorization Denied";
        public static string UserRegistered="Kayit Oldu";
        public static string UserNotFound="Kullanici Bulunamadi";
        public static string SuccessfulLogin="Basarili Giris";
        public static string UserAlreadyExists="Kullanici Mevcut";
        public static string AccessTokenCreated="Token Olusturuldu";

        public static string PasswordError = "Yanlis Parola";
    }
}
