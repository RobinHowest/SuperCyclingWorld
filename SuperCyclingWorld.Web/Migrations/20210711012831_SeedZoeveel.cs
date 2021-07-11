using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedZoeveel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("30322374-1319-4b9f-b9f9-e557eedfca40"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6122db57-9544-4efb-935f-7138a1a723d8"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bb6ac65c-2a35-430c-a22e-9b44c07a5d94"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("38e79f1b-104d-4330-bb18-196338b39961"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("43580eb5-2bab-4b18-8ecf-00c36359a390"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("543e6606-6e86-4531-88ca-1d40f53cdbbb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("62d72360-960c-4d7c-9a60-e2e453c20a3a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("925fa4a8-66fa-4a0d-bafb-ffd9a768d00d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a868f236-eb75-4c22-bdc7-df1cd35a0e25"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b1d69ae7-6944-43aa-aa8d-f57119649c9e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c7c50059-733e-400a-baca-05deeda0ee5c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("140bd296-576d-4b4d-9627-c1c3dd8afa52"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("18e49739-f643-49e3-a99f-6aad33d20867"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e6a37ff-fb9c-4cc1-a9b0-d51c2a3f03e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3700bb24-cf66-47ea-b0fb-ee6e8ef15ca0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3b4e80ba-9abb-43d3-8d7c-5aadbcf803e6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("50c9a0a3-5397-4266-a384-d01c0069780a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("63a74f96-11da-4087-b5f1-0dd2e4cce760"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8b0e1450-b57a-4076-a1fc-a3419fa13a94"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a30718a8-9943-485e-ba96-9e9ba37f9340"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a466b2c5-6ee3-4fd5-8a9f-93a537240d3e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a749db73-5685-4ca0-988b-66542f682867"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c97dda4e-fff0-4b35-b676-ea4192768dc7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cc64df3b-3e86-4305-9802-a8d27f92fd32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e7ae4a4c-272b-4c76-a86c-e0471a87ce1f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fdac2b86-3bd7-406b-bdb3-4ab70b232374"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff3989a6-91d0-41c9-966b-268992751ec6"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0e1b3078-48fd-4858-be95-a165893af4fb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("97eae049-a3db-419f-9988-51a025851bdf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), 0, null, "WTC", 2001 },
                    { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), 0, null, "DCTV", 2016 },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("56e2deb8-e339-4b6a-9489-fddfabaa90d3"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("b421fb4f-b832-44ca-81e6-80f0325107f5"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("5e2b777f-ce67-4920-8e9b-b5db09ca9d88"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("7a2c9f6e-dd8a-48f2-805e-f42f791a6af5"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("489127cb-6c93-425b-9a3f-15ee6f3c03c1"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("21135017-d03f-4ff2-825e-84e95da910b7"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("afcc75cc-b658-4714-9a3e-2e2636af02dd"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("e5ac6b8d-3c39-4748-b953-55083e9d7c42"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("a7354a08-18eb-4500-8e65-833275050212") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("a7354a08-18eb-4500-8e65-833275050212") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("02f60061-c2ca-4647-bbed-e2a1bfa45493"), "Debruyne", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("911bc918-dfbb-430d-8728-a919cb838fb5"), "Vanderplas", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("a249de8a-efff-4f75-a241-f8870b4ae98c"), "Camara", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("7a63826a-b3c6-4e7b-8787-1057d46c63b9"), "Van Overmeire", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"), "Vissers", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("c27cc3c9-b1b4-4710-a965-33e7fd8a7446"), "Evenepoel", new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("e3d489ae-ece1-4c9e-bf39-af037295e01b"), "Garnaal", new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("171803c9-62a2-4feb-a3b6-97fcad761ba7"), "Mertens", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("9f96e6ae-80cb-4b54-8dc0-d62202bd1981"), "Beukelaer", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("6f889fab-da8f-478c-b2fb-582e09e8ce85"), "Scarlet", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("4fc0968c-f7f7-466c-a011-183bc5b23122"), "Donckerwolcke", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("8d78d624-d785-4948-b02d-8f6683f59b15"), "Depardieu", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("e88e7fc1-5e91-4e6f-ae04-ca3a8f3d6d59"), "Hazard", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("6c32fc81-0fff-4e3a-b4f6-7995b7ef53fd"), "Zalinski", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("9d45e58b-9023-4205-9cc2-7cb06bbee005"), "VanHoof", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("41cc1054-ea2e-47b5-82f0-1dca727687ff"), "Mega", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"), "Franckaert", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("4e5c5735-90a6-4f20-997a-c63111d81d32"), "Bambino", new Guid("e0b28711-1f52-49b6-a2de-837250874584"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"), "Jansma", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("78d8615c-19eb-4e4b-adaa-6b4a514e0a57"), "Brokkenpap", new Guid("e0b28711-1f52-49b6-a2de-837250874584"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae") },
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") },
                    { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") },
                    { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("95ac02ed-22a0-491e-8fb1-b4f4adb641ce"), "Merckx", new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"), "Oranje zadel" },
                    { new Guid("c17877a5-3f21-4f1e-b1f2-01e73816dc36"), "B-Twin", new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"), "Zwart zadel" },
                    { new Guid("d4fc2144-88c2-40d6-95fb-f9b725e5cf59"), "Moldava", new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("a7354a08-18eb-4500-8e65-833275050212") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("a7354a08-18eb-4500-8e65-833275050212") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("95ac02ed-22a0-491e-8fb1-b4f4adb641ce"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c17877a5-3f21-4f1e-b1f2-01e73816dc36"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d4fc2144-88c2-40d6-95fb-f9b725e5cf59"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("21135017-d03f-4ff2-825e-84e95da910b7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("489127cb-6c93-425b-9a3f-15ee6f3c03c1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("56e2deb8-e339-4b6a-9489-fddfabaa90d3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5e2b777f-ce67-4920-8e9b-b5db09ca9d88"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7a2c9f6e-dd8a-48f2-805e-f42f791a6af5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("afcc75cc-b658-4714-9a3e-2e2636af02dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b421fb4f-b832-44ca-81e6-80f0325107f5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e5ac6b8d-3c39-4748-b953-55083e9d7c42"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("02f60061-c2ca-4647-bbed-e2a1bfa45493"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("171803c9-62a2-4feb-a3b6-97fcad761ba7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41cc1054-ea2e-47b5-82f0-1dca727687ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4e5c5735-90a6-4f20-997a-c63111d81d32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4fc0968c-f7f7-466c-a011-183bc5b23122"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6c32fc81-0fff-4e3a-b4f6-7995b7ef53fd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6f889fab-da8f-478c-b2fb-582e09e8ce85"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("78d8615c-19eb-4e4b-adaa-6b4a514e0a57"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7a63826a-b3c6-4e7b-8787-1057d46c63b9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("911bc918-dfbb-430d-8728-a919cb838fb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d45e58b-9023-4205-9cc2-7cb06bbee005"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9f96e6ae-80cb-4b54-8dc0-d62202bd1981"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a249de8a-efff-4f75-a241-f8870b4ae98c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c27cc3c9-b1b4-4710-a965-33e7fd8a7446"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e3d489ae-ece1-4c9e-bf39-af037295e01b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e88e7fc1-5e91-4e6f-ae04-ca3a8f3d6d59"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e0b28711-1f52-49b6-a2de-837250874584"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a7354a08-18eb-4500-8e65-833275050212"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8d78d624-d785-4948-b02d-8f6683f59b15"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d6f03a52-053a-425a-b951-54080673b3d2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), 0, null, "WTC", 2001 },
                    { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), 0, null, "DCTV", 2016 },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c7c50059-733e-400a-baca-05deeda0ee5c"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("925fa4a8-66fa-4a0d-bafb-ffd9a768d00d"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("543e6606-6e86-4531-88ca-1d40f53cdbbb"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("b1d69ae7-6944-43aa-aa8d-f57119649c9e"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("62d72360-960c-4d7c-9a60-e2e453c20a3a"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("43580eb5-2bab-4b18-8ecf-00c36359a390"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("a868f236-eb75-4c22-bdc7-df1cd35a0e25"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("38e79f1b-104d-4330-bb18-196338b39961"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") },
                    { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("a749db73-5685-4ca0-988b-66542f682867"), "Hazard", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("a466b2c5-6ee3-4fd5-8a9f-93a537240d3e"), "Debruyne", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("140bd296-576d-4b4d-9627-c1c3dd8afa52"), "Garnaal", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("1e6a37ff-fb9c-4cc1-a9b0-d51c2a3f03e2"), "Donckerwolcke", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("0e1b3078-48fd-4858-be95-a165893af4fb"), "Depardieu", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("ff3989a6-91d0-41c9-966b-268992751ec6"), "Evenepoel", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"), "Vissers", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("cc64df3b-3e86-4305-9802-a8d27f92fd32"), "Zalinski", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("e7ae4a4c-272b-4c76-a86c-e0471a87ce1f"), "VanHoof", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("fdac2b86-3bd7-406b-bdb3-4ab70b232374"), "Beukelaer", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("3700bb24-cf66-47ea-b0fb-ee6e8ef15ca0"), "Brokkenpap", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"), "Franckaert", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("18e49739-f643-49e3-a99f-6aad33d20867"), "Mertens", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("a30718a8-9943-485e-ba96-9e9ba37f9340"), "Scarlet", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("97eae049-a3db-419f-9988-51a025851bdf"), "Jansma", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("3b4e80ba-9abb-43d3-8d7c-5aadbcf803e6"), "Bambino", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("63a74f96-11da-4087-b5f1-0dd2e4cce760"), "Mega", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("8b0e1450-b57a-4076-a1fc-a3419fa13a94"), "Camara", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("50c9a0a3-5397-4266-a384-d01c0069780a"), "Vanderplas", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("c97dda4e-fff0-4b35-b676-ea4192768dc7"), "Van Overmeire", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") },
                    { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa") },
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2") },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") },
                    { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("30322374-1319-4b9f-b9f9-e557eedfca40"), "B-Twin", new Guid("97eae049-a3db-419f-9988-51a025851bdf"), "Zwart zadel" },
                    { new Guid("bb6ac65c-2a35-430c-a22e-9b44c07a5d94"), "Merckx", new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"), "Oranje zadel" },
                    { new Guid("6122db57-9544-4efb-935f-7138a1a723d8"), "Moldava", new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"), "Geel zadel" }
                });
        }
    }
}
