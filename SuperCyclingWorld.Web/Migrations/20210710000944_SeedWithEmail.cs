using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedWithEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("825641d4-280f-4d9a-9297-7443d8a62f88"), new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c92889ba-f116-4be1-8691-d3edf72d26c4"), new Guid("eb3be317-94f1-4b6f-9354-554099f36551") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("13b6812a-14a1-4ff7-ac71-a00f3be721f4"), new Guid("04c3cbda-23fa-425d-a727-3fbe8a192e27") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90"), new Guid("e3cc3bdb-2cf2-42bb-a59c-874e2686bfcb") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("56e3ac8e-a800-4aba-ac3f-48d4fdcbf814"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("8b243a18-bf1f-4662-9255-4d312e9c8043"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("cf981342-1e5e-4466-be11-604416f09cb6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("44f4e620-1d7b-40e5-98ca-fe9d563aecf6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8a4ee18b-9fe3-43f1-9450-26f7ea13f652"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a90d2b88-b68d-46df-8c41-c98aaff558df"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("13b6812a-14a1-4ff7-ac71-a00f3be721f4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("eb3be317-94f1-4b6f-9354-554099f36551"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04c3cbda-23fa-425d-a727-3fbe8a192e27"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3f1e09d0-1d6d-4266-b332-85a447dabfbf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("78445b86-2c9e-4bd8-bafc-20a82f14c287"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e3cc3bdb-2cf2-42bb-a59c-874e2686bfcb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1514d656-9f72-4a69-b1d9-84d937db1dd7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("825641d4-280f-4d9a-9297-7443d8a62f88"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c92889ba-f116-4be1-8691-d3edf72d26c4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cb407ed9-3a28-4505-8ecf-fa102c536ef3"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("0386c5e3-7203-494d-b00d-85bd065ee4fd"), null, "WTC" },
                    { new Guid("c2e98ee9-be83-41a6-831c-5b1b81f5e449"), null, "DCTV" },
                    { new Guid("1a934f92-c341-49d8-9f99-7772409aa83c"), null, "De lustige rijders" },
                    { new Guid("2846f55e-6184-44b8-9382-b0a7f64c8627"), null, "WTC Melsele" },
                    { new Guid("4395fd3a-aec0-4304-89bd-d694bdf19c4e"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("d02acbe9-5f20-49dd-a6ac-8083f6f81899"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("762337e2-642c-4bfe-8d0d-44352b93f73a"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("95548dec-3dd8-48df-be91-8a1f200efb81"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("0386c5e3-7203-494d-b00d-85bd065ee4fd"), new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc") },
                    { new Guid("1a934f92-c341-49d8-9f99-7772409aa83c"), new Guid("d02acbe9-5f20-49dd-a6ac-8083f6f81899") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8f14c923-9729-4634-b42c-9b030f1dfad8"), "Franckaert", new Guid("0386c5e3-7203-494d-b00d-85bd065ee4fd"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("e528f6fb-89db-4148-ba34-53e1c764d48c"), "Jansma", new Guid("c2e98ee9-be83-41a6-831c-5b1b81f5e449"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("d0298f4d-7615-43f4-a909-3212493c3659"), "Vissers", new Guid("1a934f92-c341-49d8-9f99-7772409aa83c"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("831964ee-5089-44f8-b681-83a362c99c9a"), "Depardieu", new Guid("2846f55e-6184-44b8-9382-b0a7f64c8627"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("b43bc910-3894-4b51-b27a-77de353ff202"), "Van Overmeire", new Guid("4395fd3a-aec0-4304-89bd-d694bdf19c4e"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc"), new Guid("e528f6fb-89db-4148-ba34-53e1c764d48c") },
                    { new Guid("95548dec-3dd8-48df-be91-8a1f200efb81"), new Guid("831964ee-5089-44f8-b681-83a362c99c9a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("bc374ea1-ba8e-4b50-bd0a-b259ff655a2c"), "Merckx", new Guid("8f14c923-9729-4634-b42c-9b030f1dfad8"), "Oranje zadel" },
                    { new Guid("f36bd95d-cc52-4bfa-8a41-9ba68d253dd1"), "B-Twin", new Guid("e528f6fb-89db-4148-ba34-53e1c764d48c"), "Zwart zadel" },
                    { new Guid("20598739-2a86-4c93-a518-da83bb19197c"), "Moldava", new Guid("d0298f4d-7615-43f4-a909-3212493c3659"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0386c5e3-7203-494d-b00d-85bd065ee4fd"), new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1a934f92-c341-49d8-9f99-7772409aa83c"), new Guid("d02acbe9-5f20-49dd-a6ac-8083f6f81899") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("95548dec-3dd8-48df-be91-8a1f200efb81"), new Guid("831964ee-5089-44f8-b681-83a362c99c9a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc"), new Guid("e528f6fb-89db-4148-ba34-53e1c764d48c") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("20598739-2a86-4c93-a518-da83bb19197c"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bc374ea1-ba8e-4b50-bd0a-b259ff655a2c"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f36bd95d-cc52-4bfa-8a41-9ba68d253dd1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("762337e2-642c-4bfe-8d0d-44352b93f73a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b43bc910-3894-4b51-b27a-77de353ff202"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4395fd3a-aec0-4304-89bd-d694bdf19c4e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("95548dec-3dd8-48df-be91-8a1f200efb81"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ae48fa63-e9b1-428c-9bf2-caedf413e9dc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d02acbe9-5f20-49dd-a6ac-8083f6f81899"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("831964ee-5089-44f8-b681-83a362c99c9a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8f14c923-9729-4634-b42c-9b030f1dfad8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d0298f4d-7615-43f4-a909-3212493c3659"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e528f6fb-89db-4148-ba34-53e1c764d48c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0386c5e3-7203-494d-b00d-85bd065ee4fd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1a934f92-c341-49d8-9f99-7772409aa83c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2846f55e-6184-44b8-9382-b0a7f64c8627"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c2e98ee9-be83-41a6-831c-5b1b81f5e449"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("825641d4-280f-4d9a-9297-7443d8a62f88"), null, "WTC" },
                    { new Guid("1514d656-9f72-4a69-b1d9-84d937db1dd7"), null, "DCTV" },
                    { new Guid("c92889ba-f116-4be1-8691-d3edf72d26c4"), null, "De lustige rijders" },
                    { new Guid("cb407ed9-3a28-4505-8ecf-fa102c536ef3"), null, "WTC Melsele" },
                    { new Guid("a90d2b88-b68d-46df-8c41-c98aaff558df"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("eb3be317-94f1-4b6f-9354-554099f36551"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("44f4e620-1d7b-40e5-98ca-fe9d563aecf6"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("13b6812a-14a1-4ff7-ac71-a00f3be721f4"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("825641d4-280f-4d9a-9297-7443d8a62f88"), new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90") },
                    { new Guid("c92889ba-f116-4be1-8691-d3edf72d26c4"), new Guid("eb3be317-94f1-4b6f-9354-554099f36551") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("3f1e09d0-1d6d-4266-b332-85a447dabfbf"), "Franckaert", new Guid("825641d4-280f-4d9a-9297-7443d8a62f88"), null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("e3cc3bdb-2cf2-42bb-a59c-874e2686bfcb"), "Jansma", new Guid("1514d656-9f72-4a69-b1d9-84d937db1dd7"), null, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("78445b86-2c9e-4bd8-bafc-20a82f14c287"), "Vissers", new Guid("c92889ba-f116-4be1-8691-d3edf72d26c4"), null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("04c3cbda-23fa-425d-a727-3fbe8a192e27"), "Depardieu", new Guid("cb407ed9-3a28-4505-8ecf-fa102c536ef3"), null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("8a4ee18b-9fe3-43f1-9450-26f7ea13f652"), "Van Overmeire", new Guid("a90d2b88-b68d-46df-8c41-c98aaff558df"), null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("f7e1a1e0-7c1e-4302-aa2e-1e898adb7a90"), new Guid("e3cc3bdb-2cf2-42bb-a59c-874e2686bfcb") },
                    { new Guid("13b6812a-14a1-4ff7-ac71-a00f3be721f4"), new Guid("04c3cbda-23fa-425d-a727-3fbe8a192e27") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("56e3ac8e-a800-4aba-ac3f-48d4fdcbf814"), "Merckx", new Guid("3f1e09d0-1d6d-4266-b332-85a447dabfbf"), "Oranje zadel" },
                    { new Guid("cf981342-1e5e-4466-be11-604416f09cb6"), "B-Twin", new Guid("e3cc3bdb-2cf2-42bb-a59c-874e2686bfcb"), "Zwart zadel" },
                    { new Guid("8b243a18-bf1f-4662-9255-4d312e9c8043"), "Moldava", new Guid("78445b86-2c9e-4bd8-bafc-20a82f14c287"), "Geel zadel" }
                });
        }
    }
}
