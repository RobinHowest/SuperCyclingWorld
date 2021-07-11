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
    [Migration("20210711013150_SeedZoeveel2")]
    partial class SeedZoeveel2
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

                    b.Property<int>("AantalRecords");

                    b.Property<Guid?>("Clubleider");

                    b.Property<string>("Clubnaam");

                    b.Property<int>("Oprichtingsjaar");

                    b.HasKey("Id");

                    b.ToTable("Clubs");

                    b.HasData(
                        new { Id = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), AantalRecords = 0, Clubnaam = "WTC", Oprichtingsjaar = 2001 },
                        new { Id = new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), AantalRecords = 0, Clubnaam = "DCTV", Oprichtingsjaar = 2016 },
                        new { Id = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), AantalRecords = 0, Clubnaam = "De lustige rijders", Oprichtingsjaar = 1991 },
                        new { Id = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), AantalRecords = 0, Clubnaam = "WTC Melsele", Oprichtingsjaar = 1966 },
                        new { Id = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), AantalRecords = 0, Clubnaam = "The master cyclists", Oprichtingsjaar = 2011 }
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
                        new { ClubId = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), SupporterId = new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                        new { ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), SupporterId = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                        new { ClubId = new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), SupporterId = new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                        new { ClubId = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), SupporterId = new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") },
                        new { ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), SupporterId = new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                        new { ClubId = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), SupporterId = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                        new { ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), SupporterId = new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                        new { ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), SupporterId = new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                        new { ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), SupporterId = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                        new { ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), SupporterId = new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                        new { ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), SupporterId = new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065") },
                        new { ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), SupporterId = new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") }
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
                        new { SupporterId = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), WielrennerId = new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                        new { SupporterId = new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), WielrennerId = new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") },
                        new { SupporterId = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), WielrennerId = new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092") },
                        new { SupporterId = new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), WielrennerId = new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                        new { SupporterId = new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), WielrennerId = new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c") },
                        new { SupporterId = new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), WielrennerId = new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") }
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
                        new { Id = new Guid("82f91289-258b-4dea-b041-49be98252f0d"), Merk = "B-Twin", WielrennerId = new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), Zadel = "Zwart zadel" },
                        new { Id = new Guid("1c8eed52-ebc4-4141-a590-6323ceefb266"), Merk = "Moldava", WielrennerId = new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), Zadel = "Geel zadel" },
                        new { Id = new Guid("5c3475e3-55b8-49d5-b5fd-79d4589466ea"), Merk = "Merckx", WielrennerId = new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), Zadel = "Oranje zadel" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RecordCijfer");

                    b.Property<string>("RecordEenheid");

                    b.Property<int>("RecordType");

                    b.Property<string>("Recordnaam");

                    b.Property<Guid?>("WielrennerId");

                    b.HasKey("Id");

                    b.HasIndex("WielrennerId");

                    b.ToTable("Records");
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
                        new { Id = new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), Achternaam = "The Pooh", Email = "ThePooh@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Winnie" },
                        new { Id = new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), Achternaam = "Van Achtmaal", Email = "VanAchtmaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Thomas" },
                        new { Id = new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), Achternaam = "VanKerkhove", Email = "VanKerkhove@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Nico" },
                        new { Id = new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), Achternaam = "Kronenburg", Email = "Kronenburg@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Koen" },
                        new { Id = new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065"), Achternaam = "Van Kruisem", Email = "VanKruisem@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Willy" },
                        new { Id = new Guid("54a63cb2-4938-473a-9a60-35f08acd10bc"), Achternaam = "Wezemaal", Email = "Wezemaal@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Bert" },
                        new { Id = new Guid("4cbfef3b-c60e-405d-8356-d34f9c95f40b"), Achternaam = "Opdorp", Email = "Opdorp@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Alfons" },
                        new { Id = new Guid("6aa5e12e-c657-480f-a50d-dd4ca9af1273"), Achternaam = "AppelGate", Email = "Appelgate@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Christina" },
                        new { Id = new Guid("09ba45f6-741d-4496-81aa-4a32c47cff28"), Achternaam = "Monroe", Email = "Monroe@live.be", GeboorteDatum = new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Marlyn" },
                        new { Id = new Guid("8f571ad6-b43e-4b7c-82f6-98ee02c967d4"), Achternaam = "Clooney", Email = "Clooney@live.be", GeboorteDatum = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "George" },
                        new { Id = new Guid("5cb20494-25c6-4179-af48-ce8b6997224b"), Achternaam = "Peeters", Email = "Peeters@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Jan" },
                        new { Id = new Guid("46fa8116-d0d4-46e5-a9cf-b75239dc144c"), Achternaam = "Reyns", Email = "Reyns@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", Voornaam = "Rita" }
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

                    b.Property<int>("TotaalAantalGeredenKilometers");

                    b.Property<string>("Voornaam");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Wielrenners");

                    b.HasData(
                        new { Id = new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), Achternaam = "Franckaert", ClubId = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), Email = "Franckaert@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 103, Voornaam = "Robin" },
                        new { Id = new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), Achternaam = "Jansma", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "Jansma@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 260, Voornaam = "Johanna" },
                        new { Id = new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), Achternaam = "Vissers", ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), Email = "Vissers@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 301, Voornaam = "Bert" },
                        new { Id = new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8"), Achternaam = "Depardieu", ClubId = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), Email = "Depardieu@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 85, Voornaam = "Gerard" },
                        new { Id = new Guid("5cacc0e0-033c-499c-be70-bce6319bf057"), Achternaam = "Van Overmeire", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "VanOvermeire@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 256, Voornaam = "Marc" },
                        new { Id = new Guid("9f131089-91cc-4b41-9445-3bd7d7224d48"), Achternaam = "Camara", ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), Email = "Camara@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 504, Voornaam = "Herdy" },
                        new { Id = new Guid("ce776019-6454-45c0-9d9c-8f428ab6c263"), Achternaam = "Donckerwolcke", ClubId = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), Email = "Donckerwolcke@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1100, Voornaam = "Thomas" },
                        new { Id = new Guid("1b4f7524-0704-4e5b-8bc5-b08923577258"), Achternaam = "Garnaal", ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), Email = "Garnaal@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 250, Voornaam = "Sofie" },
                        new { Id = new Guid("5c75f356-7c30-4532-afed-c1b4f46bf0cb"), Achternaam = "Brokkenpap", ClubId = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), Email = "Brokkenpap@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 125, Voornaam = "Berend" },
                        new { Id = new Guid("05e4f932-16c4-4ef7-8d51-ea3d90a6d11a"), Achternaam = "Mega", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "Mega@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 568, Voornaam = "Mindy" },
                        new { Id = new Guid("6dc0f0ff-efc5-4e22-83c7-1f2273d1eb60"), Achternaam = "Scarlet", ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), Email = "Scarlet@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 308, Voornaam = "Johanson" },
                        new { Id = new Guid("a5d5c07d-b862-401c-b29e-8d5a096e53a9"), Achternaam = "Beukelaer", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "Beukelaer@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 1250, Voornaam = "Koekjes" },
                        new { Id = new Guid("5dc84776-c3aa-49b3-9e2d-d5a7fdebdd16"), Achternaam = "Mertens", ClubId = new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), Email = "Mertens@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 110, Voornaam = "Evelyne" },
                        new { Id = new Guid("a5434e89-36c8-4a81-a6fe-098626fe7e07"), Achternaam = "VanHoof", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "Vanhoof@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 306, Voornaam = "Emily" },
                        new { Id = new Guid("852e4e89-93f1-4a18-86d3-3200ebef635f"), Achternaam = "Vanderplas", ClubId = new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), Email = "Vanderplas@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 59, Voornaam = "Sonja" },
                        new { Id = new Guid("160c6efd-3b9d-4f84-94f2-9dad9dec4433"), Achternaam = "Bambino", ClubId = new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), Email = "Bambino@live.be", GeboorteDatum = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 257, Voornaam = "Salvatore" },
                        new { Id = new Guid("ce358bbf-7c07-4d63-b7f6-686e7cf80325"), Achternaam = "Zalinski", ClubId = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), Email = "Zalinski@live.be", GeboorteDatum = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 233, Voornaam = "Wosznjeck" },
                        new { Id = new Guid("3ad145aa-a2be-4539-ba6c-695ab6a987b8"), Achternaam = "Debruyne", ClubId = new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), Email = "Debruyne@live.be", GeboorteDatum = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 450, Voornaam = "Kevin" },
                        new { Id = new Guid("d65ef2bc-6022-4c22-b35c-ec39cacf14e2"), Achternaam = "Hazard", ClubId = new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), Email = "Hazard@live.be", GeboorteDatum = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 23, Voornaam = "Eden" },
                        new { Id = new Guid("6989fe60-e616-4d67-96de-1bb65409b422"), Achternaam = "Evenepoel", ClubId = new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), Email = "Evenepoel@live.be", GeboorteDatum = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Paswoord = "202CB962AC59075B964B07152D234B70", TotaalAantalGeredenKilometers = 111, Voornaam = "Remco" }
                    );
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.WielrennerRecords", b =>
                {
                    b.Property<Guid>("RecordId");

                    b.Property<Guid>("WielrennerId");

                    b.HasKey("RecordId", "WielrennerId");

                    b.HasIndex("WielrennerId");

                    b.ToTable("WielrennerRecords");
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

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Record", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany()
                        .HasForeignKey("WielrennerId");
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.Wielrenner", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Club", "Club")
                        .WithMany("Leden")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperCyclingWorld.Core.Entities.WielrennerRecords", b =>
                {
                    b.HasOne("SuperCyclingWorld.Core.Entities.Record", "Record")
                        .WithMany("WielrennerRecords")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperCyclingWorld.Core.Entities.Wielrenner", "Wielrenner")
                        .WithMany("Records")
                        .HasForeignKey("WielrennerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}