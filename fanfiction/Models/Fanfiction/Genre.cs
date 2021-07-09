using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fanfiction.Models.Fanfiction
{
    public class Genre : IDisposable
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public class GenreModel
    {
        public Genre genre;
        public string lang;
        
    }
    public class GenresModel
    {
        public List<Genre> genres;
        public string lang;
        
    }
}
