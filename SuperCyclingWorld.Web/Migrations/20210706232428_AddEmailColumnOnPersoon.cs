using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddEmailColumnOnPersoon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("451a128d-dd41-439f-a07e-d4a6de27710f"), new Guid("e53bcc24-fc3e-48ce-bf54-712ccc272356") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e1b15047-388e-43ec-be1c-78822d5d315e"), new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("377622a2-027a-4f94-993a-92d1d2899202"), new Guid("9c8b457f-c0df-4d55-b121-86e110f33687") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad"), new Guid("260c4704-9b2d-4726-9a51-ffadf0f45cb1") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("868ec03e-abf6-465f-8dbe-54185fdad110"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("cf458776-6f4b-4854-b818-196017795c1f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e8aa8728-495c-477e-adf5-8ab7c3c3a174"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("527dbd35-8ee5-4882-8a1b-00771948cb3a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("23b2ee0c-d072-4646-aabe-99d23220952f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3bbef697-8e53-4a4c-89d0-0f1366b172db"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2283b276-d6a7-4df2-8d7e-0ff1ec25b66f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("451a128d-dd41-439f-a07e-d4a6de27710f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("377622a2-027a-4f94-993a-92d1d2899202"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e53bcc24-fc3e-48ce-bf54-712ccc272356"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("260c4704-9b2d-4726-9a51-ffadf0f45cb1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9c8b457f-c0df-4d55-b121-86e110f33687"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fc007e8a-abb4-4954-8047-32bb8af9435d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("313adabd-8d02-44f8-bc32-cf40bfad69ac"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("51b2c56c-6557-44e9-9973-412548c503de"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e1b15047-388e-43ec-be1c-78822d5d315e"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Wielrenners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Supporters",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Wielrenners");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Supporters");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("e1b15047-388e-43ec-be1c-78822d5d315e"), "WTC" },
                    { new Guid("51b2c56c-6557-44e9-9973-412548c503de"), "DCTV" },
                    { new Guid("451a128d-dd41-439f-a07e-d4a6de27710f"), "De lustige rijders" },
                    { new Guid("313adabd-8d02-44f8-bc32-cf40bfad69ac"), "WTC Melsele" },
                    { new Guid("2283b276-d6a7-4df2-8d7e-0ff1ec25b66f"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad"), "The Pooh", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("e53bcc24-fc3e-48ce-bf54-712ccc272356"), "Van Achtmaal", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("527dbd35-8ee5-4882-8a1b-00771948cb3a"), "VanKerkhove", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("377622a2-027a-4f94-993a-92d1d2899202"), "Kronenburg", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("e1b15047-388e-43ec-be1c-78822d5d315e"), new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad") },
                    { new Guid("451a128d-dd41-439f-a07e-d4a6de27710f"), new Guid("e53bcc24-fc3e-48ce-bf54-712ccc272356") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("fc007e8a-abb4-4954-8047-32bb8af9435d"), "Franckaert", new Guid("e1b15047-388e-43ec-be1c-78822d5d315e"), new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Robin" },
                    { new Guid("260c4704-9b2d-4726-9a51-ffadf0f45cb1"), "Jansma", new Guid("51b2c56c-6557-44e9-9973-412548c503de"), new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Johanna" },
                    { new Guid("3bbef697-8e53-4a4c-89d0-0f1366b172db"), "Vissers", new Guid("451a128d-dd41-439f-a07e-d4a6de27710f"), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Bert" },
                    { new Guid("9c8b457f-c0df-4d55-b121-86e110f33687"), "Depardieu", new Guid("313adabd-8d02-44f8-bc32-cf40bfad69ac"), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Gerard" },
                    { new Guid("23b2ee0c-d072-4646-aabe-99d23220952f"), "Van Overmeire", new Guid("2283b276-d6a7-4df2-8d7e-0ff1ec25b66f"), new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("8a57ca16-8219-459a-bf9d-55a069d8a7ad"), new Guid("260c4704-9b2d-4726-9a51-ffadf0f45cb1") },
                    { new Guid("377622a2-027a-4f94-993a-92d1d2899202"), new Guid("9c8b457f-c0df-4d55-b121-86e110f33687") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("868ec03e-abf6-465f-8dbe-54185fdad110"), "Moldava", new Guid("fc007e8a-abb4-4954-8047-32bb8af9435d"), "Geel zadel" },
                    { new Guid("e8aa8728-495c-477e-adf5-8ab7c3c3a174"), "Merckx", new Guid("260c4704-9b2d-4726-9a51-ffadf0f45cb1"), "Oranje zadel" },
                    { new Guid("cf458776-6f4b-4854-b818-196017795c1f"), "B-Twin", new Guid("9c8b457f-c0df-4d55-b121-86e110f33687"), "Zwart zadel" }
                });
        }
    }
}
