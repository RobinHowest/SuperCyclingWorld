using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class DateTimeToPersoon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), new Guid("61d87552-0514-4612-b64d-f783da4b26b3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"), new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("61d87552-0514-4612-b64d-f783da4b26b3"), new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("042c040e-e93b-4a41-982f-80c30e59855f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("40ddb9ad-c0ef-4183-9d84-0c7b67d042e9"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f27c456f-c649-470f-a4f3-513b046f6a17"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3633e9cb-8bf7-4324-8500-fe0a67516e28"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("10df0c5f-b9ee-43d4-aacb-b924e8269378"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("de154ae1-d8c0-4412-baf9-4fa9a0298c87"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6434fc64-6499-461b-ab4e-cbefaeafa087"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("61d87552-0514-4612-b64d-f783da4b26b3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff336620-9855-4e74-93d7-a2bf92296596"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7268ce67-24f3-403a-9179-ffee1adca253"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("79c660e4-8667-4e60-abe3-286d5f49007f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("abe765b3-8623-40ef-8e35-86d372a23698"));

            migrationBuilder.AddColumn<DateTime>(
                name: "GeboorteDatum",
                table: "Wielrenners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GeboorteDatum",
                table: "Supporters",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "GeboorteDatum",
                table: "Wielrenners");

            migrationBuilder.DropColumn(
                name: "GeboorteDatum",
                table: "Supporters");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), "WTC" },
                    { new Guid("79c660e4-8667-4e60-abe3-286d5f49007f"), "DCTV" },
                    { new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), "De lustige rijders" },
                    { new Guid("7268ce67-24f3-403a-9179-ffee1adca253"), "WTC Melsele" },
                    { new Guid("6434fc64-6499-461b-ab4e-cbefaeafa087"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("61d87552-0514-4612-b64d-f783da4b26b3"), "The Pooh", "Winnie" },
                    { new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0"), "Van Achtmaal", "Thomas" },
                    { new Guid("3633e9cb-8bf7-4324-8500-fe0a67516e28"), "VanKerkhove", "Nico" },
                    { new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"), "Kronenburg", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), new Guid("61d87552-0514-4612-b64d-f783da4b26b3") },
                    { new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ff336620-9855-4e74-93d7-a2bf92296596"), "Franckaert", new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), "Robin" },
                    { new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4"), "Jansma", new Guid("79c660e4-8667-4e60-abe3-286d5f49007f"), "Johanna" },
                    { new Guid("10df0c5f-b9ee-43d4-aacb-b924e8269378"), "Vissers", new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), "Bert" },
                    { new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865"), "Depardieu", new Guid("7268ce67-24f3-403a-9179-ffee1adca253"), "Gerard" },
                    { new Guid("de154ae1-d8c0-4412-baf9-4fa9a0298c87"), "Van Overmeire", new Guid("6434fc64-6499-461b-ab4e-cbefaeafa087"), "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("61d87552-0514-4612-b64d-f783da4b26b3"), new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4") },
                    { new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"), new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("042c040e-e93b-4a41-982f-80c30e59855f"), "Moldava", new Guid("ff336620-9855-4e74-93d7-a2bf92296596"), "Geel zadel" },
                    { new Guid("40ddb9ad-c0ef-4183-9d84-0c7b67d042e9"), "Merckx", new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4"), "Oranje zadel" },
                    { new Guid("f27c456f-c649-470f-a4f3-513b046f6a17"), "B-Twin", new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865"), "Zwart zadel" }
                });
        }
    }
}
