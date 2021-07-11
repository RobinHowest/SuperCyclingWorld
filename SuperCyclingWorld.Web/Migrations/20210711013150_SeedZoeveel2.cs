using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedZoeveel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("a7354a08-18eb-4500-8e65-833275050212") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("a7354a08-18eb-4500-8e65-833275050212") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("95ac02ed-22a0-491e-8fb1-b4f4adb641ce"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c17877a5-3f21-4f1e-b1f2-01e73816dc36"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d4fc2144-88c2-40d6-95fb-f9b725e5cf59"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("21135017-d03f-4ff2-825e-84e95da910b7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("489127cb-6c93-425b-9a3f-15ee6f3c03c1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("56e2deb8-e339-4b6a-9489-fddfabaa90d3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5e2b777f-ce67-4920-8e9b-b5db09ca9d88"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7a2c9f6e-dd8a-48f2-805e-f42f791a6af5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("afcc75cc-b658-4714-9a3e-2e2636af02dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b421fb4f-b832-44ca-81e6-80f0325107f5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e5ac6b8d-3c39-4748-b953-55083e9d7c42"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("02f60061-c2ca-4647-bbed-e2a1bfa45493"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("171803c9-62a2-4feb-a3b6-97fcad761ba7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41cc1054-ea2e-47b5-82f0-1dca727687ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4e5c5735-90a6-4f20-997a-c63111d81d32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4fc0968c-f7f7-466c-a011-183bc5b23122"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6c32fc81-0fff-4e3a-b4f6-7995b7ef53fd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6f889fab-da8f-478c-b2fb-582e09e8ce85"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("78d8615c-19eb-4e4b-adaa-6b4a514e0a57"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7a63826a-b3c6-4e7b-8787-1057d46c63b9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("911bc918-dfbb-430d-8728-a919cb838fb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d45e58b-9023-4205-9cc2-7cb06bbee005"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9f96e6ae-80cb-4b54-8dc0-d62202bd1981"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a249de8a-efff-4f75-a241-f8870b4ae98c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c27cc3c9-b1b4-4710-a965-33e7fd8a7446"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e3d489ae-ece1-4c9e-bf39-af037295e01b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e88e7fc1-5e91-4e6f-ae04-ca3a8f3d6d59"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e0b28711-1f52-49b6-a2de-837250874584"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a7354a08-18eb-4500-8e65-833275050212"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8d78d624-d785-4948-b02d-8f6683f59b15"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d6f03a52-053a-425a-b951-54080673b3d2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), 0, null, "WTC", 2001 },
                    { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), 0, null, "DCTV", 2016 },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8f571ad6-b43e-4b7c-82f6-98ee02c967d4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("09ba45f6-741d-4496-81aa-4a32c47cff28"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("6aa5e12e-c657-480f-a50d-dd4ca9af1273"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("4cbfef3b-c60e-405d-8356-d34f9c95f40b"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("54a63cb2-4938-473a-9a60-35f08acd10bc"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("5cb20494-25c6-4179-af48-ce8b6997224b"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("46fa8116-d0d4-46e5-a9cf-b75239dc144c"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065") },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d65ef2bc-6022-4c22-b35c-ec39cacf14e2"), "Hazard", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("6dc0f0ff-efc5-4e22-83c7-1f2273d1eb60"), "Scarlet", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("1b4f7524-0704-4e5b-8bc5-b08923577258"), "Garnaal", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("9f131089-91cc-4b41-9445-3bd7d7224d48"), "Camara", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), "Vissers", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("ce358bbf-7c07-4d63-b7f6-686e7cf80325"), "Zalinski", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("ce776019-6454-45c0-9d9c-8f428ab6c263"), "Donckerwolcke", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8"), "Depardieu", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5dc84776-c3aa-49b3-9e2d-d5a7fdebdd16"), "Mertens", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("5c75f356-7c30-4532-afed-c1b4f46bf0cb"), "Brokkenpap", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), "Franckaert", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("6989fe60-e616-4d67-96de-1bb65409b422"), "Evenepoel", new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("852e4e89-93f1-4a18-86d3-3200ebef635f"), "Vanderplas", new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("160c6efd-3b9d-4f84-94f2-9dad9dec4433"), "Bambino", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("a5434e89-36c8-4a81-a6fe-098626fe7e07"), "VanHoof", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("a5d5c07d-b862-401c-b29e-8d5a096e53a9"), "Beukelaer", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("05e4f932-16c4-4ef7-8d51-ea3d90a6d11a"), "Mega", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("5cacc0e0-033c-499c-be70-bce6319bf057"), "Van Overmeire", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("3ad145aa-a2be-4539-ba6c-695ab6a987b8"), "Debruyne", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), "Jansma", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                    { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c") },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") },
                    { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") },
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("82f91289-258b-4dea-b041-49be98252f0d"), "B-Twin", new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), "Zwart zadel" },
                    { new Guid("5c3475e3-55b8-49d5-b5fd-79d4589466ea"), "Merckx", new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), "Oranje zadel" },
                    { new Guid("1c8eed52-ebc4-4141-a590-6323ceefb266"), "Moldava", new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("1c8eed52-ebc4-4141-a590-6323ceefb266"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5c3475e3-55b8-49d5-b5fd-79d4589466ea"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("82f91289-258b-4dea-b041-49be98252f0d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("09ba45f6-741d-4496-81aa-4a32c47cff28"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("46fa8116-d0d4-46e5-a9cf-b75239dc144c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4cbfef3b-c60e-405d-8356-d34f9c95f40b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("54a63cb2-4938-473a-9a60-35f08acd10bc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5cb20494-25c6-4179-af48-ce8b6997224b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6aa5e12e-c657-480f-a50d-dd4ca9af1273"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8f571ad6-b43e-4b7c-82f6-98ee02c967d4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("05e4f932-16c4-4ef7-8d51-ea3d90a6d11a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("160c6efd-3b9d-4f84-94f2-9dad9dec4433"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1b4f7524-0704-4e5b-8bc5-b08923577258"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3ad145aa-a2be-4539-ba6c-695ab6a987b8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5c75f356-7c30-4532-afed-c1b4f46bf0cb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5cacc0e0-033c-499c-be70-bce6319bf057"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5dc84776-c3aa-49b3-9e2d-d5a7fdebdd16"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6989fe60-e616-4d67-96de-1bb65409b422"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6dc0f0ff-efc5-4e22-83c7-1f2273d1eb60"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("852e4e89-93f1-4a18-86d3-3200ebef635f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9f131089-91cc-4b41-9445-3bd7d7224d48"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a5434e89-36c8-4a81-a6fe-098626fe7e07"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a5d5c07d-b862-401c-b29e-8d5a096e53a9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ce358bbf-7c07-4d63-b7f6-686e7cf80325"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ce776019-6454-45c0-9d9c-8f428ab6c263"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d65ef2bc-6022-4c22-b35c-ec39cacf14e2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("410e49d8-5056-4236-af1c-718fc70c1699"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), 0, null, "WTC", 2001 },
                    { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), 0, null, "DCTV", 2016 },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("56e2deb8-e339-4b6a-9489-fddfabaa90d3"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("b421fb4f-b832-44ca-81e6-80f0325107f5"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("5e2b777f-ce67-4920-8e9b-b5db09ca9d88"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("7a2c9f6e-dd8a-48f2-805e-f42f791a6af5"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("489127cb-6c93-425b-9a3f-15ee6f3c03c1"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("21135017-d03f-4ff2-825e-84e95da910b7"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("afcc75cc-b658-4714-9a3e-2e2636af02dd"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("e5ac6b8d-3c39-4748-b953-55083e9d7c42"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("a7354a08-18eb-4500-8e65-833275050212") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170") },
                    { new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("e0b28711-1f52-49b6-a2de-837250874584"), new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf") },
                    { new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), new Guid("a7354a08-18eb-4500-8e65-833275050212") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("02f60061-c2ca-4647-bbed-e2a1bfa45493"), "Debruyne", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("911bc918-dfbb-430d-8728-a919cb838fb5"), "Vanderplas", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("a249de8a-efff-4f75-a241-f8870b4ae98c"), "Camara", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("7a63826a-b3c6-4e7b-8787-1057d46c63b9"), "Van Overmeire", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"), "Vissers", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("c27cc3c9-b1b4-4710-a965-33e7fd8a7446"), "Evenepoel", new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("e3d489ae-ece1-4c9e-bf39-af037295e01b"), "Garnaal", new Guid("f19f21c4-dfd4-4226-bc09-d825618f4c52"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("171803c9-62a2-4feb-a3b6-97fcad761ba7"), "Mertens", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("9f96e6ae-80cb-4b54-8dc0-d62202bd1981"), "Beukelaer", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("6f889fab-da8f-478c-b2fb-582e09e8ce85"), "Scarlet", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("4fc0968c-f7f7-466c-a011-183bc5b23122"), "Donckerwolcke", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("8d78d624-d785-4948-b02d-8f6683f59b15"), "Depardieu", new Guid("f20be404-910e-4e7c-acf6-20e08c193f69"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("e88e7fc1-5e91-4e6f-ae04-ca3a8f3d6d59"), "Hazard", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("6c32fc81-0fff-4e3a-b4f6-7995b7ef53fd"), "Zalinski", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("9d45e58b-9023-4205-9cc2-7cb06bbee005"), "VanHoof", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("41cc1054-ea2e-47b5-82f0-1dca727687ff"), "Mega", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"), "Franckaert", new Guid("c67b75f8-b57b-4a00-b786-2577ac7ec780"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("4e5c5735-90a6-4f20-997a-c63111d81d32"), "Bambino", new Guid("e0b28711-1f52-49b6-a2de-837250874584"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"), "Jansma", new Guid("d6f03a52-053a-425a-b951-54080673b3d2"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("78d8615c-19eb-4e4b-adaa-6b4a514e0a57"), "Brokkenpap", new Guid("e0b28711-1f52-49b6-a2de-837250874584"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae") },
                    { new Guid("a7354a08-18eb-4500-8e65-833275050212"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") },
                    { new Guid("e5ac8556-a52b-4392-91b8-4a43386e4e6a"), new Guid("8d78d624-d785-4948-b02d-8f6683f59b15") },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") },
                    { new Guid("90d54095-1d75-4084-81f7-f57ac1c3c170"), new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6") },
                    { new Guid("aae7a773-ad0f-49c2-846e-5b10d5c6c1bf"), new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("95ac02ed-22a0-491e-8fb1-b4f4adb641ce"), "Merckx", new Guid("9a05108c-2e52-48e5-81e3-b1ee43bb2eae"), "Oranje zadel" },
                    { new Guid("c17877a5-3f21-4f1e-b1f2-01e73816dc36"), "B-Twin", new Guid("39512d83-a1e8-46cb-93e4-f3b018e656c6"), "Zwart zadel" },
                    { new Guid("d4fc2144-88c2-40d6-95fb-f9b725e5cf59"), "Moldava", new Guid("c3b9f256-d41c-44ff-8091-0eb62bfc812a"), "Geel zadel" }
                });
        }
    }
}
