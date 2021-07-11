using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddRitten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("00cb1983-e5cd-452a-b4aa-bd4b722fd7d1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("50bee6d5-22f8-4d2d-9800-6085916851d1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5c1a981a-fbd1-4eb3-8fa1-c14886872b5c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("471668ed-d025-498c-933d-2f08f1b413cb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4b147d17-7aa0-4a0f-980b-85b2e484ea35"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("526bb932-7077-485c-bef5-b36856c9fece"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("71c72ed5-ab63-4941-a503-3b1c8531e147"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bd022d32-be48-43fa-8eaa-97a370ef1e1e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c6d37d37-eca8-4cbc-b0d8-04f33c8394d9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("de658c6d-7026-4c0f-80bd-7f5ee9311d10"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e58ae1a5-b332-4ce2-b09f-4daeb2d96efc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1270dd91-0279-4527-92fa-86f1e7b09778"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("134d4a68-aec8-4ee7-9a14-7b51b3fb44d1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2f679ada-b355-4586-b53e-0f5984c4eb73"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3a29e165-fa1e-464d-96bf-927be1b5e86e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("44a872bd-70e7-4f3b-a4d0-babc07cdfbfd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7de1146f-23ef-4c36-9a39-e28153b07b17"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8c3d56c3-4213-4c06-8abf-a5803c9fd0ec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a1a5bc0-aafa-43c1-860e-795164abacab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a037319a-af21-4726-9484-d4e09c25c9f7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("aeabe12a-f63b-4e05-a0c2-6c19963478c6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c79cac4d-0c96-432e-abac-54f8ca625053"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("df166eaa-3051-48aa-a6f1-f9fdd3686a5e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e0a4680b-a765-4aae-840c-25f36af842ab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ead0ad24-f8fc-41b9-8c7d-b89a50d8682a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec863ace-dd46-4ca9-bf70-7d3e0b65c847"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f110f1e9-25ff-43ac-800f-ea121047a7a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("101bb1a7-84d0-4143-b384-5718839f1229"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"));

            migrationBuilder.AddColumn<int>(
                name: "GemiddeldeKM_Rit",
                table: "Wielrenners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ritten",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PersoonId = table.Column<Guid>(nullable: false),
                    WielrennerId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Start = table.Column<string>(nullable: true),
                    Aankomst = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ritten_Wielrenners_WielrennerId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Ritten_WielrennerId",
                table: "Ritten",
                column: "WielrennerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ritten");

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

            migrationBuilder.DropColumn(
                name: "GemiddeldeKM_Rit",
                table: "Wielrenners");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), 0, null, "WTC", 2001 },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), 0, null, "DCTV", 2016 },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("de658c6d-7026-4c0f-80bd-7f5ee9311d10"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("e58ae1a5-b332-4ce2-b09f-4daeb2d96efc"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("526bb932-7077-485c-bef5-b36856c9fece"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("71c72ed5-ab63-4941-a503-3b1c8531e147"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("4b147d17-7aa0-4a0f-980b-85b2e484ea35"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("bd022d32-be48-43fa-8eaa-97a370ef1e1e"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("471668ed-d025-498c-933d-2f08f1b413cb"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("c6d37d37-eca8-4cbc-b0d8-04f33c8394d9"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380") },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                    { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ec863ace-dd46-4ca9-bf70-7d3e0b65c847"), 0, "Bambino", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("a037319a-af21-4726-9484-d4e09c25c9f7"), 0, "Vanderplas", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("3a29e165-fa1e-464d-96bf-927be1b5e86e"), 0, "Beukelaer", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("7de1146f-23ef-4c36-9a39-e28153b07b17"), 0, "Mega", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("f110f1e9-25ff-43ac-800f-ea121047a7a3"), 0, "Van Overmeire", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("c79cac4d-0c96-432e-abac-54f8ca625053"), 0, "Evenepoel", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("ead0ad24-f8fc-41b9-8c7d-b89a50d8682a"), 0, "Mertens", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("2f679ada-b355-4586-b53e-0f5984c4eb73"), 0, "Camara", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("e0a4680b-a765-4aae-840c-25f36af842ab"), 0, "Brokkenpap", new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("df166eaa-3051-48aa-a6f1-f9fdd3686a5e"), 0, "Garnaal", new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("134d4a68-aec8-4ee7-9a14-7b51b3fb44d1"), 0, "Hazard", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("1270dd91-0279-4527-92fa-86f1e7b09778"), 0, "Zalinski", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("aeabe12a-f63b-4e05-a0c2-6c19963478c6"), 0, "Scarlet", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("8c3d56c3-4213-4c06-8abf-a5803c9fd0ec"), 0, "Donckerwolcke", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c"), 0, "Depardieu", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("44a872bd-70e7-4f3b-a4d0-babc07cdfbfd"), 0, "VanHoof", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), 0, "Vissers", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), 0, "Jansma", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("9a1a5bc0-aafa-43c1-860e-795164abacab"), 0, "Debruyne", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), 0, "Franckaert", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, "202CB962AC59075B964B07152D234B70", 103, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1") },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                    { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8") },
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") },
                    { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("50bee6d5-22f8-4d2d-9800-6085916851d1"), "Merckx", new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), "Oranje zadel" },
                    { new Guid("5c1a981a-fbd1-4eb3-8fa1-c14886872b5c"), "B-Twin", new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), "Zwart zadel" },
                    { new Guid("00cb1983-e5cd-452a-b4aa-bd4b722fd7d1"), "Moldava", new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), "Geel zadel" }
                });
        }
    }
}
