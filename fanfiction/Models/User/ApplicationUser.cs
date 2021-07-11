using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Data;
using fanfiction.Models.Fanfiction;
using fanfiction.Models.User.Inretfaces;

namespace fanfiction.Models.User
{
    public class ApplicationUser: IdentityUser
    {
        
        public List<Fandom> PreferredFandoms { get; set; }
        public List<Genre> PreferredGenres { get; set; }

        public List<Like> likes { get; set; }
        public List<Fanfic> UserFanfiction { get; set; }
        [Required]
        public bool Status { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime? AuthDate { get; set; }
        public ApplicationUser(IUser user)
        {
            this.UserName = user.name;
            this.Status = false;
            this.RegistrationDate = user.GetDate();
            this.Email = user.Email;
        }

        public ApplicationUser()
        {
            UserFanfiction = new List<Fanfic>();
            PreferredFandoms = new List<Fandom>();
            PreferredGenres = new List<Genre>();
            likes = new List<Like>();
        }
    }
    
    public class ProfileUser
    {
        public ApplicationUser user;
        public bool userIsAdmin;
        public ApplicationUser onPageUser;
        public bool onPageUserIsAdmin;
        public string lang;
        public FanfictionModel fanfiction;
        public ProfileUser(ApplicationUser onPageUser, string lang, List<Fanfic> fanfiction)
        {
            this.lang = lang;
           
            this.onPageUser = onPageUser;
        }
        public ProfileUser(ApplicationUser onPageUser, string lang, ApplicationDbContext context, ApplicationUser user, 
            bool userIsAdmin, bool onPageUserIsAdmin)
        {
            this.userIsAdmin = userIsAdmin;
            this.onPageUserIsAdmin = onPageUserIsAdmin;
            this.onPageUser = onPageUser;
            this.lang = lang;
            this.user = user;
            this.fanfiction = new FanfictionModel(context, string.Empty, onPageUser.Id);
        }
        
    }
    public class Users
    {
        public List<ApplicationUser> users;
        public ApplicationUser admin;
        public string lang;
    }

}
