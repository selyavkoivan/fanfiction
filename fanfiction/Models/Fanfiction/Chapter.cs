using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Data;
using fanfiction.Models.User;
using Microsoft.EntityFrameworkCore;

namespace fanfiction.Models.Fanfiction
{
    public class Chapter
    {
        [Key]
        public int ChapterId {get;set;}
        [Required]
        public int ChapterNumber { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100000)]
        public string Text { get; set; }
        
        [Required]
        public Fanfic fanfic { get; set; }
        [Required]
        public int FanficId { get; set; }

        public Chapter(int fanficId, int chapterNumber)
        {
            FanficId = fanficId;
            ChapterNumber = chapterNumber;
        }
        public Chapter()
        {
           
        }
     
       

    }
    public class ChapterRead
    {
        
        public readonly Chapter chapter;
        public bool isLast;
        public int count;
        public bool isLiked;
        public Fanfic fanfic;
        public string lang;
        public bool isSignedIn;
        public bool editStatus;
        public bool isMarked;
        public string userId;
        public ChapterRead(int fanficId, int chapterNumber, ApplicationDbContext context, string userId, string lang, bool adminStatus)
        {
            
            this.lang = lang;
            fanfic = context.GetFanfic(fanficId);
            
            chapter = context.Chapters.AsNoTracking().First(c => c.FanficId == fanficId && c.ChapterNumber == chapterNumber);
            var count = context.Chapters.AsNoTracking().Count(c => c.FanficId == chapter.FanficId);
            if (count == chapter.ChapterNumber) isLast = true;
            else isLast = false;
            var likes = context.Likes.Where(l => l.chapterId == chapter.ChapterId).ToList();
            this.count = likes.Count;
            if (userId == null)
            {
                isLiked = false;
                isSignedIn = false;
                isMarked = false;
            }
            else
            {
                this.userId = userId;
                if (context.Marks.Any(m => m.chapterId == chapter.ChapterId && m.AuthorId == userId)) isMarked = true;
                if (fanfic.Author.Id == userId || adminStatus) editStatus = true; 
                if (likes.Any(l => l.userId == userId)) isLiked = true;
                else isLiked = false;
                isSignedIn = true;
            }
            
        }
        public ChapterRead()
        {
        }

 
    }
}
