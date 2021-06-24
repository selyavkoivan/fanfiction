using System;

namespace fanfiction.Models.User.Inretfaces
{
    public interface IUser
    {

        public string name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Datetime { get; set; }
        public DateTime GetDate();
     //   public bool EmailConfirmed { get; set; }
    }
}