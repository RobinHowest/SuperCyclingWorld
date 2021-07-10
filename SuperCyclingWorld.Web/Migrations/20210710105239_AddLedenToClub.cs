using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddLedenToClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), null, "WTC" },
                    { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), null, "DCTV" },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), null, "De lustige rijders" },
                    { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), null, "WTC Melsele" },
                    { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") },
                    { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") },
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") },
                    { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") },
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") },
                    { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"), "Franckaert", new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"), "Jansma", new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"), "Vissers", new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0"), "Depardieu", new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("51dc42b2-26cf-4ce7-82d1-fb2f6b234cb8"), "Van Overmeire", new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), new Guid("f73fac46-1d34-42db-8c25-30a4b564241a") },
                    { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("bfaeafaa-89e5-4561-add2-3eb55bb11078"), "Merckx", new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"), "Oranje zadel" },
                    { new Guid("d1fafbab-50a8-492b-9fa0-552c2d7b8ffe"), "B-Twin", new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"), "Zwart zadel" },
                    { new Guid("de12a019-0bab-4f11-b430-b2278c18b9d3"), "Moldava", new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), new Guid("f73fac46-1d34-42db-8c25-30a4b564241a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bfaeafaa-89e5-4561-add2-3eb55bb11078"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d1fafbab-50a8-492b-9fa0-552c2d7b8ffe"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("de12a019-0bab-4f11-b430-b2278c18b9d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("51dc42b2-26cf-4ce7-82d1-fb2f6b234cb8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("28e28b97-4881-446b-86ac-1075708d2467"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"));

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
    }
}
