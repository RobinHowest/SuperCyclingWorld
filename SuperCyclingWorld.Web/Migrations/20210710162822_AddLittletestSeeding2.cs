using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddLittletestSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), null, null, "WTC", 2001 },
                    { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), null, null, "DCTV", 2016 },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), null, null, "De lustige rijders", 1991 },
                    { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), null, null, "WTC Melsele", 1966 },
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), null, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("97de10eb-c741-4956-9119-8d5ccd34e576"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("3f916b16-54f7-4d6d-b484-507783da5853"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("c2776fd7-6e6f-4009-ad20-05595cd3a2f4"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("9a2745be-bd0b-4137-80dc-6a8c08ea7e6b"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("a1bed1fd-37ee-4a66-bf6c-fef4a5ef92d6"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("0676c2c1-995c-42a7-a0a3-970a60826be8"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("dd4a15e9-10c7-4423-8c46-cdb3f7a63dc0"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("45ed9e4c-0f85-4a36-84d4-ce790dc97084"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") },
                    { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") },
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("2e19af0f-3289-4c8c-b7cb-5b14d086f043"), "Debruyne", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("4c4195a5-e2a3-46e7-aa6d-1e5625946d0f"), "Garnaal", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"), "Vissers", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("0c51e230-8741-4e89-8e53-00b21dbce485"), "Zalinski", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("f90da381-77b3-4e97-a9df-25af2ae9a34a"), "Vanderplas", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("41537fea-3945-4f3f-973f-71c193e15f7f"), "VanHoof", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("ef8e14df-2e22-4ef3-a729-396b054cbaaa"), "Beukelaer", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("6df7252b-b702-4d9c-93c7-8fd34ff98dcf"), "Donckerwolcke", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("6cee4373-2ca7-4d67-80fe-14e61fa4f526"), "Evenepoel", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("b8f6b1d3-1793-46ad-b2da-4bedee397e7e"), "Scarlet", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("af34b235-9552-474f-b3ae-14195f68ed7d"), "Van Overmeire", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61"), "Depardieu", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("448fa4bd-1980-4966-ac23-33b7d14cf71f"), "Hazard", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("cb0b938e-a0d7-4626-96ef-a68d4ce34f1c"), "Mega", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"), "Jansma", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"), "Franckaert", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("679bbd72-87e8-4fd3-90c4-553444ec0f11"), "Bambino", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("5d05e90c-eeb0-458c-9e24-ca5a8d7fd460"), "Brokkenpap", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("92931377-a9c9-437c-8a24-11ad1dea5208"), "Mertens", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("d88b53ed-bc61-4ecf-97e5-cc3b919f310a"), "Camara", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2") },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") },
                    { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") },
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") },
                    { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("f8162a50-8e22-48b6-b0ea-ffcef4274c28"), "Merckx", new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"), "Oranje zadel" },
                    { new Guid("c6c0344d-9fce-44da-91de-7f7278f9eb4b"), "B-Twin", new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"), "Zwart zadel" },
                    { new Guid("d588a55b-8024-4e60-a0da-c994c2f0d53e"), "Moldava", new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c6c0344d-9fce-44da-91de-7f7278f9eb4b"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d588a55b-8024-4e60-a0da-c994c2f0d53e"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f8162a50-8e22-48b6-b0ea-ffcef4274c28"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0676c2c1-995c-42a7-a0a3-970a60826be8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3f916b16-54f7-4d6d-b484-507783da5853"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("45ed9e4c-0f85-4a36-84d4-ce790dc97084"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("97de10eb-c741-4956-9119-8d5ccd34e576"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9a2745be-bd0b-4137-80dc-6a8c08ea7e6b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a1bed1fd-37ee-4a66-bf6c-fef4a5ef92d6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c2776fd7-6e6f-4009-ad20-05595cd3a2f4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dd4a15e9-10c7-4423-8c46-cdb3f7a63dc0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c51e230-8741-4e89-8e53-00b21dbce485"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2e19af0f-3289-4c8c-b7cb-5b14d086f043"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41537fea-3945-4f3f-973f-71c193e15f7f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("448fa4bd-1980-4966-ac23-33b7d14cf71f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4c4195a5-e2a3-46e7-aa6d-1e5625946d0f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5d05e90c-eeb0-458c-9e24-ca5a8d7fd460"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("679bbd72-87e8-4fd3-90c4-553444ec0f11"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6cee4373-2ca7-4d67-80fe-14e61fa4f526"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6df7252b-b702-4d9c-93c7-8fd34ff98dcf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("92931377-a9c9-437c-8a24-11ad1dea5208"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("af34b235-9552-474f-b3ae-14195f68ed7d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b8f6b1d3-1793-46ad-b2da-4bedee397e7e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cb0b938e-a0d7-4626-96ef-a68d4ce34f1c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d88b53ed-bc61-4ecf-97e5-cc3b919f310a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef8e14df-2e22-4ef3-a729-396b054cbaaa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f90da381-77b3-4e97-a9df-25af2ae9a34a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4970a64d-32d6-49a1-9f79-18556310f440"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("82234998-22b7-4f4b-8108-d7dea256d508"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"));

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
    }
}
