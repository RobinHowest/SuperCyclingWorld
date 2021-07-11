using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedGemiddeldeKm_h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("692c13ce-404c-4b82-9320-2e82770b0816") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("2238160b-1511-487a-9c79-2d821bd503da") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("692c13ce-404c-4b82-9320-2e82770b0816") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2238160b-1511-487a-9c79-2d821bd503da"), new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2238160b-1511-487a-9c79-2d821bd503da"), new Guid("183a21e6-2b4f-449f-b72c-d8e7173dce84") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b"), new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("692c13ce-404c-4b82-9320-2e82770b0816"), new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fa6c4523-71ed-492e-bb17-28886b900634"), new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fa6c4523-71ed-492e-bb17-28886b900634"), new Guid("54e79755-0ea1-4b33-843c-e6abea8d698f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("9d4f0740-96da-41bc-b2e6-bcf98810c77e"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c5b347a2-3ee4-49d5-a7b1-93f1b0d7f81e"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e74b61d2-0248-4bb5-897a-04fe3b532f11"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0ffeeb0e-993b-4d6f-bc90-0c7bcbfdc3e7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("45229593-9dd4-401e-af9c-5dedbdc81b01"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4b5fc1f5-37e4-4224-8ff4-67deda1e7716"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("58bddbf2-52cb-4c80-8332-a6f96de2489e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("70d93253-e84c-4334-b4a8-406ffdafd17b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7915b66b-af45-4758-be45-6069a83fd491"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e2a83f31-fc2c-44c4-822d-9e642d7c6d5a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e8bc79e7-0e01-4282-9bcf-de460005fbf9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("024af9ca-6f4f-4ebb-bb42-a877c3bd7c19"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("11f7ba47-fa67-441d-b739-efaee24bd2cc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e53316f-f258-4d54-8e0d-bed9ca51bf10"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2571be8c-f2a0-4963-a7ce-48a91daafdc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2de6dbc2-af2e-42e3-94fe-cb7ef4eb95eb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3a9c75b9-7e3a-487b-9050-2d4218e40f5e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3c9c745b-a3f5-4111-911a-5b82dbbc9146"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41ef20f7-4471-4254-9686-3d7f2175f83c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4e2c9925-7efb-4d6d-b906-d4719317b6cc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("55ff3aff-6e50-4803-bba4-a730c54e5491"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5f981b1b-b8f8-40a3-aa2a-8e0b48b2da1a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("601313e2-c21a-440f-9308-618652277aeb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b1a7d555-a131-4b9f-a6a2-2a6a39531283"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("be9c003f-48b5-4822-a5fd-b555d56036cb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7dc1cfd-9cc7-496c-b551-549a1d88ec87"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("db2162c3-d73b-476d-803c-7531fb196789"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2238160b-1511-487a-9c79-2d821bd503da"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("692c13ce-404c-4b82-9320-2e82770b0816"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fa6c4523-71ed-492e-bb17-28886b900634"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("183a21e6-2b4f-449f-b72c-d8e7173dce84"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("54e79755-0ea1-4b33-843c-e6abea8d698f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("beba65da-7a83-4408-b113-c4a710395f2d"));

            migrationBuilder.AddColumn<double>(
                name: "GemiddeldKm_h",
                table: "Wielrenners",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Thropy",
                table: "Records",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), 0, null, "WTC", 2001 },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), 0, null, "DCTV", 2016 },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("de658c6d-7026-4c0f-80bd-7f5ee9311d10"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("e58ae1a5-b332-4ce2-b09f-4daeb2d96efc"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("526bb932-7077-485c-bef5-b36856c9fece"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("71c72ed5-ab63-4941-a503-3b1c8531e147"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("4b147d17-7aa0-4a0f-980b-85b2e484ea35"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("bd022d32-be48-43fa-8eaa-97a370ef1e1e"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("471668ed-d025-498c-933d-2f08f1b413cb"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("c6d37d37-eca8-4cbc-b0d8-04f33c8394d9"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380") },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") },
                    { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") },
                    { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ec863ace-dd46-4ca9-bf70-7d3e0b65c847"), 0, "Bambino", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("a037319a-af21-4726-9484-d4e09c25c9f7"), 0, "Vanderplas", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("3a29e165-fa1e-464d-96bf-927be1b5e86e"), 0, "Beukelaer", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("7de1146f-23ef-4c36-9a39-e28153b07b17"), 0, "Mega", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("f110f1e9-25ff-43ac-800f-ea121047a7a3"), 0, "Van Overmeire", new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("c79cac4d-0c96-432e-abac-54f8ca625053"), 0, "Evenepoel", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("ead0ad24-f8fc-41b9-8c7d-b89a50d8682a"), 0, "Mertens", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("2f679ada-b355-4586-b53e-0f5984c4eb73"), 0, "Camara", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("e0a4680b-a765-4aae-840c-25f36af842ab"), 0, "Brokkenpap", new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("df166eaa-3051-48aa-a6f1-f9fdd3686a5e"), 0, "Garnaal", new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("134d4a68-aec8-4ee7-9a14-7b51b3fb44d1"), 0, "Hazard", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("1270dd91-0279-4527-92fa-86f1e7b09778"), 0, "Zalinski", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("aeabe12a-f63b-4e05-a0c2-6c19963478c6"), 0, "Scarlet", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("8c3d56c3-4213-4c06-8abf-a5803c9fd0ec"), 0, "Donckerwolcke", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c"), 0, "Depardieu", new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("44a872bd-70e7-4f3b-a4d0-babc07cdfbfd"), 0, "VanHoof", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), 0, "Vissers", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), 0, "Jansma", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("9a1a5bc0-aafa-43c1-860e-795164abacab"), 0, "Debruyne", new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), 0, "Franckaert", new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, "202CB962AC59075B964B07152D234B70", 103, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1") },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                    { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") },
                    { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8") },
                    { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") },
                    { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("50bee6d5-22f8-4d2d-9800-6085916851d1"), "Merckx", new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"), "Oranje zadel" },
                    { new Guid("5c1a981a-fbd1-4eb3-8fa1-c14886872b5c"), "B-Twin", new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"), "Zwart zadel" },
                    { new Guid("00cb1983-e5cd-452a-b4aa-bd4b722fd7d1"), "Moldava", new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("101bb1a7-84d0-4143-b384-5718839f1229"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"), new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"), new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"), new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("00cb1983-e5cd-452a-b4aa-bd4b722fd7d1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("50bee6d5-22f8-4d2d-9800-6085916851d1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5c1a981a-fbd1-4eb3-8fa1-c14886872b5c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("471668ed-d025-498c-933d-2f08f1b413cb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4b147d17-7aa0-4a0f-980b-85b2e484ea35"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("526bb932-7077-485c-bef5-b36856c9fece"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("71c72ed5-ab63-4941-a503-3b1c8531e147"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bd022d32-be48-43fa-8eaa-97a370ef1e1e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c6d37d37-eca8-4cbc-b0d8-04f33c8394d9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("de658c6d-7026-4c0f-80bd-7f5ee9311d10"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e58ae1a5-b332-4ce2-b09f-4daeb2d96efc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1270dd91-0279-4527-92fa-86f1e7b09778"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("134d4a68-aec8-4ee7-9a14-7b51b3fb44d1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2f679ada-b355-4586-b53e-0f5984c4eb73"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3a29e165-fa1e-464d-96bf-927be1b5e86e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("44a872bd-70e7-4f3b-a4d0-babc07cdfbfd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7de1146f-23ef-4c36-9a39-e28153b07b17"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8c3d56c3-4213-4c06-8abf-a5803c9fd0ec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a1a5bc0-aafa-43c1-860e-795164abacab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a037319a-af21-4726-9484-d4e09c25c9f7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("aeabe12a-f63b-4e05-a0c2-6c19963478c6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c79cac4d-0c96-432e-abac-54f8ca625053"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("df166eaa-3051-48aa-a6f1-f9fdd3686a5e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e0a4680b-a765-4aae-840c-25f36af842ab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ead0ad24-f8fc-41b9-8c7d-b89a50d8682a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec863ace-dd46-4ca9-bf70-7d3e0b65c847"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f110f1e9-25ff-43ac-800f-ea121047a7a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("101bb1a7-84d0-4143-b384-5718839f1229"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2b695d63-76ec-4aaa-bd20-6bd95353e6ea"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5e3861d2-128d-46c1-9985-eba6a1842602"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a1027e4-625f-4e65-ac40-cb42114f6970"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4ce841f5-7f57-45c7-b012-1d31b96b0be2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ccdfd784-631c-4e89-9400-31ed1d2e5300"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f263f245-b0c5-4abf-84dd-aaebfe510380"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("29af4d31-3e86-4bd7-aec8-e7c8444127d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("40374c2a-b5cd-4119-9272-8dfaf4498ac1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5427e378-1d71-4ef8-b3c2-c575793abd1c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b863afd8-4085-4f07-98fd-b6f7d1114cb8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0c82d8d2-3211-41ea-9f51-ba3fcea92480"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4dd519fc-9851-44d2-b53e-0f030e07ee60"));

            migrationBuilder.DropColumn(
                name: "GemiddeldKm_h",
                table: "Wielrenners");

            migrationBuilder.DropColumn(
                name: "Thropy",
                table: "Records");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), 0, null, "WTC", 2001 },
                    { new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), 0, null, "DCTV", 2016 },
                    { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("45229593-9dd4-401e-af9c-5dedbdc81b01"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("4b5fc1f5-37e4-4224-8ff4-67deda1e7716"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("0ffeeb0e-993b-4d6f-bc90-0c7bcbfdc3e7"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("e8bc79e7-0e01-4282-9bcf-de460005fbf9"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("7915b66b-af45-4758-be45-6069a83fd491"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("2238160b-1511-487a-9c79-2d821bd503da"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("e2a83f31-fc2c-44c4-822d-9e642d7c6d5a"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("692c13ce-404c-4b82-9320-2e82770b0816"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("fa6c4523-71ed-492e-bb17-28886b900634"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("70d93253-e84c-4334-b4a8-406ffdafd17b"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("58bddbf2-52cb-4c80-8332-a6f96de2489e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("2238160b-1511-487a-9c79-2d821bd503da") },
                    { new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b") },
                    { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("692c13ce-404c-4b82-9320-2e82770b0816") },
                    { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("692c13ce-404c-4b82-9320-2e82770b0816") },
                    { new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") },
                    { new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") },
                    { new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") },
                    { new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") },
                    { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("fa6c4523-71ed-492e-bb17-28886b900634") },
                    { new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c7dc1cfd-9cc7-496c-b551-549a1d88ec87"), 0, "Vanderplas", new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("601313e2-c21a-440f-9308-618652277aeb"), 0, "Scarlet", new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("55ff3aff-6e50-4803-bba4-a730c54e5491"), 0, "Mega", new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6"), 0, "Jansma", new Guid("4258f6d9-d0a8-438d-8c45-37138be80126"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("41ef20f7-4471-4254-9686-3d7f2175f83c"), 0, "Hazard", new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("024af9ca-6f4f-4ebb-bb42-a877c3bd7c19"), 0, "Debruyne", new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9"), 0, "Depardieu", new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("b1a7d555-a131-4b9f-a6a2-2a6a39531283"), 0, "Donckerwolcke", new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("2571be8c-f2a0-4963-a7ce-48a91daafdc4"), 0, "Camara", new Guid("e063e21c-c9fe-4932-ac04-249d859e1372"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("4e2c9925-7efb-4d6d-b906-d4719317b6cc"), 0, "Evenepoel", new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("3c9c745b-a3f5-4111-911a-5b82dbbc9146"), 0, "Bambino", new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("11f7ba47-fa67-441d-b739-efaee24bd2cc"), 0, "Brokkenpap", new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("54e79755-0ea1-4b33-843c-e6abea8d698f"), 0, "Vissers", new Guid("23beb59d-8b23-427c-9be0-9e6703e7b812"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("be9c003f-48b5-4822-a5fd-b555d56036cb"), 0, "Zalinski", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("db2162c3-d73b-476d-803c-7531fb196789"), 0, "VanHoof", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("2de6dbc2-af2e-42e3-94fe-cb7ef4eb95eb"), 0, "Mertens", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("1e53316f-f258-4d54-8e0d-bed9ca51bf10"), 0, "Beukelaer", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("5f981b1b-b8f8-40a3-aa2a-8e0b48b2da1a"), 0, "Van Overmeire", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("3a9c75b9-7e3a-487b-9050-2d4218e40f5e"), 0, "Garnaal", new Guid("beba65da-7a83-4408-b113-c4a710395f2d"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("183a21e6-2b4f-449f-b72c-d8e7173dce84"), 0, "Franckaert", new Guid("2fbffee6-e6ee-4bba-a8f7-9390858041a3"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("2238160b-1511-487a-9c79-2d821bd503da"), new Guid("183a21e6-2b4f-449f-b72c-d8e7173dce84") },
                    { new Guid("fa6c4523-71ed-492e-bb17-28886b900634"), new Guid("54e79755-0ea1-4b33-843c-e6abea8d698f") },
                    { new Guid("2238160b-1511-487a-9c79-2d821bd503da"), new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9") },
                    { new Guid("5d54f761-d43b-45c1-8cc4-359a77317f6b"), new Guid("14530110-920d-4705-aa6a-0d3d3ba45cc9") },
                    { new Guid("fa6c4523-71ed-492e-bb17-28886b900634"), new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6") },
                    { new Guid("692c13ce-404c-4b82-9320-2e82770b0816"), new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("9d4f0740-96da-41bc-b2e6-bcf98810c77e"), "Merckx", new Guid("183a21e6-2b4f-449f-b72c-d8e7173dce84"), "Oranje zadel" },
                    { new Guid("c5b347a2-3ee4-49d5-a7b1-93f1b0d7f81e"), "Moldava", new Guid("54e79755-0ea1-4b33-843c-e6abea8d698f"), "Geel zadel" },
                    { new Guid("e74b61d2-0248-4bb5-897a-04fe3b532f11"), "B-Twin", new Guid("025c8358-b101-4155-aec4-c632f4ff8ab6"), "Zwart zadel" }
                });
        }
    }
}
