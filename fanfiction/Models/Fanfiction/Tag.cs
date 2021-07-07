using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models.User;
using Microsoft.AspNetCore.Identity;
using System.Globalization;
using System.Runtime.CompilerServices;
using fanfiction.Data;

namespace fanfiction.Models.Fanfiction
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        [MaxLength(25)]
        public string text { get; set; }

    }
}