using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class DeleteRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("45521d10-d277-43c9-bc3a-6244685c9a09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("66da1773-c553-4450-9747-d75a68cc1dee") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0e97e06b-854b-4e55-b4cb-0b460e0c8fa1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("669910d8-9f60-432a-acad-2b99145ccb30"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("893c64b8-ab56-4e76-8cb3-5242081a8f79"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("014e4a0f-099c-4cf7-8652-1ae9fadd53ca"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1bc6f599-920e-418e-99b6-1864df2f0c31"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25707fbf-fc3d-4dbc-9013-6a6e1069c1bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6d704bd7-de74-4bb5-8afc-2ac0da45cf23"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("71947fce-cada-4255-b823-819808d8a2d1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c1756a14-52d0-4eca-a6fd-8e6c4254ec9a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d89c56f3-b490-40c0-b86f-61e8cec16946"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dccae4d8-f77f-47c7-b175-e75532eb9b18"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e0a59b4-ccfb-4248-be73-2ba20811626e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e7c806f-d68b-4c05-ab51-8512eca34705"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("247493d4-ea61-444b-add0-0eccaa9c0363"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("26d315d0-c4c0-43de-91fc-ee6a2c4a89e9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("53385228-5f07-4850-a42b-bb00f55a554c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6808250e-d1c1-4908-86bf-30e3fc279ce8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6afff5e4-b757-4958-b8f2-d174a1896226"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("749a8780-6a86-4d26-bdd9-fed2ae7e46f7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7850aecd-ca8e-4d6d-ae73-548f581a6431"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("824d5ced-ab37-4a7e-bcc6-061e22d4a326"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0316ff8-babf-4fd1-be40-d988084b5f01"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d10fa0eb-7794-40ea-9b06-68ac7dbe36be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d30689d3-ce1a-40cf-8c55-f2ad17964ff3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f020bee2-8a96-47c7-b7ea-7892bf879151"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0fa4b67-9704-4f79-b9b0-980644351d3a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f127495c-7b37-4904-8aee-ecaa999ca04c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4506204b-01db-4f86-aa36-94beb740c624"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c699b52-ff83-481e-8f70-215611ca4607"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("66da1773-c553-4450-9747-d75a68cc1dee"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), 0, null, "WTC", 2001 },
                    { new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), 0, null, "DCTV", 2016 },
                    { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("07375b42-f5a1-420d-904b-fd3b72565f1b"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("d91e2d71-ef8d-4b38-bf03-e1794fa55c6d"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("adfeb553-fb85-48c7-a36e-efda86f72a16"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("c2690ac2-b995-47fa-bde8-7c473d45e8be"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("f79b1274-ef23-4764-a27b-d234ae2485ae"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("85ced6bb-753f-4881-a612-1cba2432732b"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("b7edf08b-d95e-467e-946e-7f16caba7085"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("4d785b2a-0ee7-4bd3-aefe-5a2254cc1909"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c") },
                    { new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc") },
                    { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f") },
                    { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f") },
                    { new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") },
                    { new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") },
                    { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") },
                    { new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") },
                    { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") },
                    { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1b42258a-6153-4f52-becd-bc24501969fa"), 0, "Vanderplas", new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("cbfc0c9c-3970-4fe6-b71f-a3c3589d18e2"), 0, "VanHoof", new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("ef9d6d88-8b60-4d0e-9cf8-6686653602db"), 0, "Scarlet", new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("bb8043a5-02dc-46c6-96e8-62e9b1ddcf0c"), 0, "Van Overmeire", new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("739d540b-c5b9-4837-8721-913b75690502"), 0, "Depardieu", new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("fb06e824-978b-46c1-b073-0c8a56cce9aa"), 0, "Debruyne", new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("6b579f52-aa6f-4a95-9dc9-cd28715ac66a"), 0, "Donckerwolcke", new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("b949ba6e-9e79-48dc-9ef4-58346f267b37"), 0, "Franckaert", new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" },
                    { new Guid("ddddb845-3da6-47e7-b5f9-e3460afa8b67"), 0, "Evenepoel", new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("f4cbc992-918f-4d04-9e6e-ca945b2af233"), 0, "Beukelaer", new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("a1e66ff2-f1cd-4759-8e64-f834dd01c5fc"), 0, "Zalinski", new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("3f5b9b6d-f913-4f69-8675-90ab882cc75a"), 0, "Bambino", new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("2a7223a2-966a-4418-85f7-d6ed8e2ac5d0"), 0, "Mertens", new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("e19441e2-5a9f-4b1a-acbe-e11ed7f79699"), 0, "Garnaal", new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("0a212abb-68b7-44f8-86f2-422c6d92c6fd"), 0, "Hazard", new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("03eeead8-afd3-494d-8c68-273d44aaa322"), 0, "Mega", new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("c58af35b-2a32-4fac-99eb-d3b7b4bddfe7"), 0, "Camara", new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("74c8e015-c1a9-4e0e-8518-64619cb4cd11"), 0, "Vissers", new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("a9002818-d68c-4fc3-801e-b97fe837e4ce"), 0, "Brokkenpap", new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73"), 0, "Jansma", new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"), new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73") },
                    { new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f"), new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73") },
                    { new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"), new Guid("74c8e015-c1a9-4e0e-8518-64619cb4cd11") },
                    { new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"), new Guid("b949ba6e-9e79-48dc-9ef4-58346f267b37") },
                    { new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"), new Guid("739d540b-c5b9-4837-8721-913b75690502") },
                    { new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc"), new Guid("739d540b-c5b9-4837-8721-913b75690502") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("cd91aaba-58ff-4ebc-9ec4-33c234fd8e56"), "B-Twin", new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73"), "Zwart zadel" },
                    { new Guid("47f26699-7bf0-432f-ac7d-75f4f82a26b2"), "Moldava", new Guid("74c8e015-c1a9-4e0e-8518-64619cb4cd11"), "Geel zadel" },
                    { new Guid("afa16533-151f-4cac-b31f-b667b0009781"), "Merckx", new Guid("b949ba6e-9e79-48dc-9ef4-58346f267b37"), "Oranje zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"), new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"), new Guid("739d540b-c5b9-4837-8721-913b75690502") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"), new Guid("b949ba6e-9e79-48dc-9ef4-58346f267b37") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f"), new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc"), new Guid("739d540b-c5b9-4837-8721-913b75690502") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"), new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"), new Guid("74c8e015-c1a9-4e0e-8518-64619cb4cd11") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("47f26699-7bf0-432f-ac7d-75f4f82a26b2"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("afa16533-151f-4cac-b31f-b667b0009781"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("cd91aaba-58ff-4ebc-9ec4-33c234fd8e56"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("07375b42-f5a1-420d-904b-fd3b72565f1b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4d785b2a-0ee7-4bd3-aefe-5a2254cc1909"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("85ced6bb-753f-4881-a612-1cba2432732b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("adfeb553-fb85-48c7-a36e-efda86f72a16"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b7edf08b-d95e-467e-946e-7f16caba7085"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c2690ac2-b995-47fa-bde8-7c473d45e8be"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d91e2d71-ef8d-4b38-bf03-e1794fa55c6d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f79b1274-ef23-4764-a27b-d234ae2485ae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("03eeead8-afd3-494d-8c68-273d44aaa322"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0a212abb-68b7-44f8-86f2-422c6d92c6fd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1b42258a-6153-4f52-becd-bc24501969fa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2a7223a2-966a-4418-85f7-d6ed8e2ac5d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3f5b9b6d-f913-4f69-8675-90ab882cc75a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b579f52-aa6f-4a95-9dc9-cd28715ac66a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a1e66ff2-f1cd-4759-8e64-f834dd01c5fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a9002818-d68c-4fc3-801e-b97fe837e4ce"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bb8043a5-02dc-46c6-96e8-62e9b1ddcf0c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c58af35b-2a32-4fac-99eb-d3b7b4bddfe7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cbfc0c9c-3970-4fe6-b71f-a3c3589d18e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ddddb845-3da6-47e7-b5f9-e3460afa8b67"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e19441e2-5a9f-4b1a-acbe-e11ed7f79699"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef9d6d88-8b60-4d0e-9cf8-6686653602db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f4cbc992-918f-4d04-9e6e-ca945b2af233"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb06e824-978b-46c1-b073-0c8a56cce9aa"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("134c7073-1f82-47b5-a978-b4190c18ed7a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4eb7f386-4314-482e-8855-c6cda70a378b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2423fc44-3ac8-4263-b582-5a4311ff6b5c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2f115f50-a9eb-4ca4-90fd-9bc72f87125f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9127e741-90fb-4c4b-861d-3e1b896122fc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("edae2dbb-bd78-494b-b157-65447e3e9d64"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7174dbea-428a-4129-9bf4-6d9a218c7b73"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("739d540b-c5b9-4837-8721-913b75690502"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("74c8e015-c1a9-4e0e-8518-64619cb4cd11"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b949ba6e-9e79-48dc-9ef4-58346f267b37"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b5e2b918-d793-46e9-95dd-835dc8c23694"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f4403d52-3a91-4fb6-9d43-915c60652737"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f6457a79-9c5e-49e1-84f1-3412edbfee9e"));

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecordCijfer = table.Column<int>(nullable: false),
                    RecordEenheid = table.Column<string>(nullable: true),
                    RecordType = table.Column<int>(nullable: false),
                    Recordnaam = table.Column<string>(nullable: true),
                    Thropy = table.Column<string>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), 0, null, "WTC", 2001 },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), 0, null, "DCTV", 2016 },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1bc6f599-920e-418e-99b6-1864df2f0c31"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("c1756a14-52d0-4eca-a6fd-8e6c4254ec9a"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("6d704bd7-de74-4bb5-8afc-2ac0da45cf23"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("25707fbf-fc3d-4dbc-9013-6a6e1069c1bd"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("014e4a0f-099c-4cf7-8652-1ae9fadd53ca"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("dccae4d8-f77f-47c7-b175-e75532eb9b18"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d89c56f3-b490-40c0-b86f-61e8cec16946"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("71947fce-cada-4255-b823-819808d8a2d1"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1") },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") },
                    { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1e7c806f-d68b-4c05-ab51-8512eca34705"), 0, "Zalinski", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("7850aecd-ca8e-4d6d-ae73-548f581a6431"), 0, "Bambino", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("26d315d0-c4c0-43de-91fc-ee6a2c4a89e9"), 0, "Mertens", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("d30689d3-ce1a-40cf-8c55-f2ad17964ff3"), 0, "Evenepoel", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("f127495c-7b37-4904-8aee-ecaa999ca04c"), 0, "Hazard", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("f0fa4b67-9704-4f79-b9b0-980644351d3a"), 0, "Beukelaer", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("66da1773-c553-4450-9747-d75a68cc1dee"), 0, "Franckaert", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" },
                    { new Guid("6808250e-d1c1-4908-86bf-30e3fc279ce8"), 0, "Debruyne", new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("2c699b52-ff83-481e-8f70-215611ca4607"), 0, "Jansma", new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("247493d4-ea61-444b-add0-0eccaa9c0363"), 0, "Vanderplas", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("6afff5e4-b757-4958-b8f2-d174a1896226"), 0, "VanHoof", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("749a8780-6a86-4d26-bdd9-fed2ae7e46f7"), 0, "Mega", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("53385228-5f07-4850-a42b-bb00f55a554c"), 0, "Brokkenpap", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("a0316ff8-babf-4fd1-be40-d988084b5f01"), 0, "Garnaal", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("824d5ced-ab37-4a7e-bcc6-061e22d4a326"), 0, "Donckerwolcke", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42"), 0, "Depardieu", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("d10fa0eb-7794-40ea-9b06-68ac7dbe36be"), 0, "Scarlet", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("f020bee2-8a96-47c7-b7ea-7892bf879151"), 0, "Camara", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("1e0a59b4-ccfb-4248-be73-2ba20811626e"), 0, "Van Overmeire", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"), 0, "Vissers", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("45521d10-d277-43c9-bc3a-6244685c9a09") },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") },
                    { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") },
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") },
                    { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("66da1773-c553-4450-9747-d75a68cc1dee") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("893c64b8-ab56-4e76-8cb3-5242081a8f79"), "Moldava", new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"), "Geel zadel" },
                    { new Guid("0e97e06b-854b-4e55-b4cb-0b460e0c8fa1"), "B-Twin", new Guid("2c699b52-ff83-481e-8f70-215611ca4607"), "Zwart zadel" },
                    { new Guid("669910d8-9f60-432a-acad-2b99145ccb30"), "Merckx", new Guid("66da1773-c553-4450-9747-d75a68cc1dee"), "Oranje zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_WielrennerId",
                table: "Records",
                column: "WielrennerId");
        }
    }
}
