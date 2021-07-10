using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using fanfiction.Models.User.Inretfaces;

namespace fanfiction.Models.Fanfiction
{
    public class Fandom
    {
        [Key]
        public int FandomId { get; set; }
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
    public class FandomModel
    {
        public Fandom fandom;
        public string lang;
        public bool IsSignedIn { get; set; }
    }
    public class FandomsModel
    {
        public List<Fandom> fandoms;
        public string lang;

        public bool IsSignedIn { get; set; }
    }
}