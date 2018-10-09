using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LMS.Models
{
    public class LMSContext : DbContext
    {
        public LMSContext (DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public DbSet<LMS.Models.Author> Author { get; set; }
    }
}
