using Microsoft.EntityFrameworkCore;
using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            var wielrenners = new Wielrenner[]
            {
                new Wielrenner {Id = Guid.NewGuid(), Achternaam = "Franckaert", Voornaam = "Robin" }
            };

            var fietsen = new Fiets[]
            {
                new Fiets { Id = Guid.NewGuid(), Merk = "B-Twin", Zadel = "Zwart zadel", WielrennerId = wielrenners[0].Id }
            };

            var supporters = new Supporter[]
            {
                new Supporter {Id = Guid.NewGuid(), Achternaam = "Supporter", Voornaam = "1"}
            };

            var clubs = new Club[]
            {
                new Club {Id = Guid.NewGuid(), Clubnaam = "WTC"}
            };

            modelBuilder.Entity<Fiets>()
                .HasData(fietsen);

            modelBuilder.Entity<Wielrenner>()
                .HasData(wielrenners);

       

            modelBuilder.Entity<Supporter>()
                .HasData(supporters);

            modelBuilder.Entity<Club>()
                .HasData(clubs);


        }

        


    }
}
