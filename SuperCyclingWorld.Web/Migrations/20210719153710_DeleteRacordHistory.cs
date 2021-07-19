using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class DeleteRacordHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    RecordCijfer = table.Column<int>(nullable: false),
                    RecordEenheid = table.Column<string>(nullable: true),
                    RecordHistoryId = table.Column<Guid>(nullable: true),
                    RecordType = table.Column<int>(nullable: false),
                    Recordnaam = table.Column<string>(nullable: true),
                    Thropy = table.Column<string>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: true)
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
    }
}
