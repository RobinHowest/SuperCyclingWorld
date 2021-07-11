using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class NewSeedLinkClubAndSupporterTestLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("267aa54d-642d-4ee0-a0de-0ce2432da23f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("69e138a1-cda0-46c4-bd3b-7e9cd3bfc3d7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("70f9c5ed-ca91-4613-819d-3582c8f44d59"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("16297bba-af01-4512-89bf-e96382a7c16e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("23e640f1-2fe4-472e-8769-cee566dd3f8f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("47d04e37-4de9-4a46-9869-ea460c47f8af"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4933c2eb-350b-4217-b657-a7858f5b75bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("588c4892-ef3d-4226-8407-8079ca405d0e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6d353a6c-4815-433f-b6f0-6d3e56b5dd79"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("78b4f8c5-b7ab-48a7-a221-78e300fdbde2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e3192694-659d-4023-8d98-1ae0cff16581"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c03c760-4f46-47f8-a68f-c44ca3bb4033"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("177ce8bf-7a85-4acc-9b1e-71f970777ef5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("495ead54-0b1c-4c9a-a331-40c55546743a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4bece46d-cc32-4e45-8e39-c0c90773c603"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4fe826ae-d931-4b35-9874-f4f7040d91a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5930de5d-cac0-4ac6-8ffb-40d712e63c64"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("59a36da6-8d4f-4402-a664-2c18626aeba2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7337c55a-159e-4a9c-ab86-c2a0af7fe188"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7f288331-e21d-46f4-849e-7a03ce997007"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("853223ee-ed78-4337-aa76-708402e63b47"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d1f45fc-090e-4317-9cb0-14d89d1ecf07"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a97df5a7-6d20-414f-8432-2a47fcf2a61f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bb9990a1-af16-447e-bc2f-d1592c98cca8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e0d3c513-ab26-4a0e-9b4c-41d11e462ffb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e9b5a5c2-5355-4ae9-a33c-d51359e6d87f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ed75c951-dbbd-4bbc-8240-760d2e9a399c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c53539b6-7052-43fc-9904-43dec517109f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), 0, null, "WTC", 2001 },
                    { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), 0, null, "DCTV", 2016 },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c7c50059-733e-400a-baca-05deeda0ee5c"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("925fa4a8-66fa-4a0d-bafb-ffd9a768d00d"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("543e6606-6e86-4531-88ca-1d40f53cdbbb"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("b1d69ae7-6944-43aa-aa8d-f57119649c9e"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("62d72360-960c-4d7c-9a60-e2e453c20a3a"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("43580eb5-2bab-4b18-8ecf-00c36359a390"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("a868f236-eb75-4c22-bdc7-df1cd35a0e25"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("38e79f1b-104d-4330-bb18-196338b39961"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") },
                    { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") },
                    { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") },
                    { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("a749db73-5685-4ca0-988b-66542f682867"), "Hazard", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("a466b2c5-6ee3-4fd5-8a9f-93a537240d3e"), "Debruyne", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("140bd296-576d-4b4d-9627-c1c3dd8afa52"), "Garnaal", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("1e6a37ff-fb9c-4cc1-a9b0-d51c2a3f03e2"), "Donckerwolcke", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("0e1b3078-48fd-4858-be95-a165893af4fb"), "Depardieu", new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("ff3989a6-91d0-41c9-966b-268992751ec6"), "Evenepoel", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"), "Vissers", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("cc64df3b-3e86-4305-9802-a8d27f92fd32"), "Zalinski", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("e7ae4a4c-272b-4c76-a86c-e0471a87ce1f"), "VanHoof", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("fdac2b86-3bd7-406b-bdb3-4ab70b232374"), "Beukelaer", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("3700bb24-cf66-47ea-b0fb-ee6e8ef15ca0"), "Brokkenpap", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"), "Franckaert", new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("18e49739-f643-49e3-a99f-6aad33d20867"), "Mertens", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("a30718a8-9943-485e-ba96-9e9ba37f9340"), "Scarlet", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("97eae049-a3db-419f-9988-51a025851bdf"), "Jansma", new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("3b4e80ba-9abb-43d3-8d7c-5aadbcf803e6"), "Bambino", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("63a74f96-11da-4087-b5f1-0dd2e4cce760"), "Mega", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("8b0e1450-b57a-4076-a1fc-a3419fa13a94"), "Camara", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("50c9a0a3-5397-4266-a384-d01c0069780a"), "Vanderplas", new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("c97dda4e-fff0-4b35-b676-ea4192768dc7"), "Van Overmeire", new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") },
                    { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa") },
                    { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2") },
                    { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") },
                    { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("30322374-1319-4b9f-b9f9-e557eedfca40"), "B-Twin", new Guid("97eae049-a3db-419f-9988-51a025851bdf"), "Zwart zadel" },
                    { new Guid("bb6ac65c-2a35-430c-a22e-9b44c07a5d94"), "Merckx", new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"), "Oranje zadel" },
                    { new Guid("6122db57-9544-4efb-935f-7138a1a723d8"), "Moldava", new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"), new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("0e1b3078-48fd-4858-be95-a165893af4fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"), new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"), new Guid("97eae049-a3db-419f-9988-51a025851bdf") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("30322374-1319-4b9f-b9f9-e557eedfca40"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6122db57-9544-4efb-935f-7138a1a723d8"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bb6ac65c-2a35-430c-a22e-9b44c07a5d94"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("38e79f1b-104d-4330-bb18-196338b39961"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("43580eb5-2bab-4b18-8ecf-00c36359a390"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("543e6606-6e86-4531-88ca-1d40f53cdbbb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("62d72360-960c-4d7c-9a60-e2e453c20a3a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("925fa4a8-66fa-4a0d-bafb-ffd9a768d00d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a868f236-eb75-4c22-bdc7-df1cd35a0e25"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b1d69ae7-6944-43aa-aa8d-f57119649c9e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c7c50059-733e-400a-baca-05deeda0ee5c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("140bd296-576d-4b4d-9627-c1c3dd8afa52"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("18e49739-f643-49e3-a99f-6aad33d20867"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e6a37ff-fb9c-4cc1-a9b0-d51c2a3f03e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3700bb24-cf66-47ea-b0fb-ee6e8ef15ca0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3b4e80ba-9abb-43d3-8d7c-5aadbcf803e6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("50c9a0a3-5397-4266-a384-d01c0069780a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("63a74f96-11da-4087-b5f1-0dd2e4cce760"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8b0e1450-b57a-4076-a1fc-a3419fa13a94"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a30718a8-9943-485e-ba96-9e9ba37f9340"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a466b2c5-6ee3-4fd5-8a9f-93a537240d3e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a749db73-5685-4ca0-988b-66542f682867"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c97dda4e-fff0-4b35-b676-ea4192768dc7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cc64df3b-3e86-4305-9802-a8d27f92fd32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e7ae4a4c-272b-4c76-a86c-e0471a87ce1f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fdac2b86-3bd7-406b-bdb3-4ab70b232374"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff3989a6-91d0-41c9-966b-268992751ec6"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f3479a57-9075-4c49-815e-7061cdf2ad10"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a629dd5-8b60-4bce-8f05-d4ed951198bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1c833a1d-3e60-4ae8-b5b0-40102bb70cab"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dc282bd8-d3bd-4ab7-802a-e26943a9216b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e8da2a01-f5af-4e6c-b5a7-dd68ae811211"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0e1b3078-48fd-4858-be95-a165893af4fb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("277cc112-0e49-4036-b7d9-a53b9e80e8aa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("94fcc1b9-cd4b-420c-b472-36195e3f09a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("97eae049-a3db-419f-9988-51a025851bdf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0658c3e5-7e8d-4dd6-afad-fc97060ab561"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("895d9fee-29d0-45c3-ae1a-44ecc7a45dea"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("be1279c1-c6f0-4097-8fc2-bbdeb1e67908"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("fe4c6c97-7507-42a4-a3cb-8094a4c68cb8"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), 0, null, "WTC", 2001 },
                    { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), 0, null, "DCTV", 2016 },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("16297bba-af01-4512-89bf-e96382a7c16e"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("6d353a6c-4815-433f-b6f0-6d3e56b5dd79"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("e3192694-659d-4023-8d98-1ae0cff16581"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("78b4f8c5-b7ab-48a7-a221-78e300fdbde2"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("23e640f1-2fe4-472e-8769-cee566dd3f8f"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("588c4892-ef3d-4226-8407-8079ca405d0e"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("47d04e37-4de9-4a46-9869-ea460c47f8af"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("4933c2eb-350b-4217-b657-a7858f5b75bd"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") },
                    { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") },
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("4bece46d-cc32-4e45-8e39-c0c90773c603"), "Zalinski", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("bb9990a1-af16-447e-bc2f-d1592c98cca8"), "VanHoof", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("5930de5d-cac0-4ac6-8ffb-40d712e63c64"), "Beukelaer", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("ed75c951-dbbd-4bbc-8240-760d2e9a399c"), "Mega", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("e9b5a5c2-5355-4ae9-a33c-d51359e6d87f"), "Camara", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("c53539b6-7052-43fc-9904-43dec517109f"), "Depardieu", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("e0d3c513-ab26-4a0e-9b4c-41d11e462ffb"), "Evenepoel", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("495ead54-0b1c-4c9a-a331-40c55546743a"), "Hazard", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("7f288331-e21d-46f4-849e-7a03ce997007"), "Bambino", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("177ce8bf-7a85-4acc-9b1e-71f970777ef5"), "Vanderplas", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"), "Franckaert", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("4fe826ae-d931-4b35-9874-f4f7040d91a2"), "Brokkenpap", new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("9d1f45fc-090e-4317-9cb0-14d89d1ecf07"), "Debruyne", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("a97df5a7-6d20-414f-8432-2a47fcf2a61f"), "Scarlet", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("853223ee-ed78-4337-aa76-708402e63b47"), "Garnaal", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("59a36da6-8d4f-4402-a664-2c18626aeba2"), "Donckerwolcke", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("7337c55a-159e-4a9c-ab86-c2a0af7fe188"), "Mertens", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("0c03c760-4f46-47f8-a68f-c44ca3bb4033"), "Van Overmeire", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"), "Vissers", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"), "Jansma", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") },
                    { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2") },
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536") },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") },
                    { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("69e138a1-cda0-46c4-bd3b-7e9cd3bfc3d7"), "B-Twin", new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"), "Zwart zadel" },
                    { new Guid("267aa54d-642d-4ee0-a0de-0ce2432da23f"), "Merckx", new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"), "Oranje zadel" },
                    { new Guid("70f9c5ed-ca91-4613-819d-3582c8f44d59"), "Moldava", new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"), "Geel zadel" }
                });
        }
    }
}
