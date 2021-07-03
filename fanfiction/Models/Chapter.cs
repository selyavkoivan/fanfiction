using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fanfiction.Models
{
    public class Chapter
    {
        [Key]
        public int ChapterId {get;set;}
        [Required]
        public int ChapterNumber { get; set; }
        [Required]
        [MaxLength(100000)]
        public string Text { get; set; }
        [Required]
        public Fanfic fanfic { get; set; }

       

    }
}
