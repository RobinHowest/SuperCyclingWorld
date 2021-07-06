using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddPaswoordOnPersonen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d5f1c49b-229a-4083-9844-b60ac2ecdb5b"), new Guid("2b2e839d-0162-4d34-872a-0061c9e69aa0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ee7adf43-cf28-4fad-ad69-4fc90fb2a364"), new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("7c8199a3-438a-4428-96e5-512608b93389"), new Guid("ef006d70-5fd2-497a-97db-ab6537c1d12b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721"), new Guid("030f213f-b261-4ec9-bfc7-0a93444f64b2") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0ca56df7-1fcd-4b7d-b2ec-a0c2bf620917"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("4066a619-f202-4470-9361-cedaf7a300ff"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("98420178-a094-4b36-8c2e-56684e505ad6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d7c0b553-0de7-4e76-b898-9d78c71538f7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1392be3c-7d23-4fa8-baf9-811e8c6c9130"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("99f56b9f-22b1-4928-9925-f505ca1c6dc7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("76c5c639-a23d-4391-8074-6a695b6a8eec"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c49b-229a-4083-9844-b60ac2ecdb5b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2b2e839d-0162-4d34-872a-0061c9e69aa0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7c8199a3-438a-4428-96e5-512608b93389"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("030f213f-b261-4ec9-bfc7-0a93444f64b2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d5ede78c-e319-44df-9f37-55ed626ce1a3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef006d70-5fd2-497a-97db-ab6537c1d12b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("410ffefd-d2c1-4d0c-a755-6613a119c2af"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("54e989d9-134c-45c0-b43e-3479b9325dd5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ee7adf43-cf28-4fad-ad69-4fc90fb2a364"));

            migrationBuilder.AddColumn<string>(
                name: "Paswoord",
                table: "Wielrenners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paswoord",
                table: "Supporters",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Paswoord",
                table: "Wielrenners");

            migrationBuilder.DropColumn(
                name: "Paswoord",
                table: "Supporters");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("ee7adf43-cf28-4fad-ad69-4fc90fb2a364"), "WTC" },
                    { new Guid("54e989d9-134c-45c0-b43e-3479b9325dd5"), "DCTV" },
                    { new Guid("d5f1c49b-229a-4083-9844-b60ac2ecdb5b"), "De lustige rijders" },
                    { new Guid("410ffefd-d2c1-4d0c-a755-6613a119c2af"), "WTC Melsele" },
                    { new Guid("76c5c639-a23d-4391-8074-6a695b6a8eec"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "GeboorteDatum", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721"), "The Pooh", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winnie" },
                    { new Guid("2b2e839d-0162-4d34-872a-0061c9e69aa0"), "Van Achtmaal", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas" },
                    { new Guid("d7c0b553-0de7-4e76-b898-9d78c71538f7"), "VanKerkhove", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nico" },
                    { new Guid("7c8199a3-438a-4428-96e5-512608b93389"), "Kronenburg", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("ee7adf43-cf28-4fad-ad69-4fc90fb2a364"), new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721") },
                    { new Guid("d5f1c49b-229a-4083-9844-b60ac2ecdb5b"), new Guid("2b2e839d-0162-4d34-872a-0061c9e69aa0") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "GeboorteDatum", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d5ede78c-e319-44df-9f37-55ed626ce1a3"), "Franckaert", new Guid("ee7adf43-cf28-4fad-ad69-4fc90fb2a364"), new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robin" },
                    { new Guid("030f213f-b261-4ec9-bfc7-0a93444f64b2"), "Jansma", new Guid("54e989d9-134c-45c0-b43e-3479b9325dd5"), new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johanna" },
                    { new Guid("99f56b9f-22b1-4928-9925-f505ca1c6dc7"), "Vissers", new Guid("d5f1c49b-229a-4083-9844-b60ac2ecdb5b"), new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bert" },
                    { new Guid("ef006d70-5fd2-497a-97db-ab6537c1d12b"), "Depardieu", new Guid("410ffefd-d2c1-4d0c-a755-6613a119c2af"), new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerard" },
                    { new Guid("1392be3c-7d23-4fa8-baf9-811e8c6c9130"), "Van Overmeire", new Guid("76c5c639-a23d-4391-8074-6a695b6a8eec"), new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("eb6af8c6-8ef0-4626-a91f-63d8d186b721"), new Guid("030f213f-b261-4ec9-bfc7-0a93444f64b2") },
                    { new Guid("7c8199a3-438a-4428-96e5-512608b93389"), new Guid("ef006d70-5fd2-497a-97db-ab6537c1d12b") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("0ca56df7-1fcd-4b7d-b2ec-a0c2bf620917"), "Moldava", new Guid("d5ede78c-e319-44df-9f37-55ed626ce1a3"), "Geel zadel" },
                    { new Guid("4066a619-f202-4470-9361-cedaf7a300ff"), "Merckx", new Guid("030f213f-b261-4ec9-bfc7-0a93444f64b2"), "Oranje zadel" },
                    { new Guid("98420178-a094-4b36-8c2e-56684e505ad6"), "B-Twin", new Guid("ef006d70-5fd2-497a-97db-ab6537c1d12b"), "Zwart zadel" }
                });
        }
    }
}
