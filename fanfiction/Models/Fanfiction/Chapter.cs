using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Data;
using fanfiction.Models.User;

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
        public ChapterRead(int fanficId, int chapterNumber, ApplicationDbContext context, string userId, string lang)
        {
            this.lang = lang;
            fanfic = context.GetFanfic(fanficId);
            chapter = context.Chapters.First(c => c.FanficId == fanficId && c.ChapterNumber == chapterNumber);
            int count = context.Chapters.Count(c => c.FanficId == chapter.FanficId);
            if (count == chapter.ChapterNumber) isLast = true;
            else isLast = false;
            var likes = context.Likes.Where(l => l.chapterId == chapter.ChapterId).ToList();
            this.count = likes.Count;
            if (likes.Count(l => l.userId == userId) == 0) isLiked = false;
            else isLiked = true;
        }
        public ChapterRead()
        {
        }

    }
}
