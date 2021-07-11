﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialCyclingWorld.Web.Data;

namespace SuperCyclingWorld.Web.Migrations
{
    [DbContext(typeof(SCWDbContext))]
    [Migration("20210709235449_BackToFullSeed")]
    partial class BackToFullSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Club", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("Clubleider");

                    b.Property<string>("Clubnaam");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), Clubnaam = "WTC" },
                        new { Id = new Guid("0cf2567c-e2a7-4116-a6da-b67ea3ed4e0a"), Clubnaam = "DCTV" },
                        new { Id = new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), Clubnaam = "De lustige rijders" },
                        new { Id = new Guid("0be32fb8-0809-444c-88f5-ee5d80e3adcf"), Clubnaam = "WTC Melsele" },
                        new { Id = new Guid("72ce1fbf-52e4-4605-980f-b33273efc20a"), Clubnaam = "The master cyclists" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.ClubSupporter", b =>
                {
                    b.Property<Guid>("ClubId");

                    b.Property<Guid>("SupporterId");

                    b.HasKey("ClubId", "SupporterId");

                    b.HasIndex("SupporterId");

                    b.ToTable("ClubSupporter");

                    b.HasData(
                        new { ClubId = new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), SupporterId = new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec") },
                        new { ClubId = new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), SupporterId = new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a") }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.FanRegistratie", b =>
                {
                    b.Property<Guid>("SupporterId");

                    b.Property<Guid>("WielrennerId");

                    b.HasKey("SupporterId", "WielrennerId");

                    b.HasIndex("WielrennerId");

                    b.ToTable("FanRegistratie");

                    b.HasData(
                        new { SupporterId = new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"), WielrennerId = new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f") },
                        new { SupporterId = new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"), WielrennerId = new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f") }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Fiets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Merk");

                    b.Property<Guid>("WielrennerId");

                    b.Property<string>("Zadel");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Fietsen");

                    b.HasData(
                        new { Id = new Guid("ab845e97-e794-4ef3-97e9-fbbbe9fee539"), Merk = "B-Twin", WielrennerId = new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("b7dbf5d3-7cc7-4d4f-9298-4852da1a6d02"), Merk = "Moldava", WielrennerId = new Guid("613cb985-0b5f-40e1-ac30-a7dcb03d33c5"), Zadel = "Geel zadel" },
                        new { Id = new Guid("18c49d08-64dd-45c2-97c7-2bb3a0f235d5"), Merk = "Merckx", WielrennerId = new Guid("ff028d06-a026-4868-96ca-812c4f3751f1"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Supporter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<string>("Paswoord");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.ToTable("Supporters");

                    b.HasData(
                        new { Id = new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"), Achternaam = "The Pooh", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Winnie" },
                        new { Id = new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec"), Achternaam = "Van Achtmaal", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Thomas" },
                        new { Id = new Guid("01e05cfb-45ab-4248-9590-013456a571dc"), Achternaam = "VanKerkhove", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Nico" },
                        new { Id = new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"), Achternaam = "Kronenburg", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Koen" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<Guid>("ClubId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("GeboorteDatum");

                    b.Property<string>("Paswoord");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("ff028d06-a026-4868-96ca-812c4f3751f1"), Achternaam = "Franckaert", ClubId = new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Robin" },
                        new { Id = new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f"), Achternaam = "Jansma", ClubId = new Guid("0cf2567c-e2a7-4116-a6da-b67ea3ed4e0a"), GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Johanna" },
                        new { Id = new Guid("613cb985-0b5f-40e1-ac30-a7dcb03d33c5"), Achternaam = "Vissers", ClubId = new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Bert" },
                        new { Id = new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f"), Achternaam = "Depardieu", ClubId = new Guid("0be32fb8-0809-444c-88f5-ee5d80e3adcf"), GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Gerard" },
                        new { Id = new Guid("6cabc8ca-d976-4a9a-b636-d33a406a6c2d"), Achternaam = "Van Overmeire", ClubId = new Guid("72ce1fbf-52e4-4605-980f-b33273efc20a"), GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "123", Voornaam = "Marc" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.ClubSupporter", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club")
                        .WithMany("ClubSupporters")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Supporter")
                        .WithMany("Clubs")
                        .HasForeignKey("SupporterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.FanRegistratie", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Supporter")
                        .WithMany("Wielrenners")
                        .HasForeignKey("SupporterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner")
                        .WithMany("Wielrenners")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Fiets", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner")
                        .WithMany("Fietsen")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}