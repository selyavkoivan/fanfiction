using System;
using System.Collections.Generic;
using System.Text;
using fanfiction.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fanfiction.Models.User;
namespace fanfiction.Data
{
    public sealed class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
            Database.EnsureCreated();

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Fanfic> Fanfics{ get; set; }
        public DbSet<Chapter> Chapters{ get; set; }
 
    }
}