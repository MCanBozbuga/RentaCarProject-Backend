using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages //sürekli new'lememek için burası sabit olduğundan Static verdik.
    {
        public static string CarAdded = "Araba eklendi ";
        public static string CarUpdated = "Arabalar güncellendi";
        public static string CarDeleted = "Arabalar silindi.";
        public static string CarNameInvalid = "Araba ismi geçersiz. ";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarsListed = "Arabalar Listelendi AUTOFAC.";


        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdded = "Markalar eklendi";
        public static string BrandUpdated = "Markalar güncellendi";
        public static string BrandDeleted = "Markalar silindi.";

        public static string ColorListed = "Renkler listelendi";
        public static string ColorAdded = "Renkler eklendi";
        public static string ColorUpdated = "Renkler güncellendi";
        public static string ColorDeleted = "Renkler silindi.";

        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerAdded = "Müşteriler eklendi";
        public static string CustomerUpdated = "Müşteriler güncellendi";
        public static string CustomerDeleted = "Müşteriler silindi.";

        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalAdded = "Kiralamalar eklendi";
        public static string RentalUpdated = "Kiralamalar güncellendi";
        public static string RentalDeleted = "Kiralamalar silindi";

        public static string UserListed = "Kişiler listelendi";
        public static string UserAdded = "Kişiler eklendi";
        public static string UserUpdated = "Kişiler güncellendi";
        public static string UserDeleted = "Kişiler silindi";

        public static string CarImageCountOfCarError = "Fazla resim";
        public static string UploadImage = "Resim yüklendi.";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı hatası";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
    
}
