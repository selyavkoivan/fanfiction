using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models.User;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace fanfiction.Models
{
    public class Fanfic
    {
        [Key]
        public int FanficId { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        [Required]
        public Genre genre { get; set; }
        [Required]
        public Fandom fandom { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
