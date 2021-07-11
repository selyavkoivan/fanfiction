using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fanfiction.Models;
using fanfiction.Models.Fanfiction;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fanfiction.Models.User;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Ocsp;

namespace fanfiction.Data
{
    public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
      

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseSqlServer(
                   "Data Source=tcp:fanfictiondbserver.database.windows.net,1433;Initial Catalog=fanfiction_db;User Id=selyavkoivan@fanfictiondbserver;Password=QwERt801l");
            }

        }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public  DbSet<ApplicationUser> Users { get; set; }
        public  DbSet<Fandom> Fandoms { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Fanfic> Fanfics{ get; set; }
        public DbSet<Chapter> Chapters{ get; set; }

        public async Task<List<Fanfic>> GetMyFanfiction(string userId)
        {
            var fanfiction = await Fanfics.Where(f => f.ApplicationUserId == userId).ToListAsync();
            foreach (var f in fanfiction)
            {
                f.fandom = await Fandoms.FindAsync(f.FandomId);
                f.genre = await Genres.FindAsync(f.GenreId);
                f.Chapters = await Chapters.Where(c => c.FanficId == f.FanficId).ToListAsync();
              
            }
            return fanfiction;


        }

        public async Task<Fanfic> GetAllFanficDataAsync(Fanfic fanfic)
        {
            fanfic.genre = await Genres.FindAsync(fanfic.GenreId);
            fanfic.fandom = await Fandoms.FindAsync(fanfic.FandomId);
            fanfic.Chapters = await Chapters.Where(c => c.FanficId == fanfic.FanficId).ToListAsync();
            fanfic.Author = await Users.FindAsync(fanfic.ApplicationUserId);
            return fanfic;
        }
        public Fanfic GetAllFanficData(Fanfic fanfic)
        {
            fanfic.genre = Genres.Find(fanfic.GenreId);
            fanfic.fandom = Fandoms.Find(fanfic.FandomId);
            fanfic.Chapters = Chapters.Where(c => c.FanficId == fanfic.FanficId).ToList();
            fanfic.Author = Users.Find(fanfic.ApplicationUserId);
            return fanfic;
        }
        public async Task<Fanfic> GetFanficAsync(int fanficId)
        {
        
            var fanfic = await Fanfics.FindAsync(fanficId);
            fanfic = await GetAllFanficDataAsync(fanfic);
            return fanfic;


        }
        public Fanfic GetFanfic(int fanficId)
        {
        
            var fanfic = Fanfics.Find(fanficId);
            fanfic = GetAllFanficData(fanfic);
            return fanfic;


        }
        public Fandom GetFandom(string name, string lang)
        {
            if(lang == "en") return Fandoms.First(f => f.EnName == name);
            else if(lang == "ru") return Fandoms.First(f => f.RuName == name);
            return Fandoms.First(f => f.RuName == name);
        }

        public Genre GetGenre(string name, string lang)
        {
            if(lang == "en") return Genres.First(f => f.EnName == name);
            else if(lang == "ru") return Genres.First(f => f.RuName == name);
            return Genres.First(f => f.RuName == name);
        }
        
        public async Task<List<Comment>> GetCommentsAsync(int fanficId)
        {
            var comments = await Comments.Where(c => c.fanficId == fanficId).ToListAsync();
            foreach(var it in comments)
            {
                it.GetAuthorData(this);
            }
            return comments;
        }
    }
   
}