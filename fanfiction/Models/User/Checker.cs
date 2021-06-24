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
        public static string checkRegistrarion(UserManager<User> users, UserReg user)
        {
            if (user.PasswordConfirm != user.Password) return "password is not confirmed";
            if (users.Users.Any(b => b.Email == user.Email)) return "email is already taken";
            return string.Empty;
        }
        public static string checkLogin(User user)
        {
            if (user == null) return "account is not found";
            if (user.EmailConfirmed == false) return "email is not confirmed";
            if (user.Status) return "account is blocked";
            return string.Empty;
        }
    }
}
