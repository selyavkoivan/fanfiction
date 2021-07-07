using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models.User;
using Microsoft.AspNetCore.Identity;
using System.Globalization;
using System.Runtime.CompilerServices;
using fanfiction.Data;

namespace fanfiction.Models.Fanfiction
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
        public List<Tag> Tags { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lang { get; set; }
        public Fanfic()
        {
            Author = new ApplicationUser();
            fandom = new Fandom();
            genre = new Genre();
        }
        public Fanfic(AddFanficData data, ApplicationDbContext context, string lang)
        {
            Author = data.Author;
            Name = data.name;
            Lang = lang;
            fandom = context.GetFandom(data.fandomName, lang);
            genre = context.GetGenre(data.genreName, lang);
        }
    }
}
