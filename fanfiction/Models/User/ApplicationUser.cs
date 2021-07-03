using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models.User.Inretfaces;

namespace fanfiction.Models.User
{
    public class ApplicationUser: IdentityUser
    {

        List<Fandom> PreferredFandoms { get; set; }
        List<Genre> PreferredGenres { get; set; }

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
        }
    }
  
}
