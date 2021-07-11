using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fanfiction.Data;
using fanfiction.Models.User;
using fanfiction.Models.User.Inretfaces;
using Microsoft.EntityFrameworkCore;

namespace fanfiction.Models.Fanfiction
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        [Required]
        public string AuthorId { get; set; }
        [Required]
        public Chapter chapter { get; set; }
        [Required]
        public int chapterId { get; set; }

        
    }

    public class MarkModel
    {
        public List<Mark> marks;
        public ApplicationUser user;
        public string lang;

        public MarkModel(ApplicationUser user, ApplicationDbContext context, string lang)
        {
            this.lang = lang;
            this.user = user;
            marks = context.Marks.Include(m => m.chapter)/*.Include(m => m.Author)
                .Include(m => m.chapter.fanfic).ThenInclude(f => f.fandom).Include(m => m.chapter)
                .ThenInclude(c => c.fanfic).ThenInclude(f => f.genre)*/.Where(m => m.AuthorId == user.Id).ToList();
            foreach (var m in marks)
            {
                m.chapter.fanfic = context.GetFanfic(m.chapter.FanficId);
            }
        }
    }
    

}