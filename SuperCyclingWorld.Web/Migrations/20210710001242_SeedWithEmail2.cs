using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedWithEmail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), null, "WTC" },
                    { new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"), null, "DCTV" },
                    { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), null, "De lustige rijders" },
                    { new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"), null, "WTC Melsele" },
                    { new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5451f43a-2ca1-41e1-bbd2-01602490383d"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4") },
                    { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"), "Franckaert", new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"), "Jansma", new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"), "Vissers", new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b"), "Depardieu", new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("4db9a45e-7658-4cff-9e0e-9dc0e679380f"), "Van Overmeire", new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f") },
                    { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("ce5a9693-daf5-45ad-9ba4-33f4800f3635"), "Merckx", new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"), "Oranje zadel" },
                    { new Guid("6eb45bc2-d051-4289-ba41-c9ed7ee0644a"), "B-Twin", new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"), "Zwart zadel" },
                    { new Guid("2bb5b9c3-029f-45c5-9345-b4ffac6e5263"), "Moldava", new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("2bb5b9c3-029f-45c5-9345-b4ffac6e5263"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6eb45bc2-d051-4289-ba41-c9ed7ee0644a"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("ce5a9693-daf5-45ad-9ba4-33f4800f3635"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5451f43a-2ca1-41e1-bbd2-01602490383d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4db9a45e-7658-4cff-9e0e-9dc0e679380f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f87a422b-d134-40f3-bdad-8d9259698172"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"));

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
    }
}
