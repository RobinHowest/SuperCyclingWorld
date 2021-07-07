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
            var clubs = new[]
{
                new {Id = Guid.NewGuid(), Clubnaam = "WTC"},
                new {Id = Guid.NewGuid(), Clubnaam = "DCTV"},
                new {Id = Guid.NewGuid(), Clubnaam = "De lustige rijders"},
                new {Id = Guid.NewGuid(), Clubnaam = "WTC Melsele"},
                new {Id = Guid.NewGuid(), Clubnaam = "The master cyclists"}
            };

            //var wielrenners = new []
            //{
            //    new  {Id = Guid.NewGuid(), Achternaam = "Franckaert", Voornaam = "Robin", ClubId = clubs[0].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = "123" },
            //    new  {Id = Guid.NewGuid(), Achternaam = "Jansma", Voornaam = "Johanna", ClubId = clubs[1].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = "123" },
            //    new  {Id = Guid.NewGuid(), Achternaam = "Vissers", Voornaam = "Bert", ClubId = clubs[2].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = "123" },
            //    new  {Id = Guid.NewGuid(), Achternaam = "Depardieu", Voornaam = "Gerard", ClubId = clubs[3].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = "123" },
            //    new  {Id = Guid.NewGuid(), Achternaam = "Van Overmeire", Voornaam = "Marc", ClubId = clubs[4].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = "123" },
            //};

            //var supporters = new []
            //{
            //    new {Id = Guid.NewGuid(), Achternaam = "The Pooh", Voornaam = "Winnie", GeboorteDatum = DateTime.Parse("Jan 1, 2009"), Paswoord = "123"},
            //    new {Id = Guid.NewGuid(), Achternaam = "Van Achtmaal", Voornaam = "Thomas", GeboorteDatum = DateTime.Parse("Jan 1, 2000"), Paswoord = "123"},
            //    new {Id = Guid.NewGuid(), Achternaam = "VanKerkhove", Voornaam = "Nico", GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = "123"},
            //    new {Id = Guid.NewGuid(), Achternaam = "Kronenburg", Voornaam = "Koen", GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = "123"},

            //};

            //var fietsen = new []
            //{
            //    new { Id = Guid.NewGuid(), Merk = "B-Twin", Zadel = "Zwart zadel"},
            //    new { Id = Guid.NewGuid(), Merk = "Moldava", Zadel = "Geel zadel"},
            //    new { Id = Guid.NewGuid(), Merk = "Merckx", Zadel = "Oranje zadel", WielrennerId = wielrenners[1].Id}
            //};


            //var ClubSupporters = new []
            //{
            //    new { ClubId = clubs[2].Id, SupporterId = supporters[1].Id},
            //    new { ClubId = clubs[0].Id, SupporterId = supporters[0].Id}
            //};

            //var FanRegistraties = new []
            //{
            //    new { WielrennerId = wielrenners[1].Id, SupporterId = supporters[0].Id},
            //    new { WielrennerId = wielrenners[3].Id, SupporterId = supporters[3].Id}

            //};




            //modelBuilder.Entity<Fiets>()
            //    .HasData(fietsen);

            //modelBuilder.Entity<Wielrenner>()
            //    .HasData(wielrenners);

            //modelBuilder.Entity<Supporter>()
            //    .HasData(supporters);

            modelBuilder.Entity<Club>()
                .HasData(clubs);

            //modelBuilder.Entity<ClubSupporter>()
            //    .HasData(ClubSupporters);

            //modelBuilder.Entity<FanRegistratie>()
            //    .HasData(FanRegistraties);

        }

        


    }
}
