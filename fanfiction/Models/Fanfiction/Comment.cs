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
        
        [MaxLength(1000)]
        public string Text { get; set; }
        
        public ApplicationUser Author { get; set; }
        
        public string AuthorId { get; set; }
        
        public Fanfic fanfic { get; set; }
        
        public int fanficId { get; set; }
        
        public void GetAuthorData(ApplicationDbContext context)
        {
            Author = context.Users.Find(AuthorId);
        }
        
    }
    

}