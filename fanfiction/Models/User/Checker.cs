using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models.User;

namespace fanfiction.Models.User
{
    static public class Checker
    {
        public static string checkRegistrarion(UserManager<ApplicationUser> users, UserReg user)
        {
            if (user.PasswordConfirm != user.Password) return Errors.getPasswordConfirmed(user.lang);
            if (users.Users.Any(b => b.Email == user.Email)) return Errors.getEmailTaken(user.lang);
            return string.Empty;
        }
        public static string checkLogin(ApplicationUser user, string lang)
        {
            if (user == null) return Errors.getIsNotFound(lang);
            if (user.EmailConfirmed == false) return Errors.getEmailIsNotConfirmed(lang);
            if (user.Status) return Errors.getStatus(lang);
            return string.Empty;
        }
    }

    static class Errors
    {
        public static string getIsNotFound(string lang)
        {
            switch (lang)
            {
                case "ru": return "учетная запись не найдена";
                case "en": return "account is not found";
            }

            return null;
        }
        public   static string getEmailIsNotConfirmed(string lang)
        {
            switch (lang)
            {
                case "ru": return "электронная почта не подтверждена";
                case "en": return "email is not confirmed";
            }

            return null;
        }
        public   static string getStatus(string lang)
        {
            switch (lang)
            {
                case "ru": return "учетная запись заблокирована";
                case "en": return "account is blocked";
            }

            return null;
        }
        public   static string getPasswordConfirmed(string lang)
        {
            switch (lang)
            {
                case "ru": return "пароль не подтвержден";
                case "en": return "password is not confirmed";
            }

            return null;
        }
        public   static string getEmailTaken(string lang)
        {
            switch (lang)
            {
                case "ru": return "электронная почта уже занята";
                case "en": return "email is already taken";
            }

            return null;
        }
        public static string getUsernameTaken(string lang, string username)
        {
            switch (lang)
            {
                case "ru": return $"имя {username} уже занято";
                case "en": return $"username {username} is already taken";
            }

            return null;
        }
    }
}
