using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fanfiction.Models.Fanfiction
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(50)]
        public string RuName { get; set; }
        [MaxLength(1000)]
        public string RuDescription { get; set; }
        [Required]
        [MaxLength(50)]
        public string EnName { get; set; }
        [MaxLength(1000)]
        public string EnDescription { get; set; }
    }
}
