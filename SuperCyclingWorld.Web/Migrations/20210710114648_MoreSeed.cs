using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class MoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7696e666-3073-492d-902a-9331d25ff234"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("26b3155a-4f02-465d-88f1-4d89a39c50f9"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("34efc7f6-d14c-408a-b2ee-8ffba40f5434"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d2481d9a-9ba0-423d-b5ab-bbbde01714d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("43648603-9ab6-4308-a3ef-6cd796e8fabe"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7e4d4b50-8389-4095-b3b9-45b33e5c5436"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("847666a5-65c7-4e66-bbea-0d123adc5c9f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8e5d72fd-4702-4428-abd9-9c3f8bd7801a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9abb5cd6-71fc-4c7c-957d-7778e3b873ac"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b413ba62-936b-4863-8685-562a6cd78038"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7696e666-3073-492d-902a-9331d25ff234"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), null, "WTC" },
                    { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), null, "DCTV" },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), null, "De lustige rijders" },
                    { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), null, "WTC Melsele" },
                    { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d32fd3a9-74b8-4ce6-a1b5-f99558460cc4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("12eba1aa-892c-4d1e-b30b-84e7373911ab"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("686fb06c-05d9-4872-a97c-110e3637b03e"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("0902b607-8934-4b7c-8a0e-6f4255ef434a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("880d8cb8-11b9-49b6-80fa-0d25669fa478"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("88804fe0-7810-4296-b172-bb6ef1ce802f"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("002325d7-e96d-4301-becf-b92fec46abf4"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("7d39e646-a83e-474a-867e-3fcaf88c1a34"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") },
                    { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") },
                    { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8e011213-ff3b-463b-aef2-cba0d43cfead"), "Evenepoel", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("fa8b0cc9-37f7-4cfc-be42-e56761b76d97"), "Vanderplas", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("ee96e9a9-ac99-462c-b9e8-3e99e33062d8"), "Mega", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("5688cedd-8505-44a3-a6f6-dfb7932d8874"), "Van Overmeire", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("cccb3372-ec39-4de6-a11a-e1e0cef0d2b5"), "Hazard", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("9d59e14a-c17d-45ff-b2a9-3fe783b86f76"), "VanHoof", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("3faa3b48-40f4-4c82-9acf-cab9347c5d3a"), "Brokkenpap", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("0578ed5a-c17d-473f-bf0d-cc4bed869b0a"), "Debruyne", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("6cf6c9fd-07c6-4b52-8410-9ef7d1880f4a"), "Mertens", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("f1f54e7c-2cc1-4c9d-82f9-b68bf07758a5"), "Garnaal", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"), "Vissers", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("5c497e9c-34af-4e48-aa09-8fb77cb862d0"), "Zalinski", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("7b4abb71-98da-4104-b63f-c008961ce82f"), "Beukelaer", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("f7d1bc37-9af3-4af2-a0a0-ab2b845f2c60"), "Donckerwolcke", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"), "Jansma", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("94ebed51-6c44-4b24-96ef-e179a05d9c8b"), "Bambino", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("d90e41f1-86e3-4d77-a770-42f79ebfb06b"), "Scarlet", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("2e227195-99cf-4402-8121-be4bcb7e3ce4"), "Camara", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d"), "Depardieu", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("caeb9ece-702e-4d38-9720-34e351811477"), "Franckaert", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("caeb9ece-702e-4d38-9720-34e351811477") },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") },
                    { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d") },
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") },
                    { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("f59b3acd-5a4c-4c7a-bc11-f90d3185ab6a"), "Merckx", new Guid("caeb9ece-702e-4d38-9720-34e351811477"), "Oranje zadel" },
                    { new Guid("035e420b-da9b-47fd-b284-63721cfec6bd"), "B-Twin", new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"), "Zwart zadel" },
                    { new Guid("5944cd1a-1b61-43c9-a437-1dba6bdd72ab"), "Moldava", new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("caeb9ece-702e-4d38-9720-34e351811477") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("035e420b-da9b-47fd-b284-63721cfec6bd"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5944cd1a-1b61-43c9-a437-1dba6bdd72ab"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f59b3acd-5a4c-4c7a-bc11-f90d3185ab6a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("002325d7-e96d-4301-becf-b92fec46abf4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0902b607-8934-4b7c-8a0e-6f4255ef434a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("12eba1aa-892c-4d1e-b30b-84e7373911ab"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("686fb06c-05d9-4872-a97c-110e3637b03e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7d39e646-a83e-474a-867e-3fcaf88c1a34"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("880d8cb8-11b9-49b6-80fa-0d25669fa478"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("88804fe0-7810-4296-b172-bb6ef1ce802f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d32fd3a9-74b8-4ce6-a1b5-f99558460cc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0578ed5a-c17d-473f-bf0d-cc4bed869b0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2e227195-99cf-4402-8121-be4bcb7e3ce4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3faa3b48-40f4-4c82-9acf-cab9347c5d3a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5688cedd-8505-44a3-a6f6-dfb7932d8874"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5c497e9c-34af-4e48-aa09-8fb77cb862d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6cf6c9fd-07c6-4b52-8410-9ef7d1880f4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7b4abb71-98da-4104-b63f-c008961ce82f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8e011213-ff3b-463b-aef2-cba0d43cfead"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("94ebed51-6c44-4b24-96ef-e179a05d9c8b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d59e14a-c17d-45ff-b2a9-3fe783b86f76"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cccb3372-ec39-4de6-a11a-e1e0cef0d2b5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d90e41f1-86e3-4d77-a770-42f79ebfb06b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ee96e9a9-ac99-462c-b9e8-3e99e33062d8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f1f54e7c-2cc1-4c9d-82f9-b68bf07758a5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f7d1bc37-9af3-4af2-a0a0-ab2b845f2c60"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fa8b0cc9-37f7-4cfc-be42-e56761b76d97"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("caeb9ece-702e-4d38-9720-34e351811477"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), null, "WTC" },
                    { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), null, "DCTV" },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), null, "De lustige rijders" },
                    { new Guid("7696e666-3073-492d-902a-9331d25ff234"), null, "WTC Melsele" },
                    { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") },
                    { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") },
                    { new Guid("7696e666-3073-492d-902a-9331d25ff234"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8e5d72fd-4702-4428-abd9-9c3f8bd7801a"), "Mega", new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("7e4d4b50-8389-4095-b3b9-45b33e5c5436"), "Van Overmeire", new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32"), "Depardieu", new Guid("7696e666-3073-492d-902a-9331d25ff234"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("9abb5cd6-71fc-4c7c-957d-7778e3b873ac"), "Garnaal", new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"), "Vissers", new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("847666a5-65c7-4e66-bbea-0d123adc5c9f"), "Donckerwolcke", new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"), "Jansma", new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("43648603-9ab6-4308-a3ef-6cd796e8fabe"), "Camara", new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("b413ba62-936b-4863-8685-562a6cd78038"), "Brokkenpap", new Guid("7696e666-3073-492d-902a-9331d25ff234"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"), "Franckaert", new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff") },
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") },
                    { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") },
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134") },
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") },
                    { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("d2481d9a-9ba0-423d-b5ab-bbbde01714d0"), "Merckx", new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"), "Oranje zadel" },
                    { new Guid("34efc7f6-d14c-408a-b2ee-8ffba40f5434"), "B-Twin", new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"), "Zwart zadel" },
                    { new Guid("26b3155a-4f02-465d-88f1-4d89a39c50f9"), "Moldava", new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"), "Geel zadel" }
                });
        }
    }
}
