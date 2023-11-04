using System;
namespace Business.Utilities.Message
{
    public class UserMessageManager : IUserMessageService
    {
        public string GetEmailRequired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email is required!" },
        { "tr", "E-posta zorunludur!" }
    }[languageKey];

        public string GetPhoneRequired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Phone number is required!" },
        { "tr", "Telefon numarası zorunludur!" }
    }[languageKey];
        
        public string GetUsernameRequired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Username is required!" },
        { "tr", "Kullanıcı adı zorunludur!" }
    }[languageKey];

        public string GetPasswordRequired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Password is required!" },
        { "tr", "Parola zorunludur!" }
    }[languageKey];

        public string GetProfileUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Profile is updated." },
        { "tr", "Profil güncellendi." }
    }[languageKey];

        public string GetEmailVerified(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email is verified." },
        { "tr", "E-posta doğrulandı." }
    }[languageKey];

        public string GetPhoneVerified(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Phone number is verified." },
        { "tr", "Telefon numarası doğrulandı." }
    }[languageKey];

        public string GetAccountLocked(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is locked." },
        { "tr", "Hesap kilitlendi." }
    }[languageKey];

        public string GetAccountUnlocked(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is unlocked." },
        { "tr", "Hesap kilidi açıldı." }
    }[languageKey];

        public string GetEmailSent(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email sent to xxx_user." },
        { "tr", "E-posta xxx_user gönderildi." }
    }[languageKey];

        public string GetAccountSuspended(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is suspended." },
        { "tr", "Hesap askıya alındı." }
    }[languageKey];

        public string GetEmailNotAvailable(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email is not available." },
        { "tr", "E-posta mevcut değil." }
    }[languageKey];

        public string GetPhoneNotAvailable(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Phone number is not available." },
        { "tr", "Telefon numarası mevcut değil." }
    }[languageKey];

        public string GetUserNotFound(string languageKey) => new Dictionary<string, string>
    {
        { "en", "User not found." },
        { "tr", "Kullanıcı bulunamadı." }
    }[languageKey];

        public string GetPasswordIncorrect(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Incorrect password." },
        { "tr", "Yanlış parola." }
    }[languageKey];

        public string GetEmailAlreadyInUse(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email is already in use." },
        { "tr", "E-posta zaten kullanılıyor." }
    }[languageKey];

        public string GetPhoneAlreadyInUse(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Phone number is already in use." },
        { "tr", "Telefon numarası zaten kullanılıyor." }
    }[languageKey];

        public string GetVerificationCodeExpired(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Verification code is expired." },
        { "tr", "Doğrulama kodu süresi doldu." }
    }[languageKey];

        public string GetAccountDeleted(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is deleted." },
        { "tr", "Hesap silindi." }
    }[languageKey];

        public string GetPasswordChanged(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Password is changed." },
        { "tr", "Parola değiştirildi." }
    }[languageKey];

        public string GetUnauthorizedAccess(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Unauthorized access." },
        { "tr", "Yetkisiz erişim." }
    }[languageKey];

        public string GetProfilePictureUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Profile picture is updated." },
        { "tr", "Profil fotoğrafı güncellendi." }
    }[languageKey];

        public string GetProfilePictureRemoved(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Profile picture is removed." },
        { "tr", "Profil fotoğrafı kaldırıldı." }
    }[languageKey];

        public string GetAccountReactivated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is reactivated." },
        { "tr", "Hesap yeniden etkinleştirildi." }
    }[languageKey];

        public string GetAccountDeactivated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is deactivated." },
        { "tr", "Hesap devre dışı bırakıldı." }
    }[languageKey];

        public string GetInvalidEmailAddress(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Invalid email address." },
        { "tr", "Geçersiz e-posta adresi." }
    }[languageKey];

        public string GetInvalidPhoneNumber(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Invalid phone number." },
        { "tr", "Geçersiz telefon numarası." }
    }[languageKey];

        public string GetInvalidUsername(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Invalid username." },
        { "tr", "Geçersiz kullanıcı adı." }
    }[languageKey];

        public string GetEmailUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Email is updated." },
        { "tr", "E-posta güncellendi." }
    }[languageKey];

        public string GetPhoneNumberUpdated(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Phone number is updated." },
        { "tr", "Telefon numarası güncellendi." }
    }[languageKey];

        public string GetAccountSuspendedDueToViolation(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is suspended due to a violation." },
        { "tr", "Hesap ihlal nedeniyle askıya alındı." }
    }[languageKey];

        public string GetAccountClosed(string languageKey) => new Dictionary<string, string>
    {
        { "en", "Account is closed." },
        { "tr", "Hesap kapatıldı." }
    }[languageKey];
    }

}

