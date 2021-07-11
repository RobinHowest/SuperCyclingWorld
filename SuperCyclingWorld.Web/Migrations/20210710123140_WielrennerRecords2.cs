using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class WielrennerRecords2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WielrennerRecords_Record_RecordId",
                table: "WielrennerRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Record",
                table: "Record");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("922f07e7-5239-4626-a6d0-0df059231bfa"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("99061927-f768-4d86-b5e1-b66d8a6dedb1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("a8b0834e-5e9b-4804-8887-684ba4b5bef1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("097a08ed-4c10-4b5a-8257-90ff8c7442bb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0f1c2d6d-18ca-4cf5-8f1c-ab1008abb023"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("13c6d9e6-db14-4424-8977-0f2fdbb2972b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1bea80c7-941c-444b-91af-eb9fd9f6262a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("22515542-1fa1-4dd2-b5e0-8d13e0933f8c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("429b606e-78b0-43e8-bed4-5c9360805eb2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7e9bac83-be9e-4c80-ba30-a3b6a05b4238"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cfdc0a9b-146c-431d-856c-6082756341d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("13bfbcb7-b5eb-429d-9dcc-bcd23f951847"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("32aa830f-acaa-448e-a31a-acf3b62bf2b2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("343c422e-79d3-4cdf-83c2-1f9bdc06b2db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3b91dc4c-e965-4c60-a276-3eebb3b22aaf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3f840b58-310a-4584-a47b-6d967339280b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41bf269d-5cdd-4961-9c7a-cb10bed065b6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("60ba045e-9c5c-4221-bba9-38ca1f1d4ab0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("691c388c-aed4-4b21-a0bd-82da980fa6ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72764d21-0f0c-49b0-9138-e0697b5305af"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("973a8a73-ba2f-460a-85c8-dbb7dceb7cb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c4448a46-dc96-4d59-a14a-fa4f178aefe1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c9c46416-1337-48fb-aeab-88ba6db2bb8c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d192323a-38af-44c3-b8dd-b7b84571ebc3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d48a8bd2-e377-43eb-b843-54e8ee4bc3b7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f7da1553-d0b5-4c68-ae5f-ff88b8f7213a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fafab49e-a3be-4ddd-b5d9-23b94017c4b8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eb397a64-2044-46a5-b044-993e052dbe21"));

            migrationBuilder.RenameTable(
                name: "Record",
                newName: "Records");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), null, "WTC", 2001 },
                    { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), null, "DCTV", 2016 },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), null, "De lustige rijders", 1991 },
                    { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), null, "WTC Melsele", 1966 },
                    { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("3df57f63-fb85-4311-9938-017afa6604b9"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("fe200d2e-e039-4b99-80ae-0df22e33602a"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("d24364df-ad04-4e8e-aec8-5c67554a4bb2"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("a966c410-01de-473e-89f8-1940dfa29a78"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("62d0725e-9a69-409b-8c50-eae1631af0dd"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("a2fdf7ed-f4d8-470a-b32c-9d8d2aa32a6d"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("a0edf372-2381-466e-bc06-ff41640b4627"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("d44a7aab-23ff-4db7-b1e7-5b6a3ffb823b"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") },
                    { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                    { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("7bae6c19-27c7-4149-8f18-36f7febd4e4c"), "Mertens", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("d011c3c6-bdc4-42fa-97a1-58170066c8ea"), "Beukelaer", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145"), "Depardieu", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("01190cdb-8a84-4909-9b0f-0e8dc26ba267"), "Scarlet", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("f9025da7-1cd1-4381-a2c7-d3b2a486a2c7"), "Brokkenpap", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), "Jansma", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), "Franckaert", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("b37db182-678a-434a-9c9c-e73d7bb87b7b"), "Bambino", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("37db1132-88d6-4209-9833-2fa52f28028b"), "Garnaal", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), "Vissers", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("79d93d2a-3c5c-449e-9102-56357ec9d2dd"), "Debruyne", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("06b84abc-6885-4d75-b5fc-a9749a583530"), "Mega", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("c0d47a62-8883-4fa1-968b-0e0d55959915"), "Donckerwolcke", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("2d863a91-c79a-42e6-b602-0e126b77670a"), "Van Overmeire", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("201f464e-54e8-4fd1-ba1c-e0c686f4ff98"), "Hazard", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("d28ee37e-bb2e-41d2-b64e-7445a754ca0b"), "Zalinski", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("2027e6ab-8786-4766-8d11-3e69b98ba33e"), "Vanderplas", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("ddcc2560-cd0d-4fec-bf8d-15de297bc939"), "VanHoof", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("19099198-5b87-448b-8d5c-f1b8ba606184"), "Evenepoel", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("be75615a-2a6e-4e53-a405-f6028f072713"), "Camara", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951") },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9") },
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                    { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") },
                    { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("d2a1e7b5-f11f-4bfe-9158-9a4ef54581b8"), "Moldava", new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), "Geel zadel" },
                    { new Guid("0d954ef3-8e8c-4c13-8ace-bd9d0744898d"), "Merckx", new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), "Oranje zadel" },
                    { new Guid("9c23eec8-80ec-4ec8-a12a-5b459e8c7ce3"), "B-Twin", new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), "Zwart zadel" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WielrennerRecords_Records_RecordId",
                table: "WielrennerRecords",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WielrennerRecords_Records_RecordId",
                table: "WielrennerRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0d954ef3-8e8c-4c13-8ace-bd9d0744898d"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("9c23eec8-80ec-4ec8-a12a-5b459e8c7ce3"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d2a1e7b5-f11f-4bfe-9158-9a4ef54581b8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3df57f63-fb85-4311-9938-017afa6604b9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("62d0725e-9a69-409b-8c50-eae1631af0dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a0edf372-2381-466e-bc06-ff41640b4627"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2fdf7ed-f4d8-470a-b32c-9d8d2aa32a6d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a966c410-01de-473e-89f8-1940dfa29a78"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d24364df-ad04-4e8e-aec8-5c67554a4bb2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d44a7aab-23ff-4db7-b1e7-5b6a3ffb823b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe200d2e-e039-4b99-80ae-0df22e33602a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("01190cdb-8a84-4909-9b0f-0e8dc26ba267"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("06b84abc-6885-4d75-b5fc-a9749a583530"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("19099198-5b87-448b-8d5c-f1b8ba606184"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("201f464e-54e8-4fd1-ba1c-e0c686f4ff98"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2027e6ab-8786-4766-8d11-3e69b98ba33e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2d863a91-c79a-42e6-b602-0e126b77670a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("37db1132-88d6-4209-9833-2fa52f28028b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("79d93d2a-3c5c-449e-9102-56357ec9d2dd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7bae6c19-27c7-4149-8f18-36f7febd4e4c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b37db182-678a-434a-9c9c-e73d7bb87b7b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("be75615a-2a6e-4e53-a405-f6028f072713"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c0d47a62-8883-4fa1-968b-0e0d55959915"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d011c3c6-bdc4-42fa-97a1-58170066c8ea"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d28ee37e-bb2e-41d2-b64e-7445a754ca0b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ddcc2560-cd0d-4fec-bf8d-15de297bc939"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f9025da7-1cd1-4381-a2c7-d3b2a486a2c7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d70a6694-84a9-4417-8003-44f93dc72607"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"));

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "Record");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Record",
                table: "Record",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), null, "WTC", 2001 },
                    { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), null, "DCTV", 2016 },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), null, "De lustige rijders", 1991 },
                    { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), null, "WTC Melsele", 1966 },
                    { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("097a08ed-4c10-4b5a-8257-90ff8c7442bb"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("429b606e-78b0-43e8-bed4-5c9360805eb2"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("13c6d9e6-db14-4424-8977-0f2fdbb2972b"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("0f1c2d6d-18ca-4cf5-8f1c-ab1008abb023"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("22515542-1fa1-4dd2-b5e0-8d13e0933f8c"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("cfdc0a9b-146c-431d-856c-6082756341d0"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("7e9bac83-be9e-4c80-ba30-a3b6a05b4238"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("1bea80c7-941c-444b-91af-eb9fd9f6262a"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") },
                    { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") },
                    { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("60ba045e-9c5c-4221-bba9-38ca1f1d4ab0"), "Debruyne", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("fafab49e-a3be-4ddd-b5d9-23b94017c4b8"), "VanHoof", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("f7da1553-d0b5-4c68-ae5f-ff88b8f7213a"), "Scarlet", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("691c388c-aed4-4b21-a0bd-82da980fa6ff"), "Garnaal", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("973a8a73-ba2f-460a-85c8-dbb7dceb7cb5"), "Donckerwolcke", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429"), "Depardieu", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"), "Vissers", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("d192323a-38af-44c3-b8dd-b7b84571ebc3"), "Evenepoel", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("3b91dc4c-e965-4c60-a276-3eebb3b22aaf"), "Hazard", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("343c422e-79d3-4cdf-83c2-1f9bdc06b2db"), "Bambino", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("c4448a46-dc96-4d59-a14a-fa4f178aefe1"), "Vanderplas", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("32aa830f-acaa-448e-a31a-acf3b62bf2b2"), "Beukelaer", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("41bf269d-5cdd-4961-9c7a-cb10bed065b6"), "Mega", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("72764d21-0f0c-49b0-9138-e0697b5305af"), "Zalinski", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("c9c46416-1337-48fb-aeab-88ba6db2bb8c"), "Mertens", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("3f840b58-310a-4584-a47b-6d967339280b"), "Brokkenpap", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("13bfbcb7-b5eb-429d-9dcc-bcd23f951847"), "Camara", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("d48a8bd2-e377-43eb-b843-54e8ee4bc3b7"), "Van Overmeire", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"), "Jansma", new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"), "Franckaert", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2") },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") },
                    { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5") },
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") },
                    { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("922f07e7-5239-4626-a6d0-0df059231bfa"), "Merckx", new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"), "Oranje zadel" },
                    { new Guid("a8b0834e-5e9b-4804-8887-684ba4b5bef1"), "B-Twin", new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"), "Zwart zadel" },
                    { new Guid("99061927-f768-4d86-b5e1-b66d8a6dedb1"), "Moldava", new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"), "Geel zadel" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WielrennerRecords_Record_RecordId",
                table: "WielrennerRecords",
                column: "RecordId",
                principalTable: "Record",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
