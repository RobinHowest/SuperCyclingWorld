using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class RemoveWielrennersRecordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Clubnaam = table.Column<string>(nullable: true),
                    Clubleider = table.Column<Guid>(nullable: true),
                    Oprichtingsjaar = table.Column<int>(nullable: false),
                    AantalRecords = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supporters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: false),
                    Paswoord = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supporters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wielrenners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: false),
                    Paswoord = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ClubId = table.Column<Guid>(nullable: false),
                    AantalRecords = table.Column<int>(nullable: false),
                    TotaalAantalGeredenKilometers = table.Column<int>(nullable: false),
                    GemiddeldKm_h = table.Column<double>(nullable: false),
                    GemiddeldeKM_Rit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wielrenners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wielrenners_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubSupporter",
                columns: table => new
                {
                    ClubId = table.Column<Guid>(nullable: false),
                    SupporterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubSupporter", x => new { x.ClubId, x.SupporterId });
                    table.ForeignKey(
                        name: "FK_ClubSupporter_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubSupporter_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanRegistratie",
                columns: table => new
                {
                    WielrennerId = table.Column<Guid>(nullable: false),
                    SupporterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanRegistratie", x => new { x.SupporterId, x.WielrennerId });
                    table.ForeignKey(
                        name: "FK_FanRegistratie_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanRegistratie_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fietsen",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Zadel = table.Column<string>(nullable: true),
                    Merk = table.Column<string>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fietsen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fietsen_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    WielrennerId = table.Column<Guid>(nullable: true),
                    RecordType = table.Column<int>(nullable: false),
                    Recordnaam = table.Column<string>(nullable: true),
                    RecordCijfer = table.Column<int>(nullable: false),
                    RecordEenheid = table.Column<string>(nullable: true),
                    Thropy = table.Column<string>(nullable: true)
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
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), 0, null, "WTC", 2001 },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), 0, null, "DCTV", 2016 },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("0eca18e3-dc69-47f6-9a05-9c9f16d8e01e"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("3ce32128-2be8-4e97-8376-36cbc5fd1768"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("97c7d0d7-afbb-4ae2-ab29-63b269354b1c"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("cacb9a9d-8c10-45e4-a18a-48b25fa9a6fd"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("5c78e5ff-bbd6-48e3-9138-e1636f207913"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("a0c17220-4b0f-45f9-92b6-1f8e63ba46e3"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("cfee5a6c-35e6-40ea-800f-40552650bbd5"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("cd3896ce-9e40-4f59-93b2-e41930b0afa4"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9") },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") },
                    { new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("27207fc4-7c0e-4cce-ab54-6a3c9a393847"), 0, "Debruyne", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 165, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("45235ec5-5833-40e7-80c3-99ca0cc9c084"), 0, "Bambino", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 159, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("929c45bf-ab34-4e97-a327-da733233852e"), 0, "Mega", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 230, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("72e17e68-1766-48d4-bdad-3ed8ec97bbc9"), 0, "Donckerwolcke", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 202, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a"), 0, "Vissers", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 150, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04"), 0, "Franckaert", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 110, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("96d497eb-92e3-40ca-ba2a-376d374fb6cf"), 0, "Scarlet", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 111, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("d6413a35-6940-4720-8a52-39086e4b3f1e"), 0, "Brokkenpap", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 185, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("6c57cc9f-0d0d-48a8-8a3d-1bee1b76e1bd"), 0, "Garnaal", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 166, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("0a89a1a9-9e0f-4cb0-8d5b-62e8cf0b3c53"), 0, "Hazard", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 166, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("e6927028-b287-4935-901b-d0649ee0e772"), 0, "Vanderplas", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 163, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("866f6f07-7f9c-4cb6-a39a-9fcc62c7e534"), 0, "VanHoof", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 136, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("c7618859-c1d0-40ee-86f2-af4f4b8a29c9"), 0, "Mertens", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 155, "202CB962AC59075B964B07152D234B70", 1250, "Evelyne" },
                    { new Guid("5ed74120-8322-483b-b71b-104900b005da"), 0, "Camara", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 156, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("99ce9a58-389d-485e-b450-014da8902080"), 0, "Depardieu", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 206, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("f9a23758-1cdf-4480-a4c1-9be6007900a3"), 0, "Evenepoel", new Guid("88fed016-5609-4006-9de8-09c69833c256"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 166, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("05baa842-d974-4908-802a-1f264346dfa5"), 0, "Beukelaer", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 232, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("d4fc7bc7-e1fb-46c6-9a8d-0eb273672a74"), 0, "Van Overmeire", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 190, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("1867dbef-ffaa-4ce2-9a66-64b9fef97718"), 0, "Zalinski", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 174, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd"), 0, "Jansma", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 203, "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") },
                    { new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("99ce9a58-389d-485e-b450-014da8902080") },
                    { new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"), new Guid("99ce9a58-389d-485e-b450-014da8902080") },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04") },
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("97154dd9-a4b2-4416-9215-ba6efa370623"), "B-Twin", new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd"), "Zwart zadel" },
                    { new Guid("aadf0221-453c-413e-bf6a-4c89b28162ee"), "Merckx", new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04"), "Oranje zadel" },
                    { new Guid("7d0a8502-7c41-4dcb-b6d8-acb3b345b66f"), "Moldava", new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a"), "Geel zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubSupporter_SupporterId",
                table: "ClubSupporter",
                column: "SupporterId");

            migrationBuilder.CreateIndex(
                name: "IX_FanRegistratie_WielrennerId",
                table: "FanRegistratie",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fietsen_WielrennerId",
                table: "Fietsen",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_WielrennerId",
                table: "Records",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ritten_WielrennerId",
                table: "Ritten",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wielrenners_ClubId",
                table: "Wielrenners",
                column: "ClubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubSupporter");

            migrationBuilder.DropTable(
                name: "FanRegistratie");

            migrationBuilder.DropTable(
                name: "Fietsen");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Ritten");

            migrationBuilder.DropTable(
                name: "Supporters");

            migrationBuilder.DropTable(
                name: "Wielrenners");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
