using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using fanfiction.Data;
using fanfiction.Models.User;
using fanfiction.Models.User.Inretfaces;

namespace fanfiction.Models.Fanfiction
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        public ApplicationUser Author { get; set; }
        [Required]
        public string AuthorId { get; set; }
        [Required]
        public Fanfic fanfic { get; set; }
        [Required]
        public int fanficId { get; set; }
        
        public void GetAuthorData(ApplicationDbContext context)
        {
            Author = context.Users.Find(AuthorId);
        }
        
    }
    

}