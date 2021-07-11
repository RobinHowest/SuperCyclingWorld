using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddLittletestSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("58470357-c242-446e-8dff-4bdf9c83a42c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bae1b48a-4252-45fc-8c81-069e92858774"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c14722c5-07af-43e4-8aaf-d5f3bc8faa95"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c79d26da-d34c-41b8-9016-8584f47ebcda"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("04e39160-eba3-4a73-b64f-354f301dbe8a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("67b57944-7889-4e2f-9caf-8d90a201881d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7129dce8-2512-44f4-81fe-645b32bf3aae"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("76efa838-c80f-4728-90bd-508670e1ffbf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("92baf6f3-a96a-424f-9c3b-6f417bb56322"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9b06436e-bc3a-4513-b472-738af1ecb252"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ed9c6fa3-c097-4bba-9746-eec97166446e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ee287df7-e81a-4cd2-a489-09027473f59f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("00eeeb2b-a733-4294-8bf4-c86a80e1a3be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04af8132-644e-42ce-922b-64e0e44843d8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0634ce45-8b83-4b96-be60-7651c709547b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0a56518b-abbb-46de-a33a-aac3557e08df"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("17f26329-c361-4732-9f12-c3c005e09538"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("206a866c-4b63-4a5a-8b21-e73e06c0b974"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("251a755e-8bda-4015-b14c-80a425b89f0b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("382d98d2-52ae-4ee4-be1f-a4a0977e898f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3eac50db-3fe5-474e-b2d9-791818ac85a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("40ebb97c-94c1-4482-afa3-4ec4379054d6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("77f2b596-ed80-49c7-9a15-8e764d01db63"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ca7d2a38-2650-4c6a-a3d5-3e1aeea8653f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cd5e5c4f-08e7-40e7-904e-1a3deaf6f64f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("db54d54d-0da3-4655-9c52-6429a7a85395"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0f5a076-5386-4103-8c7d-df44b0b589a4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f2537ae5-9070-4f84-af99-4f90fd927029"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2e2c8704-567f-44db-a674-26649a31e243"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a407a370-dbcc-4a82-af8d-9af308512d09"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("0378a453-4956-411c-aea7-54191c451f92"), null, null, "WTC", 2001 },
                    { new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), null, null, "DCTV", 2016 },
                    { new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), null, null, "De lustige rijders", 1991 },
                    { new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), null, null, "WTC Melsele", 1966 },
                    { new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), null, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("65422f61-b22c-4a3f-98bb-b671e021a395"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("deea0c39-af39-488a-b144-c26f5ed11fd6"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("05d5ea01-b939-4411-bfb9-3cb9b4c46a97"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("d58d34ac-b86b-48d2-8148-42e4383e145e"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("c7746fd1-0799-4db0-a13b-59e36238281e"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("7edba17c-47c7-4620-b809-422769a49a1c"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("4aec9698-5ebb-46da-8390-90809fe559ad"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("522e6750-b633-49c2-91dd-94d482c71859"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") },
                    { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") },
                    { new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") },
                    { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") },
                    { new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") },
                    { new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") },
                    { new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") },
                    { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") },
                    { new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("438d4900-e5f2-4f56-8bba-04b7dd607a0a"), "Vanderplas", new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("a49f80d8-5c41-41d4-aafe-4454378f807f"), "Brokkenpap", new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("ba889c8c-c077-4fe7-8ba3-13e5125bca1e"), "Donckerwolcke", new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7"), "Vissers", new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324"), "Franckaert", new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("767da5e0-0365-43f2-ad4f-dd285c88390d"), "Hazard", new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("9fc5d982-8b33-4fd0-8491-49c625c614b8"), "Mega", new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("aa512496-b3c9-4bd5-90ae-aeb12dcd057c"), "Garnaal", new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("f2e8d257-7b1a-440d-98dd-9199bd0d9d29"), "Camara", new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("2e690940-487f-43a3-b63e-ad189d08c076"), "Debruyne", new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("c7e28bb1-8de0-46e7-88ae-7e9ff86a77a4"), "Zalinski", new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("407d181a-d15f-4bc7-b35f-ed6b75da5fd8"), "Bambino", new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("cd3532c0-807a-448e-bb70-22c664947f98"), "VanHoof", new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("9b92f185-02da-4038-827b-a187b3b07ddb"), "Beukelaer", new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("3f5422a5-5292-4f9d-a3a8-345cd5bfdeec"), "Mertens", new Guid("0378a453-4956-411c-aea7-54191c451f92"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("59cffb08-b174-4c6c-a2db-cf56ea69fb2d"), "Scarlet", new Guid("0378a453-4956-411c-aea7-54191c451f92"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("86bab186-f158-4342-9b21-e1d1305dce13"), "Van Overmeire", new Guid("0378a453-4956-411c-aea7-54191c451f92"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702"), "Depardieu", new Guid("0378a453-4956-411c-aea7-54191c451f92"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("f07f2aa0-ac20-4116-8273-4e8f30ba9c52"), "Evenepoel", new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9"), "Jansma", new Guid("0378a453-4956-411c-aea7-54191c451f92"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") },
                    { new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"), new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") },
                    { new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") },
                    { new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"), new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") },
                    { new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324") },
                    { new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("521495c3-204b-4aa0-bbac-8c1ba7ee3dc2"), "B-Twin", new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9"), "Zwart zadel" },
                    { new Guid("4c124ace-f7d0-4abe-9f03-5b9497648150"), "Merckx", new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324"), "Oranje zadel" },
                    { new Guid("df4bafa4-de7d-4059-bce1-d531a3200610"), "Moldava", new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0378a453-4956-411c-aea7-54191c451f92"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"), new Guid("0f21a72a-3f99-44c9-8922-e0102b607037") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"), new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"), new Guid("d3cdd545-e39f-4c35-a09a-51b525835765") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"), new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"), new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"), new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"), new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("4c124ace-f7d0-4abe-9f03-5b9497648150"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("521495c3-204b-4aa0-bbac-8c1ba7ee3dc2"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("df4bafa4-de7d-4059-bce1-d531a3200610"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("05d5ea01-b939-4411-bfb9-3cb9b4c46a97"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4aec9698-5ebb-46da-8390-90809fe559ad"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("522e6750-b633-49c2-91dd-94d482c71859"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("65422f61-b22c-4a3f-98bb-b671e021a395"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7edba17c-47c7-4620-b809-422769a49a1c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c7746fd1-0799-4db0-a13b-59e36238281e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d58d34ac-b86b-48d2-8148-42e4383e145e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("deea0c39-af39-488a-b144-c26f5ed11fd6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2e690940-487f-43a3-b63e-ad189d08c076"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3f5422a5-5292-4f9d-a3a8-345cd5bfdeec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("407d181a-d15f-4bc7-b35f-ed6b75da5fd8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("438d4900-e5f2-4f56-8bba-04b7dd607a0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("59cffb08-b174-4c6c-a2db-cf56ea69fb2d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("767da5e0-0365-43f2-ad4f-dd285c88390d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("86bab186-f158-4342-9b21-e1d1305dce13"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9b92f185-02da-4038-827b-a187b3b07ddb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9fc5d982-8b33-4fd0-8491-49c625c614b8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a49f80d8-5c41-41d4-aafe-4454378f807f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("aa512496-b3c9-4bd5-90ae-aeb12dcd057c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ba889c8c-c077-4fe7-8ba3-13e5125bca1e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7e28bb1-8de0-46e7-88ae-7e9ff86a77a4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cd3532c0-807a-448e-bb70-22c664947f98"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f07f2aa0-ac20-4116-8273-4e8f30ba9c52"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f2e8d257-7b1a-440d-98dd-9199bd0d9d29"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("92f87c01-8ccc-40d6-8976-86ca284397da"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a4326088-75cb-4096-bb09-fb50363c5d66"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bb914c08-c29d-4782-8f9a-6fd1b85a4a4b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0f21a72a-3f99-44c9-8922-e0102b607037"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8e8c43d2-4a61-4ad4-b3ec-a61407e5459d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bc98a60a-f266-4913-8d09-a9ee33a60f2c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d3cdd545-e39f-4c35-a09a-51b525835765"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("01e13245-36a4-4f22-a1f6-1cffc1b0a702"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("af9dca0e-e34c-4298-8310-474e4c39b3c9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec542734-b4ec-41fc-8d88-af9612bb1324"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fd69b614-a93c-47d9-8325-9f69258bd2e7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0378a453-4956-411c-aea7-54191c451f92"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f0e04146-7698-4392-b458-b8fa161e9ba6"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), null, null, "WTC", 2001 },
                    { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), null, null, "DCTV", 2016 },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), null, null, "De lustige rijders", 1991 },
                    { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), null, null, "WTC Melsele", 1966 },
                    { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), null, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("9b06436e-bc3a-4513-b472-738af1ecb252"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("7129dce8-2512-44f4-81fe-645b32bf3aae"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("67b57944-7889-4e2f-9caf-8d90a201881d"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("ee287df7-e81a-4cd2-a489-09027473f59f"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("92baf6f3-a96a-424f-9c3b-6f417bb56322"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("04e39160-eba3-4a73-b64f-354f301dbe8a"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("76efa838-c80f-4728-90bd-508670e1ffbf"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("ed9c6fa3-c097-4bba-9746-eec97166446e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") },
                    { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") },
                    { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("f2537ae5-9070-4f84-af99-4f90fd927029"), "Evenepoel", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("0a56518b-abbb-46de-a33a-aac3557e08df"), "Zalinski", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("206a866c-4b63-4a5a-8b21-e73e06c0b974"), "Beukelaer", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("17f26329-c361-4732-9f12-c3c005e09538"), "Mega", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("00eeeb2b-a733-4294-8bf4-c86a80e1a3be"), "Brokkenpap", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("04af8132-644e-42ce-922b-64e0e44843d8"), "Garnaal", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("3eac50db-3fe5-474e-b2d9-791818ac85a2"), "Bambino", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("db54d54d-0da3-4655-9c52-6429a7a85395"), "Donckerwolcke", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("0634ce45-8b83-4b96-be60-7651c709547b"), "Camara", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("77f2b596-ed80-49c7-9a15-8e764d01db63"), "Van Overmeire", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("a407a370-dbcc-4a82-af8d-9af308512d09"), "Depardieu", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"), "Jansma", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"), "Franckaert", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("f0f5a076-5386-4103-8c7d-df44b0b589a4"), "Debruyne", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("40ebb97c-94c1-4482-afa3-4ec4379054d6"), "Mertens", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"), "Vissers", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("382d98d2-52ae-4ee4-be1f-a4a0977e898f"), "Hazard", new Guid("2e2c8704-567f-44db-a674-26649a31e243"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("cd5e5c4f-08e7-40e7-904e-1a3deaf6f64f"), "Scarlet", new Guid("2e2c8704-567f-44db-a674-26649a31e243"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("ca7d2a38-2650-4c6a-a3d5-3e1aeea8653f"), "Vanderplas", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("251a755e-8bda-4015-b14c-80a425b89f0b"), "VanHoof", new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("58470357-c242-446e-8dff-4bdf9c83a42c") },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f") },
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") },
                    { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") },
                    { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("c14722c5-07af-43e4-8aaf-d5f3bc8faa95"), "Moldava", new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"), "Geel zadel" },
                    { new Guid("c79d26da-d34c-41b8-9016-8584f47ebcda"), "Merckx", new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"), "Oranje zadel" },
                    { new Guid("bae1b48a-4252-45fc-8c81-069e92858774"), "B-Twin", new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"), "Zwart zadel" }
                });
        }
    }
}
