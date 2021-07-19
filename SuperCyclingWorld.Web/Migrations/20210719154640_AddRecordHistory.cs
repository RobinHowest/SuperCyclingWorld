using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddRecordHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e"), new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"), new Guid("1300d307-eede-40ab-8992-17375f9099e5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"), new Guid("153406e7-2358-45de-a74f-145fbaf88db5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78"), new Guid("1300d307-eede-40ab-8992-17375f9099e5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"), new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"), new Guid("77221b4f-cca0-4730-a784-7958e73555a5") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("04e383cc-0abf-4e49-b4c3-7e48ad5aafd6"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7a5ff17d-cf7c-44d6-874f-8c65f75e0fc8"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("b3e98139-2fb9-4470-9cb4-c538e7c78b98"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("04c8ea45-83e4-4cc8-87e0-68bdaa95bc7c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("16e593df-dca0-41ae-ad9c-95fc984d6a12"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("496dc0c5-002a-43db-84b0-5436144764fc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("930a19ea-1214-4c87-a54b-a6666d40e3db"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2a13ec5-e54b-416a-9067-4d61ba3da761"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b3556726-249d-42f4-af33-86abc84068a5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bb3864cc-c94a-410d-bbaa-2bad268aa1db"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fbc6aada-61b4-4a2b-83e1-5de98ec1b303"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("07720e84-5743-42bd-8f28-4a9b5d24ee42"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("25f74a7a-29b8-48ea-abde-c70198b7ede5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("316a48c4-83b4-4f6e-8fcf-2cc7ae06e050"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("52505aa8-8894-490a-bda8-a6efe56abc89"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b2cdd7c-5481-4328-9b71-c00a282e58a4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7f387e05-e359-4ea7-9bcf-06de7f90898b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("80bf2170-dc39-4403-953e-b9321e349042"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("86349e60-85f3-43ce-a792-0340ebfa7f37"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("913247ec-e1d6-4363-bd25-ebbec34b7535"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("956cb34f-5689-4c64-9cab-6dd94d4bebc9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ba33bab2-d8ee-41d2-9312-54a29771b3a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d6cf6c50-27dd-4c58-8fbd-0e8574cf5ec8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("da21d98a-6808-4de9-b4c8-8a4ecc78a86d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("eae4bf0d-33e0-4df4-b662-89c118b758db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f07eb05f-11ee-4fd4-a088-0a9d61066b0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fca3267b-18b3-494f-925c-e8961bc06908"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1300d307-eede-40ab-8992-17375f9099e5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("153406e7-2358-45de-a74f-145fbaf88db5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("77221b4f-cca0-4730-a784-7958e73555a5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), 0, null, "WTC", 2001 },
                    { new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), 0, null, "DCTV", 2016 },
                    { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("bb3864cc-c94a-410d-bbaa-2bad268aa1db"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("496dc0c5-002a-43db-84b0-5436144764fc"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("04c8ea45-83e4-4cc8-87e0-68bdaa95bc7c"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("a2a13ec5-e54b-416a-9067-4d61ba3da761"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("fbc6aada-61b4-4a2b-83e1-5de98ec1b303"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("16e593df-dca0-41ae-ad9c-95fc984d6a12"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("930a19ea-1214-4c87-a54b-a6666d40e3db"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("b3556726-249d-42f4-af33-86abc84068a5"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be") },
                    { new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e") },
                    { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78") },
                    { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78") },
                    { new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") },
                    { new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") },
                    { new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") },
                    { new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") },
                    { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6") },
                    { new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("eae4bf0d-33e0-4df4-b662-89c118b758db"), 0, "Bambino", new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("07720e84-5743-42bd-8f28-4a9b5d24ee42"), 0, "Beukelaer", new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("80bf2170-dc39-4403-953e-b9321e349042"), 0, "Garnaal", new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("1300d307-eede-40ab-8992-17375f9099e5"), 0, "Jansma", new Guid("f9985d09-dd35-4fd4-8f12-0aab84bc4033"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("86349e60-85f3-43ce-a792-0340ebfa7f37"), 0, "Scarlet", new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("da21d98a-6808-4de9-b4c8-8a4ecc78a86d"), 0, "Brokkenpap", new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("153406e7-2358-45de-a74f-145fbaf88db5"), 0, "Vissers", new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("7f387e05-e359-4ea7-9bcf-06de7f90898b"), 0, "Evenepoel", new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04"), 0, "Depardieu", new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("77221b4f-cca0-4730-a784-7958e73555a5"), 0, "Franckaert", new Guid("07b898ed-0d04-4c02-abcc-fe986da3c30e"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" },
                    { new Guid("fca3267b-18b3-494f-925c-e8961bc06908"), 0, "Debruyne", new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("25f74a7a-29b8-48ea-abde-c70198b7ede5"), 0, "Zalinski", new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("316a48c4-83b4-4f6e-8fcf-2cc7ae06e050"), 0, "Vanderplas", new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("d6cf6c50-27dd-4c58-8fbd-0e8574cf5ec8"), 0, "VanHoof", new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("f07eb05f-11ee-4fd4-a088-0a9d61066b0a"), 0, "Donckerwolcke", new Guid("625ec87a-4369-40d1-9d86-1be68032d4ff"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("52505aa8-8894-490a-bda8-a6efe56abc89"), 0, "Hazard", new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("956cb34f-5689-4c64-9cab-6dd94d4bebc9"), 0, "Mertens", new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("913247ec-e1d6-4363-bd25-ebbec34b7535"), 0, "Mega", new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("ba33bab2-d8ee-41d2-9312-54a29771b3a2"), 0, "Van Overmeire", new Guid("130fe445-1469-4340-8f0b-44bf16c4bc92"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("6b2cdd7c-5481-4328-9b71-c00a282e58a4"), 0, "Camara", new Guid("867bfcca-c75b-4aae-8f07-6a6be0de2dda"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"), new Guid("77221b4f-cca0-4730-a784-7958e73555a5") },
                    { new Guid("f84643bb-2d3a-4ccc-8d3f-86b4d31cc6be"), new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04") },
                    { new Guid("5f2f1eea-5c48-4e89-b026-68217e29203e"), new Guid("5f8eea00-d8e7-477d-bf81-79df1a6e8e04") },
                    { new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"), new Guid("153406e7-2358-45de-a74f-145fbaf88db5") },
                    { new Guid("8ff8c9ef-ae5f-40a9-852e-88415e268bd6"), new Guid("1300d307-eede-40ab-8992-17375f9099e5") },
                    { new Guid("f1e00a37-bee5-49d1-8b4b-e0f4477e4b78"), new Guid("1300d307-eede-40ab-8992-17375f9099e5") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("7a5ff17d-cf7c-44d6-874f-8c65f75e0fc8"), "Merckx", new Guid("77221b4f-cca0-4730-a784-7958e73555a5"), "Oranje zadel" },
                    { new Guid("04e383cc-0abf-4e49-b4c3-7e48ad5aafd6"), "Moldava", new Guid("153406e7-2358-45de-a74f-145fbaf88db5"), "Geel zadel" },
                    { new Guid("b3e98139-2fb9-4470-9cb4-c538e7c78b98"), "B-Twin", new Guid("1300d307-eede-40ab-8992-17375f9099e5"), "Zwart zadel" }
                });
        }
    }
}
