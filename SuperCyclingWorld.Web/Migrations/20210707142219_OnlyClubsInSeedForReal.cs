using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class OnlyClubsInSeedForReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"), new Guid("2c81cf54-856a-4132-97c9-4ce658a22823") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"), new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("038cc5ab-ce6e-4cb0-b410-fcb7eee948cd"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("03d04a9c-3993-4310-92ff-2e0b6a67c831"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5b411043-94c1-4b7c-954d-0a1ea059fd5f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6e0cf97a-22bb-455c-9aea-d420b9203c45"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("825bed50-454c-4457-bf6a-8d69366926e7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f4bbf781-6e81-4b06-ab11-a121ed5fca94"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5a12238b-0059-4302-a128-d7992a90f848"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c55f044-a026-42fc-8828-97abf1a8f1f9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c81cf54-856a-4132-97c9-4ce658a22823"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("003522e7-75ae-4933-8866-bc51ac40c7c8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6bfead80-db2a-47ea-973b-43405cc34365"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8741b174-cb8b-414e-adda-ca94fa171929"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("a682ab81-8b73-4346-a29c-293f9b62cf9a"), "WTC" },
                    { new Guid("0c9e7b9c-f643-40d6-8426-ba23db9b4d9d"), "DCTV" },
                    { new Guid("58832045-9372-4dd9-aa15-46973fdda82b"), "De lustige rijders" },
                    { new Guid("c4c94bff-c634-4174-9e78-2a3ed2b6a8e2"), "WTC Melsele" },
                    { new Guid("50eb5d04-f085-4424-b5e6-33a5657c047c"), "The master cyclists" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0c9e7b9c-f643-40d6-8426-ba23db9b4d9d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("50eb5d04-f085-4424-b5e6-33a5657c047c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("58832045-9372-4dd9-aa15-46973fdda82b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a682ab81-8b73-4346-a29c-293f9b62cf9a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c4c94bff-c634-4174-9e78-2a3ed2b6a8e2"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), "WTC" },
                    { new Guid("003522e7-75ae-4933-8866-bc51ac40c7c8"), "DCTV" },
                    { new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), "De lustige rijders" },
                    { new Guid("6bfead80-db2a-47ea-973b-43405cc34365"), "WTC Melsele" },
                    { new Guid("5a12238b-0059-4302-a128-d7992a90f848"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("6e0cf97a-22bb-455c-9aea-d420b9203c45"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23") },
                    { new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), new Guid("8cafbb34-d412-4869-97ac-23db601fbf7c") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("2c55f044-a026-42fc-8828-97abf1a8f1f9"), "Franckaert", new Guid("8741b174-cb8b-414e-adda-ca94fa171929"), null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Robin" },
                    { new Guid("2c81cf54-856a-4132-97c9-4ce658a22823"), "Jansma", new Guid("003522e7-75ae-4933-8866-bc51ac40c7c8"), null, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Johanna" },
                    { new Guid("825bed50-454c-4457-bf6a-8d69366926e7"), "Vissers", new Guid("3c6dc0d3-6044-4ce9-ad09-89dfd42cd233"), null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Bert" },
                    { new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef"), "Depardieu", new Guid("6bfead80-db2a-47ea-973b-43405cc34365"), null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Gerard" },
                    { new Guid("f4bbf781-6e81-4b06-ab11-a121ed5fca94"), "Van Overmeire", new Guid("5a12238b-0059-4302-a128-d7992a90f848"), null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("56ee7bbe-ecdd-405b-a37d-d6dd3396ce23"), new Guid("2c81cf54-856a-4132-97c9-4ce658a22823") },
                    { new Guid("62a0815a-64c3-4f53-84f2-7f8819abc7a0"), new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("5b411043-94c1-4b7c-954d-0a1ea059fd5f"), "Moldava", new Guid("2c55f044-a026-42fc-8828-97abf1a8f1f9"), "Geel zadel" },
                    { new Guid("038cc5ab-ce6e-4cb0-b410-fcb7eee948cd"), "Merckx", new Guid("2c81cf54-856a-4132-97c9-4ce658a22823"), "Oranje zadel" },
                    { new Guid("03d04a9c-3993-4310-92ff-2e0b6a67c831"), "B-Twin", new Guid("bb216935-7302-4159-9dd8-86a5d0b2a8ef"), "Zwart zadel" }
                });
        }
    }
}
