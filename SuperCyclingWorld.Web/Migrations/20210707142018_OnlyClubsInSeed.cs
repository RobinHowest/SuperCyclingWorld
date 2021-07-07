using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class OnlyClubsInSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("073323f8-8958-471b-8d8e-73c506f2ea3c"), new Guid("09e8bd9f-92c9-45ad-a258-86391670126d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2c3cd140-94ed-438a-843d-4490077aa6a2"), new Guid("14347ccb-e9ca-4199-9f87-7a178f156796") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("09e8bd9f-92c9-45ad-a258-86391670126d"), new Guid("6e0dce39-cf21-4cc4-9311-11763db6fa7e") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a702386b-f7c1-437d-a856-64a498699429"), new Guid("a23dc392-e058-419c-85b9-d854fd204b20") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5384c599-c941-425c-b190-75513408c3c7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("81b3f9de-6de5-4a7d-b35a-4d1dea71f45f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("cdb3940c-dd23-45c4-b05b-702ae034c28e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f9ea5789-5ed5-417d-a8f8-07777b93fda5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("62f78622-1b4e-49e5-a0dd-4e17996eff9b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a1cda936-9e09-43ba-947f-4372b4b1ed1b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2c3cd140-94ed-438a-843d-4490077aa6a2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8fc6d591-b3cd-479f-810f-e1628359decd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("09e8bd9f-92c9-45ad-a258-86391670126d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("14347ccb-e9ca-4199-9f87-7a178f156796"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a702386b-f7c1-437d-a856-64a498699429"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0dc5483e-c088-4b7f-aa0d-b48b66d794ab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6e0dce39-cf21-4cc4-9311-11763db6fa7e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a23dc392-e058-419c-85b9-d854fd204b20"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("073323f8-8958-471b-8d8e-73c506f2ea3c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3281084b-a7b7-4568-859b-1de8b4e65148"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ffb79e00-99c6-479c-a332-f3ab9206754b"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("073323f8-8958-471b-8d8e-73c506f2ea3c"), "WTC" },
                    { new Guid("ffb79e00-99c6-479c-a332-f3ab9206754b"), "DCTV" },
                    { new Guid("2c3cd140-94ed-438a-843d-4490077aa6a2"), "De lustige rijders" },
                    { new Guid("3281084b-a7b7-4568-859b-1de8b4e65148"), "WTC Melsele" },
                    { new Guid("8fc6d591-b3cd-479f-810f-e1628359decd"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("09e8bd9f-92c9-45ad-a258-86391670126d"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("14347ccb-e9ca-4199-9f87-7a178f156796"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("f9ea5789-5ed5-417d-a8f8-07777b93fda5"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("a702386b-f7c1-437d-a856-64a498699429"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("073323f8-8958-471b-8d8e-73c506f2ea3c"), new Guid("09e8bd9f-92c9-45ad-a258-86391670126d") },
                    { new Guid("2c3cd140-94ed-438a-843d-4490077aa6a2"), new Guid("14347ccb-e9ca-4199-9f87-7a178f156796") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("0dc5483e-c088-4b7f-aa0d-b48b66d794ab"), "Franckaert", new Guid("073323f8-8958-471b-8d8e-73c506f2ea3c"), null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Robin" },
                    { new Guid("6e0dce39-cf21-4cc4-9311-11763db6fa7e"), "Jansma", new Guid("ffb79e00-99c6-479c-a332-f3ab9206754b"), null, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Johanna" },
                    { new Guid("62f78622-1b4e-49e5-a0dd-4e17996eff9b"), "Vissers", new Guid("2c3cd140-94ed-438a-843d-4490077aa6a2"), null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Bert" },
                    { new Guid("a23dc392-e058-419c-85b9-d854fd204b20"), "Depardieu", new Guid("3281084b-a7b7-4568-859b-1de8b4e65148"), null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Gerard" },
                    { new Guid("a1cda936-9e09-43ba-947f-4372b4b1ed1b"), "Van Overmeire", new Guid("8fc6d591-b3cd-479f-810f-e1628359decd"), null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("09e8bd9f-92c9-45ad-a258-86391670126d"), new Guid("6e0dce39-cf21-4cc4-9311-11763db6fa7e") },
                    { new Guid("a702386b-f7c1-437d-a856-64a498699429"), new Guid("a23dc392-e058-419c-85b9-d854fd204b20") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("5384c599-c941-425c-b190-75513408c3c7"), "Moldava", new Guid("0dc5483e-c088-4b7f-aa0d-b48b66d794ab"), "Geel zadel" },
                    { new Guid("cdb3940c-dd23-45c4-b05b-702ae034c28e"), "Merckx", new Guid("6e0dce39-cf21-4cc4-9311-11763db6fa7e"), "Oranje zadel" },
                    { new Guid("81b3f9de-6de5-4a7d-b35a-4d1dea71f45f"), "B-Twin", new Guid("a23dc392-e058-419c-85b9-d854fd204b20"), "Zwart zadel" }
                });
        }
    }
}
