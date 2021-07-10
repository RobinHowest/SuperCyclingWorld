using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class BackToFullSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("043f31a7-f4b1-4f68-9910-790a292c5e53"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("38cf8948-05c4-4d4a-a7df-2b98f945d6e9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7af5048a-03b6-4666-8d0e-780b319bbba5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a26f7abf-4866-4256-9a21-76331f169eb4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d15ea1e1-c72b-496a-be97-d0c8c64b9b01"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), null, "WTC" },
                    { new Guid("0cf2567c-e2a7-4116-a6da-b67ea3ed4e0a"), null, "DCTV" },
                    { new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), null, "De lustige rijders" },
                    { new Guid("0be32fb8-0809-444c-88f5-ee5d80e3adcf"), null, "WTC Melsele" },
                    { new Guid("72ce1fbf-52e4-4605-980f-b33273efc20a"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("01e05cfb-45ab-4248-9590-013456a571dc"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a") },
                    { new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ff028d06-a026-4868-96ca-812c4f3751f1"), "Franckaert", new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Robin" },
                    { new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f"), "Jansma", new Guid("0cf2567c-e2a7-4116-a6da-b67ea3ed4e0a"), null, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Johanna" },
                    { new Guid("613cb985-0b5f-40e1-ac30-a7dcb03d33c5"), "Vissers", new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Bert" },
                    { new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f"), "Depardieu", new Guid("0be32fb8-0809-444c-88f5-ee5d80e3adcf"), null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Gerard" },
                    { new Guid("6cabc8ca-d976-4a9a-b636-d33a406a6c2d"), "Van Overmeire", new Guid("72ce1fbf-52e4-4605-980f-b33273efc20a"), null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"), new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f") },
                    { new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"), new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("18c49d08-64dd-45c2-97c7-2bb3a0f235d5"), "Merckx", new Guid("ff028d06-a026-4868-96ca-812c4f3751f1"), "Oranje zadel" },
                    { new Guid("ab845e97-e794-4ef3-97e9-fbbbe9fee539"), "B-Twin", new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f"), "Zwart zadel" },
                    { new Guid("b7dbf5d3-7cc7-4d4f-9298-4852da1a6d02"), "Moldava", new Guid("613cb985-0b5f-40e1-ac30-a7dcb03d33c5"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"), new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"), new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"), new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"), new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("18c49d08-64dd-45c2-97c7-2bb3a0f235d5"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("ab845e97-e794-4ef3-97e9-fbbbe9fee539"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("b7dbf5d3-7cc7-4d4f-9298-4852da1a6d02"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("01e05cfb-45ab-4248-9590-013456a571dc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6cabc8ca-d976-4a9a-b636-d33a406a6c2d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("72ce1fbf-52e4-4605-980f-b33273efc20a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7900d457-b5e3-476c-b7db-9b9939aebeec"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("994db4f2-8127-46c8-982c-e1f1e2756e8a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dfbf5746-3143-4102-b52c-d0ef2bfc7642"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("613cb985-0b5f-40e1-ac30-a7dcb03d33c5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8abc7ba2-076f-4daa-95bf-c80a8444ad8f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c6feeb72-0643-41c2-ad40-b9e98978828f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff028d06-a026-4868-96ca-812c4f3751f1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0be32fb8-0809-444c-88f5-ee5d80e3adcf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0cf2567c-e2a7-4116-a6da-b67ea3ed4e0a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2572d3f6-06b4-4383-839f-5aa349c2a26c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ea65752f-5d9b-4cf1-93d1-ebe50efe4cd4"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("d15ea1e1-c72b-496a-be97-d0c8c64b9b01"), null, "WTC" },
                    { new Guid("a26f7abf-4866-4256-9a21-76331f169eb4"), null, "DCTV" },
                    { new Guid("043f31a7-f4b1-4f68-9910-790a292c5e53"), null, "De lustige rijders" },
                    { new Guid("38cf8948-05c4-4d4a-a7df-2b98f945d6e9"), null, "WTC Melsele" },
                    { new Guid("7af5048a-03b6-4666-8d0e-780b319bbba5"), null, "The master cyclists" }
                });
        }
    }
}
