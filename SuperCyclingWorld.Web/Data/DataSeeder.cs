using Microsoft.EntityFrameworkCore;
using SuperCyclingWorld.Core.Entities;
using SuperCyclingWorld.Core.HelpClasses;
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

            var wielrenners = new[]
            {
                new  {Id = Guid.NewGuid(), Achternaam = "Franckaert", Voornaam = "Robin", ClubId = clubs[0].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Franckaert@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Jansma", Voornaam = "Johanna", ClubId = clubs[1].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Jansma@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Vissers", Voornaam = "Bert", ClubId = clubs[2].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Vissers@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Depardieu", Voornaam = "Gerard", ClubId = clubs[3].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Depardieu@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Van Overmeire", Voornaam = "Marc", ClubId = clubs[4].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "VanOvermeire@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Camara", Voornaam = "Herdy", ClubId = clubs[0].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Camara@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Donckerwolcke", Voornaam = "Thomas", ClubId = clubs[1].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1985"), Paswoord = MD5.CreateMD5("123"), Email = "Donckerwolcke@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Garnaal", Voornaam = "Sofie", ClubId = clubs[2].Id, GeboorteDatum = DateTime.Parse("Jan 1, 2001"), Paswoord = MD5.CreateMD5("123"), Email = "Garnaal@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Brokkenpap", Voornaam = "Berend", ClubId = clubs[3].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "Brokkenpap@live.be" },
                new  {Id = Guid.NewGuid(), Achternaam = "Mega", Voornaam = "Mindy", ClubId = clubs[4].Id, GeboorteDatum = DateTime.Parse("Jan 1, 1979"), Paswoord = MD5.CreateMD5("123"), Email = "Mega@live.be" },
            };

            var supporters = new[]
            {
                new {Id = Guid.NewGuid(), Achternaam = "The Pooh", Voornaam = "Winnie", GeboorteDatum = DateTime.Parse("Jan 1, 2009"), Paswoord = MD5.CreateMD5("123"), Email = "ThePooh@live.be" },
                new {Id = Guid.NewGuid(), Achternaam = "Van Achtmaal", Voornaam = "Thomas", GeboorteDatum = DateTime.Parse("Jan 1, 2000"), Paswoord = MD5.CreateMD5("123"), Email = "VanAchtmaal@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "VanKerkhove", Voornaam = "Nico", GeboorteDatum = DateTime.Parse("Jan 1, 1999"), Paswoord = MD5.CreateMD5("123"), Email = "VanKerkhove@live.be"},
                new {Id = Guid.NewGuid(), Achternaam = "Kronenburg", Voornaam = "Koen", GeboorteDatum = DateTime.Parse("Jan 1, 1981"), Paswoord = MD5.CreateMD5("123"), Email = "Kronenburg@live.be"},

            };

            var fietsen = new[]
            {
                new { Id = Guid.NewGuid(), Merk = "B-Twin", Zadel = "Zwart zadel", WielrennerId = wielrenners[1].Id},
                new { Id = Guid.NewGuid(), Merk = "Moldava", Zadel = "Geel zadel", WielrennerId = wielrenners[2].Id},
                new { Id = Guid.NewGuid(), Merk = "Merckx", Zadel = "Oranje zadel", WielrennerId = wielrenners[0].Id}
            };


            var ClubSupporters = new[]
            {
                new { ClubId = clubs[2].Id, SupporterId = supporters[1].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[1].Id, SupporterId = supporters[2].Id},
                new { ClubId = clubs[2].Id, SupporterId = supporters[3].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[1].Id},
                new { ClubId = clubs[4].Id, SupporterId = supporters[3].Id},
                new { ClubId = clubs[3].Id, SupporterId = supporters[0].Id},
                new { ClubId = clubs[0].Id, SupporterId = supporters[2].Id}

            };

            var FanRegistraties = new[]
            {
                new { WielrennerId = wielrenners[1].Id, SupporterId = supporters[0].Id},
                new { WielrennerId = wielrenners[3].Id, SupporterId = supporters[3].Id},
                new { WielrennerId = wielrenners[2].Id, SupporterId = supporters[0].Id},
                new { WielrennerId = wielrenners[1].Id, SupporterId = supporters[1].Id},
                new { WielrennerId = wielrenners[0].Id, SupporterId = supporters[3].Id},
                new { WielrennerId = wielrenners[3].Id, SupporterId = supporters[2].Id}

            };




            modelBuilder.Entity<Fiets>()
                .HasData(fietsen);

            modelBuilder.Entity<Wielrenner>()
                .HasData(wielrenners);

            modelBuilder.Entity<Supporter>()
                .HasData(supporters);

            modelBuilder.Entity<Club>()
                .HasData(clubs);

            modelBuilder.Entity<ClubSupporter>()
                .HasData(ClubSupporters);

            modelBuilder.Entity<FanRegistratie>()
                .HasData(FanRegistraties);

        }

        


    }
}
