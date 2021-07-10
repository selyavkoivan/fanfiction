using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using fanfiction.Data;
using fanfiction.Models.User;
using fanfiction.Models.User.Inretfaces;

namespace fanfiction.Models.Fanfiction
{
    public class Rate
    {
        [Key]
        public int RateId { get; set; }
        [Required]
        [MaxLength(1000)]
        public short rate  { get; set; }
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
    
    public class RateModel
    {
        public List<Rate> Rates;
        public double average;
        public Rate myRate;
        public RateModel(List<Rate> Rates, string UserId)
        {
            if(Rates.Count != 0)
            {
                this.Rates = Rates;
                average = this.Rates.Average(r => r.rate);
                myRate = this.Rates.FirstOrDefault(r => r.AuthorId == UserId);
            }


        }

        public RateModel()
        {
            Rates = new List<Rate>();
        }
    }
    

}