using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class MakeLinkWielrennerClubNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("b2e1ff3a-73eb-4c0d-a77a-be0da8566f84"), null, "WTC" },
                    { new Guid("00d08bb8-d5f7-4265-9192-94caa9404ec9"), null, "DCTV" },
                    { new Guid("48867849-c0b0-4b53-837e-39e9aec165bb"), null, "De lustige rijders" },
                    { new Guid("67287cac-8b2e-4ae1-ba22-d2be0b96e66b"), null, "WTC Melsele" },
                    { new Guid("32aca63b-f490-4016-a68e-542ac01b8e9b"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9"), "The Pooh", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Winnie" },
                    { new Guid("325ec1a7-e37d-497e-9d77-d0f4f9a50849"), "Van Achtmaal", null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Thomas" },
                    { new Guid("a3ec6493-a912-4cb1-b4c8-77c9eff052f3"), "VanKerkhove", null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Nico" },
                    { new Guid("c485fcf3-79c2-46fd-a6a6-39396ae2951a"), "Kronenburg", null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("b2e1ff3a-73eb-4c0d-a77a-be0da8566f84"), new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9") },
                    { new Guid("48867849-c0b0-4b53-837e-39e9aec165bb"), new Guid("325ec1a7-e37d-497e-9d77-d0f4f9a50849") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("28b464d7-acb8-4901-82e4-2fec3760dd23"), "Franckaert", new Guid("b2e1ff3a-73eb-4c0d-a77a-be0da8566f84"), null, new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Robin" },
                    { new Guid("0fa40bbc-a8be-470d-91d4-35314132af86"), "Jansma", new Guid("00d08bb8-d5f7-4265-9192-94caa9404ec9"), null, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Johanna" },
                    { new Guid("0cbcd1b1-c221-4057-af34-ddcaf7def7e8"), "Vissers", new Guid("48867849-c0b0-4b53-837e-39e9aec165bb"), null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Bert" },
                    { new Guid("8af338af-4036-4de0-b8e8-ac78266ad774"), "Depardieu", new Guid("67287cac-8b2e-4ae1-ba22-d2be0b96e66b"), null, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Gerard" },
                    { new Guid("61269fd3-6696-44f6-bb71-55bca62f599c"), "Van Overmeire", new Guid("32aca63b-f490-4016-a68e-542ac01b8e9b"), null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9"), new Guid("0fa40bbc-a8be-470d-91d4-35314132af86") },
                    { new Guid("c485fcf3-79c2-46fd-a6a6-39396ae2951a"), new Guid("8af338af-4036-4de0-b8e8-ac78266ad774") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("91d29a02-e128-4281-a77c-c2c70dab3e63"), "Merckx", new Guid("28b464d7-acb8-4901-82e4-2fec3760dd23"), "Oranje zadel" },
                    { new Guid("96541709-35c6-4b4a-a80a-66f3a4fa0480"), "B-Twin", new Guid("0fa40bbc-a8be-470d-91d4-35314132af86"), "Zwart zadel" },
                    { new Guid("159f2c00-3d7b-4b87-80f5-2fcaa88bfb11"), "Moldava", new Guid("0cbcd1b1-c221-4057-af34-ddcaf7def7e8"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("48867849-c0b0-4b53-837e-39e9aec165bb"), new Guid("325ec1a7-e37d-497e-9d77-d0f4f9a50849") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b2e1ff3a-73eb-4c0d-a77a-be0da8566f84"), new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c485fcf3-79c2-46fd-a6a6-39396ae2951a"), new Guid("8af338af-4036-4de0-b8e8-ac78266ad774") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9"), new Guid("0fa40bbc-a8be-470d-91d4-35314132af86") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("159f2c00-3d7b-4b87-80f5-2fcaa88bfb11"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("91d29a02-e128-4281-a77c-c2c70dab3e63"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("96541709-35c6-4b4a-a80a-66f3a4fa0480"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a3ec6493-a912-4cb1-b4c8-77c9eff052f3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("61269fd3-6696-44f6-bb71-55bca62f599c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("32aca63b-f490-4016-a68e-542ac01b8e9b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("325ec1a7-e37d-497e-9d77-d0f4f9a50849"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c485fcf3-79c2-46fd-a6a6-39396ae2951a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e39f6eb7-0bd3-47df-8502-070ed309c3e9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0cbcd1b1-c221-4057-af34-ddcaf7def7e8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0fa40bbc-a8be-470d-91d4-35314132af86"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("28b464d7-acb8-4901-82e4-2fec3760dd23"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8af338af-4036-4de0-b8e8-ac78266ad774"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("00d08bb8-d5f7-4265-9192-94caa9404ec9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("48867849-c0b0-4b53-837e-39e9aec165bb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("67287cac-8b2e-4ae1-ba22-d2be0b96e66b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b2e1ff3a-73eb-4c0d-a77a-be0da8566f84"));

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
    }
}
