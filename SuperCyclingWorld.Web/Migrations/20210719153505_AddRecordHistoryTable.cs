using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddRecordHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "RecordHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    WielrennerId = table.Column<Guid>(nullable: true),
                    RecordType = table.Column<int>(nullable: false),
                    Recordnaam = table.Column<string>(nullable: true),
                    RecordCijfer = table.Column<int>(nullable: false),
                    RecordEenheid = table.Column<string>(nullable: true),
                    Thropy = table.Column<string>(nullable: true),
                    RecordHistoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Record_RecordHistories_RecordHistoryId",
                        column: x => x.RecordHistoryId,
                        principalTable: "RecordHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Record_Wielrenners_WielrennerId",
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
                    { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), 0, null, "WTC", 2001 },
                    { new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), 0, null, "DCTV", 2016 },
                    { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("39035d25-c3ac-4d6e-b87b-4e3812780bee"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("b26127fd-2da8-4ebe-bcf8-9c61edcdbdfd"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("df702198-9f74-4350-82eb-3cea163631d0"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("d2149273-dfc8-4503-b33a-2f03cce7c93d"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("1be7c2a6-9ed6-488c-8676-fe75fe6c020b"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("465d6423-77e4-41ba-9ebe-ce0b72ee0383"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("55616386-bb6c-4d6c-a1db-ba0fd7f6123d"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("9801abac-ce4a-40db-a9ac-899938ebf32e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("bd3ba84e-3274-4589-885d-f0d00211593f") },
                    { new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") },
                    { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") },
                    { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") },
                    { new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                    { new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                    { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                    { new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                    { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") },
                    { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("b17d9345-8fe6-4c2a-b706-aa7e3ea54f83"), 0, "Evenepoel", new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("0e36be6a-256d-4b0e-af31-a93b7b7af2a6"), 0, "Zalinski", new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("d105ddfa-2a0f-4f97-9f3c-eec2d5545c0e"), 0, "VanHoof", new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("407d720c-b512-482b-81eb-35992d3fcf40"), 0, "Beukelaer", new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("59e7b3ca-0413-4835-a234-27ea29ee21b3"), 0, "Garnaal", new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("76717832-d230-4c9b-b970-09c1438781fe"), 0, "Debruyne", new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("c6fe5ea4-b8e9-4650-af5d-8c35e8740411"), 0, "Brokkenpap", new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("f216631a-bb64-45f8-9484-4c4716bfbb97"), 0, "Hazard", new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("e656a795-03c4-4f79-a286-11d2678b1de9"), 0, "Mega", new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9"), 0, "Depardieu", new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee"), 0, "Vissers", new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658"), 0, "Jansma", new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("9030c945-de3c-45b4-be30-4ff75c38fc55"), 0, "Bambino", new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("857ed997-8294-4039-b519-e5415c7a6b97"), 0, "Vanderplas", new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("82c212ac-c413-4b46-9d3a-3c21e4a8cb07"), 0, "Scarlet", new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("c7b59b49-b37a-456f-ad31-52819bcb74be"), 0, "Donckerwolcke", new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("24917aeb-bb69-4c9f-9d04-4931098519ee"), 0, "Camara", new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("155072b2-a97a-4abc-b87c-4173648595ac"), 0, "Van Overmeire", new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("c7d84dc8-7408-4053-9ac0-0cb443fbf4dd"), 0, "Mertens", new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("0d35d870-5781-4423-ad33-57fb4489dbae"), 0, "Franckaert", new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), new Guid("0d35d870-5781-4423-ad33-57fb4489dbae") },
                    { new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") },
                    { new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"), new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") },
                    { new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee") },
                    { new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") },
                    { new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"), new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("6dad5e18-83a1-4fc8-b2fc-436eae9ccd62"), "Merckx", new Guid("0d35d870-5781-4423-ad33-57fb4489dbae"), "Oranje zadel" },
                    { new Guid("565f2632-c5f2-4c6b-bdca-5d26dd31f296"), "B-Twin", new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658"), "Zwart zadel" },
                    { new Guid("c84761cc-c465-4f02-8c82-2772cd06e035"), "Moldava", new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee"), "Geel zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_RecordHistoryId",
                table: "Record",
                column: "RecordHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Record_WielrennerId",
                table: "Record",
                column: "WielrennerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DropTable(
                name: "RecordHistories");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("bd3ba84e-3274-4589-885d-f0d00211593f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"), new Guid("e12efce1-3699-42de-99c9-6e0506f67c55") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"), new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"), new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), new Guid("0d35d870-5781-4423-ad33-57fb4489dbae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"), new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"), new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("565f2632-c5f2-4c6b-bdca-5d26dd31f296"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6dad5e18-83a1-4fc8-b2fc-436eae9ccd62"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c84761cc-c465-4f02-8c82-2772cd06e035"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1be7c2a6-9ed6-488c-8676-fe75fe6c020b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("39035d25-c3ac-4d6e-b87b-4e3812780bee"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("465d6423-77e4-41ba-9ebe-ce0b72ee0383"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("55616386-bb6c-4d6c-a1db-ba0fd7f6123d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9801abac-ce4a-40db-a9ac-899938ebf32e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b26127fd-2da8-4ebe-bcf8-9c61edcdbdfd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d2149273-dfc8-4503-b33a-2f03cce7c93d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("df702198-9f74-4350-82eb-3cea163631d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0e36be6a-256d-4b0e-af31-a93b7b7af2a6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("155072b2-a97a-4abc-b87c-4173648595ac"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("24917aeb-bb69-4c9f-9d04-4931098519ee"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("407d720c-b512-482b-81eb-35992d3fcf40"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("59e7b3ca-0413-4835-a234-27ea29ee21b3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("76717832-d230-4c9b-b970-09c1438781fe"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("82c212ac-c413-4b46-9d3a-3c21e4a8cb07"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("857ed997-8294-4039-b519-e5415c7a6b97"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9030c945-de3c-45b4-be30-4ff75c38fc55"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b17d9345-8fe6-4c2a-b706-aa7e3ea54f83"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c6fe5ea4-b8e9-4650-af5d-8c35e8740411"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7b59b49-b37a-456f-ad31-52819bcb74be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7d84dc8-7408-4053-9ac0-0cb443fbf4dd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d105ddfa-2a0f-4f97-9f3c-eec2d5545c0e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e656a795-03c4-4f79-a286-11d2678b1de9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f216631a-bb64-45f8-9484-4c4716bfbb97"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("30597a2f-a4d0-45e6-921d-ad28bc4c5ac0"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3436d42b-f510-4425-b1df-0e7164c45fc8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("94c3d507-4890-4b39-b424-5a05d7f6a89f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4c34c2d6-f303-4d0c-b230-28f7ba8050ac"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9e14f5d9-54e7-401a-9423-f4c7e2859f6e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bd3ba84e-3274-4589-885d-f0d00211593f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e12efce1-3699-42de-99c9-6e0506f67c55"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0d35d870-5781-4423-ad33-57fb4489dbae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8d45bf01-6184-4217-93e1-b2f775c93eb9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("91be04d7-49d9-4fd7-abda-cb6dbff82658"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec22efb6-2fad-4b06-9fef-4a2103c257ee"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("22bb029c-7279-47d5-b037-d0585b9d55e8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bb0241c8-b3cd-44b5-a2d5-5f246a0aeda4"));

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
    }
}
