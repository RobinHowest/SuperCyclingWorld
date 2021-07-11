using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedTwoWielrennersHaveMostAantalKilometers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3"), new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"), new Guid("462ba6ff-0b47-4b7d-bcaa-eeb6a96f5faa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"), new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0"), new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"), new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"), new Guid("e3c807c0-e240-4c56-a6a3-9b32fb928f31") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("66379c2d-7961-4d2b-a82b-6ad5f995d3e7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("8e128bd2-b8a2-44f0-8ffa-c92b90ddfc94"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("fedf3e2c-70ae-4184-92ce-e89a89a9237b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0d0a644b-4970-4f7f-95f4-be7edf731dd2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("220f34e6-3431-41c2-805b-fefa6975885e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2e917dea-5485-4840-8029-b64376998111"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3cd1978f-87bb-4e3f-b05f-3dbfdface01d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("53eb436b-65fd-4eaa-9467-3a133b57d57e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5f720209-b8ee-4176-8ff5-ec29eb67cd3d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("abe4c259-5672-4988-b3fc-7d1813c6d8a0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c89a77fe-27b5-420c-854f-47ef12c76cc6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04c9e7fd-58b3-443b-a173-a942939a4437"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c8bfc9c-3595-4ada-ac94-8332d7deb3d9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1591b0c0-305d-4939-af36-26c03c315cc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2041a705-48a8-4f4c-bb4c-852f3ffe3b4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("20566b6e-e61d-4889-9dd1-7041f7203034"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("33c3daa1-299c-4c30-9980-89dbed58be1f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("43b53ef2-6017-4a5c-b434-6a331e8c1ec8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7349e3de-e67a-4d60-842c-d3c0075b5973"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8839ac6c-367d-437b-8f23-bc9e48fad2a7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("90a4e7e2-3780-4661-ac2f-27f952e29d46"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a67b65d3-1a36-4d0c-88ad-07dafbb5944c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b6cc9595-4a40-46a6-bea3-f876caeeeb98"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d071cc77-a6ef-4ce2-9900-b207bb93ac4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e02c2c68-c63b-4b89-ad8c-b86e06d551bc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e7d7ddea-a483-431e-a48b-447dc7f00478"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb93bc5d-2357-43d5-aa00-51267db57be4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("462ba6ff-0b47-4b7d-bcaa-eeb6a96f5faa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e3c807c0-e240-4c56-a6a3-9b32fb928f31"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), 0, null, "WTC", 2001 },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), 0, null, "DCTV", 2016 },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("75a36637-99a0-4d3c-9715-7db08798a2dc"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("d2a31910-5dda-4288-95c2-b0f9ba408605"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("8219f84b-1c79-46ec-8c4e-3dfc7b4757e9"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("f7bf8e60-53c2-4f4e-af3c-f5880096f70a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("fa2521b0-1f7f-4204-b425-b6a387ba3e89"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("5abc3233-0e2e-472e-8de3-dff7cc79647c"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("2c3f1a86-5d39-4c31-8efc-c74c3f61c42d"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("4714c8da-c92d-47a5-9af5-7a2c1f7b4e32"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("2a256162-f9ba-48f4-aa40-6049dd844294") },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                    { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ec268c16-3bcd-46e9-8573-dac50d0b16ed"), 0, "Vanderplas", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 15, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("fb4c24fb-3a10-4e51-95f4-4173033395db"), 0, "VanHoof", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 15, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("6ff39d7e-9dc7-4f1c-9d84-ddef3748f5e2"), 0, "Garnaal", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 15, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("abef85e4-075f-4c95-ab79-34462e40a430"), 0, "Camara", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 15, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), 0, "Vissers", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 15, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("4233cb5b-f66a-4dd4-a712-d3053b0471a2"), 0, "Bambino", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("9a82887f-5832-4ac5-af9f-9f90686213d3"), 0, "Scarlet", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 15, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("fe1adc9c-36b9-42bd-9088-259260a1ec78"), 0, "Mega", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 15, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("58e5ae1e-17a6-4681-a4a9-bf7c7a553d7c"), 0, "Van Overmeire", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 15, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), 0, "Jansma", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 15, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), 0, "Franckaert", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 15, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("5575eaf1-d828-46b2-bde1-861a5f6292db"), 0, "Evenepoel", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 15, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("72205c80-f5d8-4a91-86de-84a10d0ec7e3"), 0, "Beukelaer", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 15, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("a0988b94-0be3-4c94-8716-b4b386d38368"), 0, "Donckerwolcke", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132"), 0, "Depardieu", new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5534f506-e85c-4012-a113-9c49b05983fc"), 0, "Hazard", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("341cdc06-a248-4304-b919-a5801e936539"), 0, "Debruyne", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 15, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("a789d598-b574-449a-8b16-27fa3d4e8ffb"), 0, "Zalinski", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 15, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("1dbf2afc-6418-4a3a-9979-320f6a394f2d"), 0, "Mertens", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 15, "202CB962AC59075B964B07152D234B70", 1250, "Evelyne" },
                    { new Guid("b97a66dd-5e23-4a5f-a305-df433c8f7865"), 0, "Brokkenpap", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 125, "Berend" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") },
                    { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") },
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a") },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                    { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("6c8b4320-cc47-4ed1-8f7a-f3faaafdb2b7"), "Merckx", new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), "Oranje zadel" },
                    { new Guid("7328fc02-3a93-4fc8-a781-8b7db9d539a5"), "B-Twin", new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), "Zwart zadel" },
                    { new Guid("c810e934-261a-4089-af76-83650a0fd0fa"), "Moldava", new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("2a256162-f9ba-48f4-aa40-6049dd844294") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6c8b4320-cc47-4ed1-8f7a-f3faaafdb2b7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7328fc02-3a93-4fc8-a781-8b7db9d539a5"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c810e934-261a-4089-af76-83650a0fd0fa"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2c3f1a86-5d39-4c31-8efc-c74c3f61c42d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4714c8da-c92d-47a5-9af5-7a2c1f7b4e32"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5abc3233-0e2e-472e-8de3-dff7cc79647c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("75a36637-99a0-4d3c-9715-7db08798a2dc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8219f84b-1c79-46ec-8c4e-3dfc7b4757e9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d2a31910-5dda-4288-95c2-b0f9ba408605"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f7bf8e60-53c2-4f4e-af3c-f5880096f70a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fa2521b0-1f7f-4204-b425-b6a387ba3e89"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1dbf2afc-6418-4a3a-9979-320f6a394f2d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("341cdc06-a248-4304-b919-a5801e936539"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4233cb5b-f66a-4dd4-a712-d3053b0471a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5534f506-e85c-4012-a113-9c49b05983fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5575eaf1-d828-46b2-bde1-861a5f6292db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58e5ae1e-17a6-4681-a4a9-bf7c7a553d7c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6ff39d7e-9dc7-4f1c-9d84-ddef3748f5e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72205c80-f5d8-4a91-86de-84a10d0ec7e3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a82887f-5832-4ac5-af9f-9f90686213d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0988b94-0be3-4c94-8716-b4b386d38368"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a789d598-b574-449a-8b16-27fa3d4e8ffb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("abef85e4-075f-4c95-ab79-34462e40a430"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b97a66dd-5e23-4a5f-a305-df433c8f7865"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec268c16-3bcd-46e9-8573-dac50d0b16ed"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb4c24fb-3a10-4e51-95f4-4173033395db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fe1adc9c-36b9-42bd-9088-259260a1ec78"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("104c1651-2ccb-4081-b20b-0202e060866f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), 0, null, "WTC", 2001 },
                    { new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), 0, null, "DCTV", 2016 },
                    { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("53eb436b-65fd-4eaa-9467-3a133b57d57e"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("220f34e6-3431-41c2-805b-fefa6975885e"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("3cd1978f-87bb-4e3f-b05f-3dbfdface01d"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("0d0a644b-4970-4f7f-95f4-be7edf731dd2"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("2e917dea-5485-4840-8029-b64376998111"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("c89a77fe-27b5-420c-854f-47ef12c76cc6"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("abe4c259-5672-4988-b3fc-7d1813c6d8a0"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("5f720209-b8ee-4176-8ff5-ec29eb67cd3d"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb") },
                    { new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3") },
                    { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0") },
                    { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0") },
                    { new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") },
                    { new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") },
                    { new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") },
                    { new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") },
                    { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae") },
                    { new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("e7d7ddea-a483-431e-a48b-447dc7f00478"), 0, "Evenepoel", new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 15, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("7349e3de-e67a-4d60-842c-d3c0075b5973"), 0, "Zalinski", new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 15, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("e02c2c68-c63b-4b89-ad8c-b86e06d551bc"), 0, "Camara", new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 15, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa"), 0, "Jansma", new Guid("971167c3-59e5-4f01-b11f-748a42ba2ac2"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 15, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("43b53ef2-6017-4a5c-b434-6a331e8c1ec8"), 0, "Vanderplas", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 15, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("b6cc9595-4a40-46a6-bea3-f876caeeeb98"), 0, "Scarlet", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 15, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("0c8bfc9c-3595-4ada-ac94-8332d7deb3d9"), 0, "Brokkenpap", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("8839ac6c-367d-437b-8f23-bc9e48fad2a7"), 0, "Garnaal", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 15, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("90a4e7e2-3780-4661-ac2f-27f952e29d46"), 0, "Van Overmeire", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 15, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("462ba6ff-0b47-4b7d-bcaa-eeb6a96f5faa"), 0, "Franckaert", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 15, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("d071cc77-a6ef-4ce2-9900-b207bb93ac4a"), 0, "Beukelaer", new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 15, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("04c9e7fd-58b3-443b-a173-a942939a4437"), 0, "Donckerwolcke", new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776"), 0, "Depardieu", new Guid("df422ec0-1900-49f8-8b50-8423dc1224e1"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("2041a705-48a8-4f4c-bb4c-852f3ffe3b4a"), 0, "Bambino", new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("e3c807c0-e240-4c56-a6a3-9b32fb928f31"), 0, "Vissers", new Guid("7e6be5fb-2524-4b26-b350-48f9e947fe2c"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 15, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("20566b6e-e61d-4889-9dd1-7041f7203034"), 0, "Hazard", new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("33c3daa1-299c-4c30-9980-89dbed58be1f"), 0, "Debruyne", new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 15, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("1591b0c0-305d-4939-af36-26c03c315cc4"), 0, "VanHoof", new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 15, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("fb93bc5d-2357-43d5-aa00-51267db57be4"), 0, "Mega", new Guid("c6aae2d6-c276-4a9b-811a-ca190df1da6a"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 15, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("a67b65d3-1a36-4d0c-88ad-07dafbb5944c"), 0, "Mertens", new Guid("ce7556d5-82cd-47ad-a8f8-501e7fd1f7d3"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 15, "202CB962AC59075B964B07152D234B70", 110, "Evelyne" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"), new Guid("e3c807c0-e240-4c56-a6a3-9b32fb928f31") },
                    { new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"), new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776") },
                    { new Guid("0371212d-7292-40a1-a5b7-a904bebebfc3"), new Guid("e9b1d522-da7e-48e0-a67e-3b532bedb776") },
                    { new Guid("be9603fc-7e3c-48ba-83ad-136caef9dafb"), new Guid("462ba6ff-0b47-4b7d-bcaa-eeb6a96f5faa") },
                    { new Guid("e31b3afb-bbb9-445b-b1b4-e500f2e4edae"), new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa") },
                    { new Guid("e24c574e-3f1e-4732-b7cc-edfca581a3e0"), new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("66379c2d-7961-4d2b-a82b-6ad5f995d3e7"), "Moldava", new Guid("e3c807c0-e240-4c56-a6a3-9b32fb928f31"), "Geel zadel" },
                    { new Guid("fedf3e2c-70ae-4184-92ce-e89a89a9237b"), "Merckx", new Guid("462ba6ff-0b47-4b7d-bcaa-eeb6a96f5faa"), "Oranje zadel" },
                    { new Guid("8e128bd2-b8a2-44f0-8ffa-c92b90ddfc94"), "B-Twin", new Guid("a8bbec33-6a66-4a65-af1a-adfd0d73bafa"), "Zwart zadel" }
                });
        }
    }
}
