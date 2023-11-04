using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Resources;

namespace Business.Utilities.Message
{
public class AdminMessageManager : IAdminMessageService
    {

        public string GetStmpNull(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "SMTP address must be filled!" },
                        { "tr", "SMTP adresi doldurulmalıdır!" }
                    }[languageKey];
        public string GetPortNull(string languageKey) =>
                    new Dictionary<string, string>
                    {
                        { "en", "Port number must be filled!" },
                        { "tr", "Port numarası doldurulmalıdır!" }
                    }[languageKey];

        public string GetEmailNull(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Email number must be filled!" },
                        { "tr", "E-posta numarası doldurulmalıdır!" }
                    }[languageKey];
        public string GetPasswordNull(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Password number must be filled!" },
                        { "tr", "Parola numarası doldurulmalıdır!" }
                    }[languageKey];
        public string GetSSLNull(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "SSL must be selected!" },
                        { "tr", "SSL seçilmelidir!" }
                    }[languageKey];
        public string GetEmailParameterAdded(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Email parameter added." },
                        { "tr", "E-posta parametresi eklendi." }
                    }[languageKey];
        public string GetEmailParameterUpdated(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Email parameter updated." },
                        { "tr", "E-posta parametresi güncellendi." }
                    }[languageKey];
        public string GetEmailParameterDeleted(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Email parameter deleted." },
                        { "tr", "E-posta parametresi silindi." }
                    }[languageKey];
        public string GetEmailSent(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Email is sent to xxx_username" },
                        { "tr", "E-posta, xxx_kullanıcı_adına gönderildi." }
                    }[languageKey];
        public string GetRoleNameMustBeFilled(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role name must be filled!" },
                        { "tr", "Rol adı doldurulmalıdır!" }
                    }[languageKey];
        public string GetRoleAdded(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role is created." },
                        { "tr", "Rol oluşturuldu." }
                    }[languageKey];
        public string GetRoleUpdated(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role is updated." },
                        { "tr", "Rol güncellendi." }
                    }[languageKey];
        public string GetRoleRemoved(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role is removed!" },
                        { "tr", "Rol kaldırıldı." }
                    }[languageKey];
        public string GetRoleNameIsAddedAlready(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role Names are already added." },
                        { "tr", "Rol Adları zaten eklenmiş." }
                    }[languageKey];
        public string GetRoleNameIsOk(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role Names are Ok." },
                        { "tr", "Rol Adları uygun." }
                    }[languageKey];
        public string GetUpdatedUser(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Admin is updated." },
                        { "tr", "Yönetici güncellendi." }
                    }[languageKey];
        public string GetDeletedUser(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Admin is deleted!" },
                        { "tr", "Yönetici silindi." }
                    }[languageKey];
        public string GetPasswordCurrentWrong(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Current Password is wrong!" },
                        { "tr", "Geçerli Parola yanlış!" }
                    }[languageKey];
        public string GetPasswordUpdated(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Password is changed!" },
                        { "tr", "Parola değiştirildi." }
                    }[languageKey];
        public string GetUsernameOrPasswordWrong(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Username or Password is wrong!" },
                        { "tr", "Kullanıcı adı veya Parola yanlış!" }
                    }[languageKey];
        public string GetSelectUser(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "You need to select an Admin User" },
                        { "tr", "Bir Yönetici Kullanıcısı seçmeniz gerekiyor" }
                    }[languageKey];
        public string GetSelectRole(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "You need to select a Role" },
                        { "tr", "Bir Rol seçmeniz gerekiyor" }
                    }[languageKey];
        public string GetUserRoleAdded(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "User Role is created." },
                        { "tr", "Kullanıcı Rolü oluşturuldu." }
                    }[languageKey];
        public string GetUserRoleUpdated(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "User Role is updated." },
                        { "tr", "Kullanıcı Rolü güncellendi." }
                    }[languageKey];
        public string GetUserRoleRemoved(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "User Role is removed!" },
                        { "tr", "Kullanıcı Rolü kaldırıldı." }
                    }[languageKey];
        public string GetRoleNameIsAlreadyAdded(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role Name is already added." },
                        { "tr", "Rol Adı zaten eklenmiş." }
                    }[languageKey];
        public string GetUserIsNotFound(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "User is not found." },
                        { "tr", "Kullanıcı bulunamadı." }
                    }[languageKey];
        public string GetRoleNameIsNotFound(string languageKey) => new Dictionary<string, string>
                    {
                        { "en", "Role Name is not found." },
                        { "tr", "Rol Adı bulunamadı." }
                    }[languageKey];
    }
}

