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
               /* var builder = new ConfigurationBuilder();
                // установка пути к текущему каталогу
                builder.SetBasePath(Directory.;
                // получаем конфигурацию из файла appsettings.json
                builder.AddJsonFile("appsettings.json");
                // создаем конфигурацию
                var config = builder.Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));*/
               optionsBuilder.UseSqlServer(
                   "Server=(local);Database=fanfictionOffTeam;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public Fandom GetFandom(string name, string lang)
        {
           if(lang == "en") return Fandoms.First(f => f.EnName == name);
           else if(lang == "ru") return Fandoms.First(f => f.RuName == name);
           return Fandoms.First(f => f.RuName == name);
        }

        public  DbSet<Fandom> Fandoms { get; set; }

        public Genre GetGenre(string name, string lang)
        {
            if(lang == "en") return Genres.First(f => f.EnName == name);
            else if(lang == "ru") return Genres.First(f => f.RuName == name);
            return Genres.First(f => f.RuName == name);
        }
        
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Fanfic> Fanfics{ get; set; }
        public DbSet<Chapter> Chapters{ get; set; }
 
    }
   
}