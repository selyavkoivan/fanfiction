using System.ComponentModel.DataAnnotations;
using fanfiction.Models.User;

namespace fanfiction.Models.Fanfiction
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }

        public ApplicationUser user { get; set; }
  
        public string userId { get; set; }

        public Chapter chapter { get; set; }

        public int chapterId { get; set; }
        

    }
}