using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
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
        public string lang;
        public List<Fanfic> fanfiction;

        public ProfileUser(ApplicationUser user, string lang, List<Fanfic> fanfiction)
        {
            this.user = user;
            this.lang = lang;
            this.fanfiction = fanfiction;
        }
    }
  
}
