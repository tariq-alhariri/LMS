using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Models
{
    public class LMSContext : DbContext
    {
        public LMSContext (DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public DbSet<LMS.Models.Author> Author { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>()
        //        .HasAlternateKey(c => c.DisplayedName)
        //        .HasName("AlternateKey_LicensePlate");
        //}

        public DbSet<LMS.Models.Book> Book { get; set; }
    }
}
