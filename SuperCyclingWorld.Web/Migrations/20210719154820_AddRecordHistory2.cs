using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddRecordHistory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("2de1c861-a7cd-49e6-a977-666e5643f515") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("2de1c861-a7cd-49e6-a977-666e5643f515") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2de1c861-a7cd-49e6-a977-666e5643f515"), new Guid("0aece930-cafb-4152-aa22-89af02c20487") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"), new Guid("0aece930-cafb-4152-aa22-89af02c20487") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"), new Guid("db74e981-b55b-438b-9813-449dfe312efd") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd"), new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"), new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"), new Guid("ccd1fced-4764-4973-9fa9-4dfd29142f5e") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0ba29ec6-45a3-4c5e-8d26-2ebe564c1aa8"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("156d6fd9-0c2c-4767-8e1b-a2c14e73d95b"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("2d8035bf-4049-4371-ab82-0030ebd09957"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("120b9557-abfb-4a45-8dac-c170bffb07a2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2f189c93-486a-4a55-afa4-664f81cf96f5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("32384a19-3497-49be-a863-e1da8eb4dde5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3d4cc78c-ce58-4d37-b640-235e60556886"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6b96b16d-3292-4ec7-87b8-5685d0e71a4b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b5c13f18-2dee-4f25-9fd3-05d97dfdc392"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c510fb21-e88b-46d2-bfd9-8ec55203e244"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f31aab8c-c0a2-4e51-b36c-64ae0fe44865"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0b7d9434-3485-4e6f-ab80-d5da8f0a62fd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("220b3203-617e-4f57-880a-bea8a43e93d9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("22ef876e-458c-45b2-b5d6-411a17ee26cc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("27b8dc5a-f111-4871-bb33-6d3d444550c6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2998642f-3e8b-4751-9b38-940b59f6817f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3769b879-4d0b-4887-83bb-1cf5fb1f4ff0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3c17ea0c-3f9a-40ce-8780-f8dc3cd0126c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("40c5385a-5511-4d96-98e9-65f784e570ec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5cbb76f6-fb45-44bb-9a09-f005b45ba869"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("85ba4e22-1de9-4de5-a583-e0cd10e06ec1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8ac47a37-a483-4c8a-8e07-a518461f613c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a1897cde-99c1-4281-9946-8867d1d84d29"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("af837571-c791-49ac-97cf-3e5714b2cba0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c1f94eb7-6736-4f04-a82e-79dc342bd50d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e8996f91-a394-4a6a-a45f-ec696ce098ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e94036a4-fb75-433d-b946-46a54af9d5fb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a56161af-8e47-494e-a824-657dbfe64686"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2de1c861-a7cd-49e6-a977-666e5643f515"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0aece930-cafb-4152-aa22-89af02c20487"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ccd1fced-4764-4973-9fa9-4dfd29142f5e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("db74e981-b55b-438b-9813-449dfe312efd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"));

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
                    Thropy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Record_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecordHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecordId = table.Column<Guid>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecordHistories_Record_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), 0, null, "WTC", 2001 },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), 0, null, "DCTV", 2016 },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("874a86df-1e68-42a0-a039-92a4b0eb26c4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("7a9ae06d-6ea8-4a71-ba44-3d1ec15cf387"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("87856043-d04f-4267-9933-fcd2949037ba"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("387affc6-34d9-44a9-8145-441eca511554"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("6b9b80be-b723-4476-b2d9-42219a150ddb"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("8962cf78-9067-4291-bd05-a448911f77fd"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("9f8841da-501f-4a2f-b4a1-7e7dc2a99a95"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("beab6730-67d1-4fff-b266-bdc189a729a3"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3") },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") },
                    { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("7d9493f3-b098-4086-a4a6-6a010a5ecfb5"), 0, "Hazard", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("c7e7db0b-8ef5-4c08-b0c2-2971f24970b1"), 0, "Bambino", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("49234ac9-93de-4622-add6-7774df8b8667"), 0, "Scarlet", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("3725d26c-9c90-4da7-896e-632829177408"), 0, "Mega", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("a716d5c4-f263-4a90-9e10-0edf468c905a"), 0, "Garnaal", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("04453c14-15a5-4616-89eb-1cc233ddb858"), 0, "Depardieu", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("de41aa2e-e3a6-4d5f-a27b-3879143e7899"), 0, "Zalinski", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("c6b434db-3313-4b3f-b9b6-1d53c3b703ec"), 0, "Beukelaer", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("56eb8839-95f3-4af9-a81d-9615c7141a7a"), 0, "Donckerwolcke", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("f75407e2-8a97-4f4f-9051-3f266fe2f546"), 0, "Van Overmeire", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"), 0, "Jansma", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("a1c453ff-3aff-4d5e-8aeb-9406a6169325"), 0, "Brokkenpap", new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("6c22d35c-8dbb-4f67-94c9-76679b08a92f"), 0, "Debruyne", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("d9561014-5fff-4ce9-9331-eb386148c1d0"), 0, "Vanderplas", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("d9f19d9e-72bd-4086-a715-4dd1c94b2448"), 0, "VanHoof", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("e40e5ad9-3eb5-4abe-9b72-bdcb3cdb1402"), 0, "Mertens", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("812a047a-c778-4496-8dc3-d6ed9825e2de"), 0, "Camara", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("0aadb9e8-e50d-40fc-8152-8fe49c35470d"), 0, "Evenepoel", new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"), 0, "Vissers", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"), 0, "Franckaert", new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926") },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") },
                    { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7") },
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") },
                    { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("45dd75f6-1dae-4e61-ae3d-f28bc4cbe144"), "Merckx", new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"), "Oranje zadel" },
                    { new Guid("d8b3a9a0-3f92-4aef-b30f-85465ef7f852"), "B-Twin", new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"), "Zwart zadel" },
                    { new Guid("173a8be2-bd13-4f75-bd8c-b5379bdda172"), "Moldava", new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"), "Geel zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_WielrennerId",
                table: "Record",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordHistories_RecordId",
                table: "RecordHistories",
                column: "RecordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecordHistories");

            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("173a8be2-bd13-4f75-bd8c-b5379bdda172"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("45dd75f6-1dae-4e61-ae3d-f28bc4cbe144"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d8b3a9a0-3f92-4aef-b30f-85465ef7f852"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("387affc6-34d9-44a9-8145-441eca511554"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6b9b80be-b723-4476-b2d9-42219a150ddb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7a9ae06d-6ea8-4a71-ba44-3d1ec15cf387"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("874a86df-1e68-42a0-a039-92a4b0eb26c4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("87856043-d04f-4267-9933-fcd2949037ba"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8962cf78-9067-4291-bd05-a448911f77fd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9f8841da-501f-4a2f-b4a1-7e7dc2a99a95"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("beab6730-67d1-4fff-b266-bdc189a729a3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0aadb9e8-e50d-40fc-8152-8fe49c35470d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3725d26c-9c90-4da7-896e-632829177408"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("49234ac9-93de-4622-add6-7774df8b8667"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("56eb8839-95f3-4af9-a81d-9615c7141a7a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6c22d35c-8dbb-4f67-94c9-76679b08a92f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7d9493f3-b098-4086-a4a6-6a010a5ecfb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("812a047a-c778-4496-8dc3-d6ed9825e2de"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a1c453ff-3aff-4d5e-8aeb-9406a6169325"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a716d5c4-f263-4a90-9e10-0edf468c905a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c6b434db-3313-4b3f-b9b6-1d53c3b703ec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7e7db0b-8ef5-4c08-b0c2-2971f24970b1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d9561014-5fff-4ce9-9331-eb386148c1d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d9f19d9e-72bd-4086-a715-4dd1c94b2448"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("de41aa2e-e3a6-4d5f-a27b-3879143e7899"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e40e5ad9-3eb5-4abe-9b72-bdcb3cdb1402"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f75407e2-8a97-4f4f-9051-3f266fe2f546"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cebce923-1654-4da3-ab39-260c83b77735"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("982e1006-3967-47b4-b631-f728056d3e3e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04453c14-15a5-4616-89eb-1cc233ddb858"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), 0, null, "WTC", 2001 },
                    { new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), 0, null, "DCTV", 2016 },
                    { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("120b9557-abfb-4a45-8dac-c170bffb07a2"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("c510fb21-e88b-46d2-bfd9-8ec55203e244"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("b5c13f18-2dee-4f25-9fd3-05d97dfdc392"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("32384a19-3497-49be-a863-e1da8eb4dde5"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("3d4cc78c-ce58-4d37-b640-235e60556886"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("6b96b16d-3292-4ec7-87b8-5685d0e71a4b"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("2de1c861-a7cd-49e6-a977-666e5643f515"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("f31aab8c-c0a2-4e51-b36c-64ae0fe44865"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("2f189c93-486a-4a55-afa4-664f81cf96f5"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414") },
                    { new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd") },
                    { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("2de1c861-a7cd-49e6-a977-666e5643f515") },
                    { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("2de1c861-a7cd-49e6-a977-666e5643f515") },
                    { new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") },
                    { new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") },
                    { new Guid("a56161af-8e47-494e-a824-657dbfe64686"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") },
                    { new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") },
                    { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef") },
                    { new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("3c17ea0c-3f9a-40ce-8780-f8dc3cd0126c"), 0, "Debruyne", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("2998642f-3e8b-4751-9b38-940b59f6817f"), 0, "Bambino", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("5cbb76f6-fb45-44bb-9a09-f005b45ba869"), 0, "VanHoof", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("c1f94eb7-6736-4f04-a82e-79dc342bd50d"), 0, "Mertens", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("85ba4e22-1de9-4de5-a583-e0cd10e06ec1"), 0, "Donckerwolcke", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("22ef876e-458c-45b2-b5d6-411a17ee26cc"), 0, "Camara", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("8ac47a37-a483-4c8a-8e07-a518461f613c"), 0, "Scarlet", new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("e8996f91-a394-4a6a-a45f-ec696ce098ff"), 0, "Brokkenpap", new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("db74e981-b55b-438b-9813-449dfe312efd"), 0, "Vissers", new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("ccd1fced-4764-4973-9fa9-4dfd29142f5e"), 0, "Franckaert", new Guid("57bd24ea-ff4d-47e3-a04f-14de486da9fc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" },
                    { new Guid("0b7d9434-3485-4e6f-ab80-d5da8f0a62fd"), 0, "Hazard", new Guid("a56161af-8e47-494e-a824-657dbfe64686"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("220b3203-617e-4f57-880a-bea8a43e93d9"), 0, "Beukelaer", new Guid("a56161af-8e47-494e-a824-657dbfe64686"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("e94036a4-fb75-433d-b946-46a54af9d5fb"), 0, "Evenepoel", new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("af837571-c791-49ac-97cf-3e5714b2cba0"), 0, "Zalinski", new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("40c5385a-5511-4d96-98e9-65f784e570ec"), 0, "Vanderplas", new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("0aece930-cafb-4152-aa22-89af02c20487"), 0, "Jansma", new Guid("d56827b1-a9a0-432d-a95a-012e984a7e98"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("3769b879-4d0b-4887-83bb-1cf5fb1f4ff0"), 0, "Mega", new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("27b8dc5a-f111-4871-bb33-6d3d444550c6"), 0, "Garnaal", new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("a1897cde-99c1-4281-9946-8867d1d84d29"), 0, "Van Overmeire", new Guid("ce7557fe-bf6d-42fb-bd51-56fd899bfa62"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829"), 0, "Depardieu", new Guid("8770827d-490a-4b0e-a751-1bc04190c0a6"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"), new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829") },
                    { new Guid("78ca5332-f828-44a6-b7f2-6f676be44ecd"), new Guid("37837c4a-c51b-426c-94c4-1e6d1c8e8829") },
                    { new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"), new Guid("0aece930-cafb-4152-aa22-89af02c20487") },
                    { new Guid("2de1c861-a7cd-49e6-a977-666e5643f515"), new Guid("0aece930-cafb-4152-aa22-89af02c20487") },
                    { new Guid("e354d7f0-51ce-4ca7-95d5-308c10461414"), new Guid("ccd1fced-4764-4973-9fa9-4dfd29142f5e") },
                    { new Guid("34825656-dc47-41ce-a267-0b3ddfaae3ef"), new Guid("db74e981-b55b-438b-9813-449dfe312efd") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("2d8035bf-4049-4371-ab82-0030ebd09957"), "B-Twin", new Guid("0aece930-cafb-4152-aa22-89af02c20487"), "Zwart zadel" },
                    { new Guid("0ba29ec6-45a3-4c5e-8d26-2ebe564c1aa8"), "Merckx", new Guid("ccd1fced-4764-4973-9fa9-4dfd29142f5e"), "Oranje zadel" },
                    { new Guid("156d6fd9-0c2c-4767-8e1b-a2c14e73d95b"), "Moldava", new Guid("db74e981-b55b-438b-9813-449dfe312efd"), "Geel zadel" }
                });
        }
    }
}
