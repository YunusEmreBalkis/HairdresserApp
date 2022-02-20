using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string SalonOwnerAdded = "Salon eklendi";
        public static string SalonOwnerDeleted = "Salon silindi";
        public static string SalonOwnerUpdated = "Salon güncellendi";
        public static string SalonOwnerListed = "Salonlar listelendi";
        public static string UserUpdated = "Kullanıcı başarılı bir şekilde güncellendi";
        public static string UserDeleted = "Kullanıcı başarılı bir şekilde silindi";
        public static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi";
        public static string UsersListed = "Kullanıcıalar başarılı bir şekilde listelendi";
        public static string AppointmentAdded = "Randevu oluşturuldu";
        public static string AppointmentDeleted = "Randevu silindi";
        public static string AppointmentUpdated = "Randevu güncellendi";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserNameAlreadyExists;
    }
}
