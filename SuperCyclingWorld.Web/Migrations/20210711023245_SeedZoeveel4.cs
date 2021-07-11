using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedZoeveel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("1e9c518a-3587-4f0d-a455-7eec7dd553c3"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("3bd9e414-f548-4b6f-b3ab-06a163b3425d"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e48cecb7-0381-462d-b311-70c31585b088"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1676ba06-42a3-4400-9c8f-806449308a17"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a8dc8db-dd3f-4c62-b99d-53bcdaeb818e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25ae9c9d-ef8e-4128-b4da-2d60d39c9d20"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9ae17db2-861e-4c0d-8e18-12c57571ab57"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a988280a-8c13-4d59-9253-264046ed9a60"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("acee2067-e053-4e0c-8011-948c6416ca6a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b20212a3-b556-4a4f-bb70-dfb8872ad84e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bad97b6c-a0d5-4835-bce2-32ee66ecb7f2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04a1b5ff-2ac8-4ea8-846d-0aee440091f6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("07768fe0-aef0-4641-9cfd-adf53ea5eb3b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("10104c9b-c5a8-429c-9ab3-614ba900fb9c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("346a7c39-79be-4a02-814e-fce9f8a78bd7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("603ab875-5194-4110-b55e-2ab0d6333771"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b187433-eff0-4e90-b0d7-5c6c36e7d542"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72dd0c7c-335c-4f99-8ce0-0f5ea95eb148"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("865a7e8a-ec7f-43d0-8080-843c9d9a926f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("874d1982-bf82-4fff-9974-c8517d108ee7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a48e6bd3-b87b-4fda-940b-cb4c85464be6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b406f30e-69fe-45a5-b2a9-5a97f2e3fd6a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ca39562d-fb33-4e47-9468-d52b3784391d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d48d3567-24c6-4f56-a593-fa197ff73e2c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec5193a6-5975-4909-92f7-76dd0524a10a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef44c545-2da0-4b20-99ef-3423b5924713"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0f1650f-0e01-48e3-9e9d-d08943487ea5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("68694416-8004-4879-88f8-95f25bbdc025"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1c9d63a4-57de-4871-816b-194d32806ccf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"));

            migrationBuilder.AddColumn<int>(
                name: "AantalRecords",
                table: "Wielrenners",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AantalRecords",
                table: "Wielrenners");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), 0, null, "WTC", 2001 },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), 0, null, "DCTV", 2016 },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1676ba06-42a3-4400-9c8f-806449308a17"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("9ae17db2-861e-4c0d-8e18-12c57571ab57"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("a988280a-8c13-4d59-9253-264046ed9a60"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("acee2067-e053-4e0c-8011-948c6416ca6a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("1a8dc8db-dd3f-4c62-b99d-53bcdaeb818e"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("bad97b6c-a0d5-4835-bce2-32ee66ecb7f2"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("25ae9c9d-ef8e-4128-b4da-2d60d39c9d20"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("b20212a3-b556-4a4f-bb70-dfb8872ad84e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558") },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                    { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("865a7e8a-ec7f-43d0-8080-843c9d9a926f"), "Hazard", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("874d1982-bf82-4fff-9974-c8517d108ee7"), "VanHoof", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("d48d3567-24c6-4f56-a593-fa197ff73e2c"), "Mega", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("b406f30e-69fe-45a5-b2a9-5a97f2e3fd6a"), "Debruyne", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("1c9d63a4-57de-4871-816b-194d32806ccf"), "Depardieu", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), "Vissers", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("72dd0c7c-335c-4f99-8ce0-0f5ea95eb148"), "Bambino", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("6b187433-eff0-4e90-b0d7-5c6c36e7d542"), "Beukelaer", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("f0f1650f-0e01-48e3-9e9d-d08943487ea5"), "Scarlet", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("603ab875-5194-4110-b55e-2ab0d6333771"), "Garnaal", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("346a7c39-79be-4a02-814e-fce9f8a78bd7"), "Van Overmeire", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("10104c9b-c5a8-429c-9ab3-614ba900fb9c"), "Zalinski", new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("07768fe0-aef0-4641-9cfd-adf53ea5eb3b"), "Brokkenpap", new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("ca39562d-fb33-4e47-9468-d52b3784391d"), "Vanderplas", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("ef44c545-2da0-4b20-99ef-3423b5924713"), "Mertens", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("ec5193a6-5975-4909-92f7-76dd0524a10a"), "Donckerwolcke", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("04a1b5ff-2ac8-4ea8-846d-0aee440091f6"), "Camara", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), "Jansma", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("a48e6bd3-b87b-4fda-940b-cb4c85464be6"), "Evenepoel", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), "Franckaert", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219") },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                    { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc") },
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") },
                    { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("3bd9e414-f548-4b6f-b3ab-06a163b3425d"), "Merckx", new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), "Oranje zadel" },
                    { new Guid("1e9c518a-3587-4f0d-a455-7eec7dd553c3"), "B-Twin", new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), "Zwart zadel" },
                    { new Guid("e48cecb7-0381-462d-b311-70c31585b088"), "Moldava", new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), "Geel zadel" }
                });
        }
    }
}
