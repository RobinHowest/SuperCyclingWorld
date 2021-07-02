using Microsoft.EntityFrameworkCore;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.Entities.Base;
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

            modelBuilder.Entity<FanRegistratie>()
                .HasKey(fr => new { fr.SupporterId, fr.WielrennerId });

            modelBuilder.Entity<ClubSupporter>()
                .HasKey(cs => new { cs.ClubId, cs.SupporterId });

            modelBuilder.Entity<Wielrenner>()
                .Property(w => w.ClubId)
                .IsRequired();

            modelBuilder.Entity<Fiets>()
                .Property(f => f.WielrennerId)
                .IsRequired();


            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

    }
}
