using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class ReseedWielrenners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"), new Guid("99ce9a58-389d-485e-b450-014da8902080") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("99ce9a58-389d-485e-b450-014da8902080") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7d0a8502-7c41-4dcb-b6d8-acb3b345b66f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("97154dd9-a4b2-4416-9215-ba6efa370623"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("aadf0221-453c-413e-bf6a-4c89b28162ee"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0eca18e3-dc69-47f6-9a05-9c9f16d8e01e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3ce32128-2be8-4e97-8376-36cbc5fd1768"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5c78e5ff-bbd6-48e3-9138-e1636f207913"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("97c7d0d7-afbb-4ae2-ab29-63b269354b1c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a0c17220-4b0f-45f9-92b6-1f8e63ba46e3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cacb9a9d-8c10-45e4-a18a-48b25fa9a6fd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cd3896ce-9e40-4f59-93b2-e41930b0afa4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cfee5a6c-35e6-40ea-800f-40552650bbd5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("05baa842-d974-4908-802a-1f264346dfa5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0a89a1a9-9e0f-4cb0-8d5b-62e8cf0b3c53"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1867dbef-ffaa-4ce2-9a66-64b9fef97718"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("27207fc4-7c0e-4cce-ab54-6a3c9a393847"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("45235ec5-5833-40e7-80c3-99ca0cc9c084"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5ed74120-8322-483b-b71b-104900b005da"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6c57cc9f-0d0d-48a8-8a3d-1bee1b76e1bd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72e17e68-1766-48d4-bdad-3ed8ec97bbc9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("866f6f07-7f9c-4cb6-a39a-9fcc62c7e534"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("929c45bf-ab34-4e97-a327-da733233852e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("96d497eb-92e3-40ca-ba2a-376d374fb6cf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7618859-c1d0-40ee-86f2-af4f4b8a29c9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d4fc7bc7-e1fb-46c6-9a8d-0eb273672a74"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d6413a35-6940-4720-8a52-39086e4b3f1e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e6927028-b287-4935-901b-d0649ee0e772"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f9a23758-1cdf-4480-a4c1-9be6007900a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("88fed016-5609-4006-9de8-09c69833c256"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("99ce9a58-389d-485e-b450-014da8902080"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), 0, null, "WTC", 2001 },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), 0, null, "DCTV", 2016 },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1bc6f599-920e-418e-99b6-1864df2f0c31"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("c1756a14-52d0-4eca-a6fd-8e6c4254ec9a"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("6d704bd7-de74-4bb5-8afc-2ac0da45cf23"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("25707fbf-fc3d-4dbc-9013-6a6e1069c1bd"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("014e4a0f-099c-4cf7-8652-1ae9fadd53ca"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("dccae4d8-f77f-47c7-b175-e75532eb9b18"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d89c56f3-b490-40c0-b86f-61e8cec16946"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("71947fce-cada-4255-b823-819808d8a2d1"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1") },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") },
                    { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") },
                    { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1e7c806f-d68b-4c05-ab51-8512eca34705"), 0, "Zalinski", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("7850aecd-ca8e-4d6d-ae73-548f581a6431"), 0, "Bambino", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("26d315d0-c4c0-43de-91fc-ee6a2c4a89e9"), 0, "Mertens", new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("d30689d3-ce1a-40cf-8c55-f2ad17964ff3"), 0, "Evenepoel", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("f127495c-7b37-4904-8aee-ecaa999ca04c"), 0, "Hazard", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("f0fa4b67-9704-4f79-b9b0-980644351d3a"), 0, "Beukelaer", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("66da1773-c553-4450-9747-d75a68cc1dee"), 0, "Franckaert", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" },
                    { new Guid("6808250e-d1c1-4908-86bf-30e3fc279ce8"), 0, "Debruyne", new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("2c699b52-ff83-481e-8f70-215611ca4607"), 0, "Jansma", new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("247493d4-ea61-444b-add0-0eccaa9c0363"), 0, "Vanderplas", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("6afff5e4-b757-4958-b8f2-d174a1896226"), 0, "VanHoof", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("749a8780-6a86-4d26-bdd9-fed2ae7e46f7"), 0, "Mega", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("53385228-5f07-4850-a42b-bb00f55a554c"), 0, "Brokkenpap", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("a0316ff8-babf-4fd1-be40-d988084b5f01"), 0, "Garnaal", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("824d5ced-ab37-4a7e-bcc6-061e22d4a326"), 0, "Donckerwolcke", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42"), 0, "Depardieu", new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("d10fa0eb-7794-40ea-9b06-68ac7dbe36be"), 0, "Scarlet", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("f020bee2-8a96-47c7-b7ea-7892bf879151"), 0, "Camara", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("1e0a59b4-ccfb-4248-be73-2ba20811626e"), 0, "Van Overmeire", new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"), 0, "Vissers", new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("45521d10-d277-43c9-bc3a-6244685c9a09") },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") },
                    { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") },
                    { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") },
                    { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") },
                    { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("66da1773-c553-4450-9747-d75a68cc1dee") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("893c64b8-ab56-4e76-8cb3-5242081a8f79"), "Moldava", new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"), "Geel zadel" },
                    { new Guid("0e97e06b-854b-4e55-b4cb-0b460e0c8fa1"), "B-Twin", new Guid("2c699b52-ff83-481e-8f70-215611ca4607"), "Zwart zadel" },
                    { new Guid("669910d8-9f60-432a-acad-2b99145ccb30"), "Merckx", new Guid("66da1773-c553-4450-9747-d75a68cc1dee"), "Oranje zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"), new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("4506204b-01db-4f86-aa36-94beb740c624") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"), new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("4506204b-01db-4f86-aa36-94beb740c624"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("2c699b52-ff83-481e-8f70-215611ca4607") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"), new Guid("45521d10-d277-43c9-bc3a-6244685c9a09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("66da1773-c553-4450-9747-d75a68cc1dee") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"), new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0e97e06b-854b-4e55-b4cb-0b460e0c8fa1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("669910d8-9f60-432a-acad-2b99145ccb30"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("893c64b8-ab56-4e76-8cb3-5242081a8f79"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("014e4a0f-099c-4cf7-8652-1ae9fadd53ca"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1bc6f599-920e-418e-99b6-1864df2f0c31"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25707fbf-fc3d-4dbc-9013-6a6e1069c1bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6d704bd7-de74-4bb5-8afc-2ac0da45cf23"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("71947fce-cada-4255-b823-819808d8a2d1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c1756a14-52d0-4eca-a6fd-8e6c4254ec9a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d89c56f3-b490-40c0-b86f-61e8cec16946"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dccae4d8-f77f-47c7-b175-e75532eb9b18"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e0a59b4-ccfb-4248-be73-2ba20811626e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e7c806f-d68b-4c05-ab51-8512eca34705"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("247493d4-ea61-444b-add0-0eccaa9c0363"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("26d315d0-c4c0-43de-91fc-ee6a2c4a89e9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("53385228-5f07-4850-a42b-bb00f55a554c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6808250e-d1c1-4908-86bf-30e3fc279ce8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6afff5e4-b757-4958-b8f2-d174a1896226"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("749a8780-6a86-4d26-bdd9-fed2ae7e46f7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7850aecd-ca8e-4d6d-ae73-548f581a6431"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("824d5ced-ab37-4a7e-bcc6-061e22d4a326"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0316ff8-babf-4fd1-be40-d988084b5f01"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d10fa0eb-7794-40ea-9b06-68ac7dbe36be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d30689d3-ce1a-40cf-8c55-f2ad17964ff3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f020bee2-8a96-47c7-b7ea-7892bf879151"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0fa4b67-9704-4f79-b9b0-980644351d3a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f127495c-7b37-4904-8aee-ecaa999ca04c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("aa388eb8-ac4b-4684-ab4e-f8ec3d93dcaf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4506204b-01db-4f86-aa36-94beb740c624"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("98f93829-b21e-4def-a2ce-27f5dcb0f119"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dbe3f83c-f1dd-498b-8c5a-8f7caa3ae1d1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e0cc61d4-ab25-4e49-be3f-272f5231a344"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c699b52-ff83-481e-8f70-215611ca4607"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("45521d10-d277-43c9-bc3a-6244685c9a09"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("66da1773-c553-4450-9747-d75a68cc1dee"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fcdb0108-f64d-4a0d-ad1c-805337a19e42"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8ea09cd4-0fc2-4020-a45f-1b140284bcf5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a56b2979-fba1-40e0-899d-ab804eae28a3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c54a41fd-e91c-46c2-9a28-02b355a4d0cb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("dbd498a7-8d0a-4115-b835-2175836fc11e"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), 0, null, "WTC", 2001 },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), 0, null, "DCTV", 2016 },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("0eca18e3-dc69-47f6-9a05-9c9f16d8e01e"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("3ce32128-2be8-4e97-8376-36cbc5fd1768"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("97c7d0d7-afbb-4ae2-ab29-63b269354b1c"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("cacb9a9d-8c10-45e4-a18a-48b25fa9a6fd"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("5c78e5ff-bbd6-48e3-9138-e1636f207913"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("a0c17220-4b0f-45f9-92b6-1f8e63ba46e3"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("cfee5a6c-35e6-40ea-800f-40552650bbd5"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("cd3896ce-9e40-4f59-93b2-e41930b0afa4"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9") },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56") },
                    { new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("88fed016-5609-4006-9de8-09c69833c256"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a") },
                    { new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("27207fc4-7c0e-4cce-ab54-6a3c9a393847"), 0, "Debruyne", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 165, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("45235ec5-5833-40e7-80c3-99ca0cc9c084"), 0, "Bambino", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 159, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("929c45bf-ab34-4e97-a327-da733233852e"), 0, "Mega", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 230, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("72e17e68-1766-48d4-bdad-3ed8ec97bbc9"), 0, "Donckerwolcke", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 202, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a"), 0, "Vissers", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 150, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04"), 0, "Franckaert", new Guid("79f1e9d4-2dc0-4f99-9b08-9ecb94f211bc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 110, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("96d497eb-92e3-40ca-ba2a-376d374fb6cf"), 0, "Scarlet", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 111, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("d6413a35-6940-4720-8a52-39086e4b3f1e"), 0, "Brokkenpap", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 185, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("6c57cc9f-0d0d-48a8-8a3d-1bee1b76e1bd"), 0, "Garnaal", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 166, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("0a89a1a9-9e0f-4cb0-8d5b-62e8cf0b3c53"), 0, "Hazard", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 166, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("e6927028-b287-4935-901b-d0649ee0e772"), 0, "Vanderplas", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 163, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("866f6f07-7f9c-4cb6-a39a-9fcc62c7e534"), 0, "VanHoof", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 136, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("c7618859-c1d0-40ee-86f2-af4f4b8a29c9"), 0, "Mertens", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 155, "202CB962AC59075B964B07152D234B70", 1250, "Evelyne" },
                    { new Guid("5ed74120-8322-483b-b71b-104900b005da"), 0, "Camara", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 156, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("99ce9a58-389d-485e-b450-014da8902080"), 0, "Depardieu", new Guid("cf90cfc4-6153-4fdb-88eb-bc5588af1141"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 206, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("f9a23758-1cdf-4480-a4c1-9be6007900a3"), 0, "Evenepoel", new Guid("88fed016-5609-4006-9de8-09c69833c256"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 166, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("05baa842-d974-4908-802a-1f264346dfa5"), 0, "Beukelaer", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 232, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("d4fc7bc7-e1fb-46c6-9a8d-0eb273672a74"), 0, "Van Overmeire", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 190, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("1867dbef-ffaa-4ce2-9a66-64b9fef97718"), 0, "Zalinski", new Guid("7a340b75-cb76-4471-920e-b63233a7efdc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 174, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd"), 0, "Jansma", new Guid("a1c85648-f1fd-42f8-98e9-e2dfaa586aea"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 203, "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") },
                    { new Guid("78316075-a1c5-4c0f-ac83-48f8fb90dc56"), new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd") },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("99ce9a58-389d-485e-b450-014da8902080") },
                    { new Guid("3471faca-e02d-45c3-a1c7-6c2bf2147828"), new Guid("99ce9a58-389d-485e-b450-014da8902080") },
                    { new Guid("35bf04a3-da73-409f-82b9-dc93ef4fbdd9"), new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04") },
                    { new Guid("7939fb25-ff5c-4aa1-9b5d-2596d3fafa0a"), new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("97154dd9-a4b2-4416-9215-ba6efa370623"), "B-Twin", new Guid("1a29e061-ca47-480f-bcab-26f868e63ebd"), "Zwart zadel" },
                    { new Guid("aadf0221-453c-413e-bf6a-4c89b28162ee"), "Merckx", new Guid("9ee1adb1-3de1-4a71-b156-85d4d43a5e04"), "Oranje zadel" },
                    { new Guid("7d0a8502-7c41-4dcb-b6d8-acb3b345b66f"), "Moldava", new Guid("4c8c1247-7648-4a4b-99d7-3b2b05b6ea6a"), "Geel zadel" }
                });
        }
    }
}
