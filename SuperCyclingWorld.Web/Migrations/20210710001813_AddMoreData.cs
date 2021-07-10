using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("2bb5b9c3-029f-45c5-9345-b4ffac6e5263"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6eb45bc2-d051-4289-ba41-c9ed7ee0644a"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("ce5a9693-daf5-45ad-9ba4-33f4800f3635"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5451f43a-2ca1-41e1-bbd2-01602490383d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4db9a45e-7658-4cff-9e0e-9dc0e679380f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f87a422b-d134-40f3-bdad-8d9259698172"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), null, "WTC" },
                    { new Guid("b525fa9c-b993-4366-8711-80a3cca5b163"), null, "DCTV" },
                    { new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), null, "De lustige rijders" },
                    { new Guid("c203f560-6d5d-49e3-ad54-08a929ab9bcf"), null, "WTC Melsele" },
                    { new Guid("f7f9b309-5874-4bba-a411-29fb9250e163"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979") },
                    { new Guid("c203f560-6d5d-49e3-ad54-08a929ab9bcf"), new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979") },
                    { new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514") },
                    { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514") },
                    { new Guid("b525fa9c-b993-4366-8711-80a3cca5b163"), new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413") },
                    { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413") },
                    { new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d") },
                    { new Guid("f7f9b309-5874-4bba-a411-29fb9250e163"), new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c5d3923c-7277-46e9-acb7-057c915fc35a"), "Franckaert", new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("9dee5d07-9324-4faa-ab8f-3d1ad122cfe2"), "Jansma", new Guid("b525fa9c-b993-4366-8711-80a3cca5b163"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("8ea21d26-8860-479d-920f-1234f94fc490"), "Vissers", new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("35267da1-50b3-42e8-b150-d62501ebb305"), "Depardieu", new Guid("c203f560-6d5d-49e3-ad54-08a929ab9bcf"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("81528586-62c4-414a-89c9-5613f847ef08"), "Van Overmeire", new Guid("f7f9b309-5874-4bba-a411-29fb9250e163"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979"), new Guid("9dee5d07-9324-4faa-ab8f-3d1ad122cfe2") },
                    { new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d"), new Guid("35267da1-50b3-42e8-b150-d62501ebb305") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("a9d48cae-6080-4fee-a6bc-8fb798259b4a"), "Merckx", new Guid("c5d3923c-7277-46e9-acb7-057c915fc35a"), "Oranje zadel" },
                    { new Guid("95976d72-83e9-403f-a9d5-3352d1dde34b"), "B-Twin", new Guid("9dee5d07-9324-4faa-ab8f-3d1ad122cfe2"), "Zwart zadel" },
                    { new Guid("15a57e79-be6f-4987-93b6-7f0b4cab549b"), "Moldava", new Guid("8ea21d26-8860-479d-920f-1234f94fc490"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"), new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b525fa9c-b993-4366-8711-80a3cca5b163"), new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c203f560-6d5d-49e3-ad54-08a929ab9bcf"), new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"), new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f7f9b309-5874-4bba-a411-29fb9250e163"), new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d"), new Guid("35267da1-50b3-42e8-b150-d62501ebb305") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979"), new Guid("9dee5d07-9324-4faa-ab8f-3d1ad122cfe2") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("15a57e79-be6f-4987-93b6-7f0b4cab549b"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("95976d72-83e9-403f-a9d5-3352d1dde34b"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("a9d48cae-6080-4fee-a6bc-8fb798259b4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("81528586-62c4-414a-89c9-5613f847ef08"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f7f9b309-5874-4bba-a411-29fb9250e163"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("06bc3217-7455-406a-9f59-9f01f6ccd413"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5c2e5c9a-947b-4e57-a858-df95e0e28514"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b7ed3989-5b95-4d88-88a3-cfeef159d71d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fc77f870-5d67-4b33-9c23-c0fe68d76979"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("35267da1-50b3-42e8-b150-d62501ebb305"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8ea21d26-8860-479d-920f-1234f94fc490"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9dee5d07-9324-4faa-ab8f-3d1ad122cfe2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c5d3923c-7277-46e9-acb7-057c915fc35a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a341cac4-58ba-43ad-bbda-5f703065dd38"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b525fa9c-b993-4366-8711-80a3cca5b163"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c203f560-6d5d-49e3-ad54-08a929ab9bcf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cb3b0acd-aff1-4bab-8428-d5c540d52120"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), null, "WTC" },
                    { new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"), null, "DCTV" },
                    { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), null, "De lustige rijders" },
                    { new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"), null, "WTC Melsele" },
                    { new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5451f43a-2ca1-41e1-bbd2-01602490383d"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4") },
                    { new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), new Guid("1716be00-0b23-43ba-9d56-eed2fbba4904") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"), "Franckaert", new Guid("f40707ac-32f9-4b7e-b083-122278f9efd7"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"), "Jansma", new Guid("f931a331-1c1d-49d5-b282-1fc4e33ba994"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"), "Vissers", new Guid("f87a422b-d134-40f3-bdad-8d9259698172"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b"), "Depardieu", new Guid("46d3e0ce-57a2-4c3a-b84c-735299aec221"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("4db9a45e-7658-4cff-9e0e-9dc0e679380f"), "Van Overmeire", new Guid("06bfe3b4-d3bf-42ee-8f05-33c95ea4aca0"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("c3528ad8-dfcd-4150-bedd-0e7c4e16cbc4"), new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f") },
                    { new Guid("b2107a33-df7e-4192-a1d1-66e2ab85b8f0"), new Guid("5ec1318a-1b45-484f-9cbe-e6a20316199b") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("ce5a9693-daf5-45ad-9ba4-33f4800f3635"), "Merckx", new Guid("4bb3a422-1df2-4dd7-b6e1-eb3d942f8f0d"), "Oranje zadel" },
                    { new Guid("6eb45bc2-d051-4289-ba41-c9ed7ee0644a"), "B-Twin", new Guid("15e26c84-a451-45c7-a113-dcfc75687f8f"), "Zwart zadel" },
                    { new Guid("2bb5b9c3-029f-45c5-9345-b4ffac6e5263"), "Moldava", new Guid("e36ac4b7-840c-4546-bf5c-3064a8552b79"), "Geel zadel" }
                });
        }
    }
}
