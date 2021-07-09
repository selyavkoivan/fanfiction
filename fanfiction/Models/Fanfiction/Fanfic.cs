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
        public string Name { get; set; }
        [Required]
        public string Lang { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        
        [Required]
        public string ApplicationUserId { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        
        [Required]
        public Genre genre { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public Fandom fandom { get; set; }
        
        public List<Chapter> Chapters { get; set; }
        
        [Required]
        public int FandomId { get; set; }
        public List<Tag> Tags { get; set; }

        public Fanfic()
        {
            Author = new ApplicationUser();
            fandom = new Fandom();
            genre = new Genre();
        }
        public Fanfic(AddFanficData data, ApplicationDbContext context, string lang, ApplicationUser author)
        {
            Description = data.Description;
            Author = author;
            Name = data.name;
            Lang = data.lang;
            fandom = context.GetFandom(data.fandomName, lang);
            genre = context.GetGenre(data.genreName, lang);
            
        }
    }

    public class FanficModel
    {
        public Comment urComment {get; set;}
        public List<Comment> Comments {get;set;}
        public bool isMine;
        public Fanfic fanfic { get; set; }
        public string lang { get; }

        public FanficModel()
        {
            fanfic = new Fanfic();
        }

        public FanficModel(Fanfic fanfic, string lang, string Id, List<Comment> comments)
        {
            urComment = new Comment();
            this.Comments = comments;
            this.fanfic = fanfic;
            this.lang = lang;
            if (fanfic.ApplicationUserId == Id) isMine = true;
            else isMine = false;
        }
    }
    public class FanfictionModel
    {
      
        public List<Fanfic> fanfic { get; set; }
        public string lang { get; }

        public FanfictionModel()
        {
            fanfic = new List<Fanfic>();
        }

        public FanfictionModel(ApplicationDbContext context, string lang)
        {
            fanfic = context.Fanfics.ToList();
            for (int i = 0; i < fanfic.Count; i++)
            {
                fanfic[i] = context.GetAllFanficData(fanfic[i]);
            }
            this.lang = lang;
        }
    }

}
