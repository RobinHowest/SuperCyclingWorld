using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class CorrectFullSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
