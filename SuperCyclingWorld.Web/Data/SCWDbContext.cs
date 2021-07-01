using Microsoft.EntityFrameworkCore;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCyclingWorld.Web.Data
{
    public class SCWDbContext : DbContext
    {

        public DbSet<Wielrenner> Wielrenners { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Fiets> Fietsen { get; set; }
        public DbSet<Supporter> Supporters { get; set; }

        public SCWDbContext(DbContextOptions<SCWDbContext> options) : base(options) 
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }
}
