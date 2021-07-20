using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class newLinkforRecordHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecordHistories_Record_RecordId",
                table: "RecordHistories");

            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DropIndex(
                name: "IX_RecordHistories_RecordId",
                table: "RecordHistories");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("02afb729-62a0-4ea8-b456-937e31f466a4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), new Guid("02afb729-62a0-4ea8-b456-937e31f466a4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("87d66671-6599-483c-b02a-abca56747af9"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("02afb729-62a0-4ea8-b456-937e31f466a4"), new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"), new Guid("3794a162-4ee1-409f-b817-eb9705b3fcfe") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"), new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("874b9406-7732-47d0-9e43-d812d6789317"), new Guid("09e38bda-45f7-4da0-8646-af37771a4a2a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("874b9406-7732-47d0-9e43-d812d6789317"), new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24"), new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("066b5640-bd16-48a7-9c8d-6a16007a1bde"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5664d80b-4592-4ffa-93ce-ac4e823892e0"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d2d0ef24-9686-4550-8de7-63afcdc22960"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("04c22870-db87-44ba-8826-dfddff287f16"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a74c971-91b8-4052-9ae0-d6603c0a3e26"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6b18f5f1-3aec-453e-a8cf-cbcfbd1cd623"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("87baa3df-73fd-4610-a74c-65384cbc6a7a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("948b42de-98ef-40a5-b632-04b83762e13e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c10dc505-2316-4920-bd43-65827f112fbf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d503544a-5236-4215-bb29-0a438d66c0ca"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ee7ee5ec-c062-49ac-aa0a-3c649c77dc1d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c2fd336-7a65-4caf-99b6-d4bcf6c51777"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0ea2c770-d9ae-4dce-8167-a2ca8be4ec32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("19106615-be3e-48b1-9017-6f0fd91b6e19"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2218c363-a8fa-4ed6-b019-c6eb7a55b211"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("231f75a4-84ad-44f6-9032-e9b44ac37567"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2573986f-d42a-4a91-b0eb-caecf65c3fd6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2af1658e-e7bf-4910-9d85-5d96d9b9b99a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("32f6aba1-d349-45a9-a9cd-1ad70b26ed65"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("67293b00-f9e8-4f4c-8a63-380143e43b8e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("afe8145c-bba3-42b4-932e-11ac03444407"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c10cdece-a870-41c8-84d4-af539187b5db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c5fff7d3-49a3-44b4-bc2f-55470e5c1a0e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ecac6b8c-1570-4c73-8b00-a924c761cd0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("edbacb65-46bb-4675-99f6-76dcdbef252a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f485ed8b-ba3c-477d-bd02-a30a62a346bd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fccd1cda-e8fe-4c34-9ae6-3c45062c224d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("230c4718-aefe-47da-998b-ecd6377a8837"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("87d66671-6599-483c-b02a-abca56747af9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("02afb729-62a0-4ea8-b456-937e31f466a4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("874b9406-7732-47d0-9e43-d812d6789317"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("09e38bda-45f7-4da0-8646-af37771a4a2a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3794a162-4ee1-409f-b817-eb9705b3fcfe"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"));

            migrationBuilder.AddColumn<int>(
                name: "RecordCijfer",
                table: "RecordHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RecordEenheid",
                table: "RecordHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recordnaam",
                table: "RecordHistories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WielrennerId",
                table: "RecordHistories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), 0, null, "WTC", 2001 },
                    { new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), 0, null, "DCTV", 2016 },
                    { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("13be705c-968d-400f-b78e-e26f03af2e90"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("998385b3-b7df-4f6f-bd2a-bc84908de3bd"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("c12b46d9-112b-442f-bca9-5246cf931263"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("8d46eeb9-5e99-479e-bd6e-0d816117c4b0"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("3a79fde0-de87-418b-b6f6-37823bcc702c"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("aab8316e-bf52-4768-b168-1d9926d8e57d"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("74387139-7c9c-4fad-898f-0178c3d94c6c"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("75d6bb69-a4dc-4c66-b1d3-165fedc46007"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("8379484a-0ff1-47ae-ae33-681b192fe684"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506") },
                    { new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900") },
                    { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46") },
                    { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46") },
                    { new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") },
                    { new Guid("13be705c-968d-400f-b78e-e26f03af2e90"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") },
                    { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") },
                    { new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") },
                    { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") },
                    { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam", "WattageRecord" },
                values: new object[,]
                {
                    { new Guid("a98f43cd-d118-46d0-bd43-c12b41416a21"), 0, "Debruyne", new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin", 39 },
                    { new Guid("2de06264-3fb8-4222-a006-9c1388745167"), 0, "Brokkenpap", new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend", 30 },
                    { new Guid("03df1298-d547-4c0e-97ea-79cc89508817"), 0, "VanHoof", new Guid("13be705c-968d-400f-b78e-e26f03af2e90"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily", 35 },
                    { new Guid("e7518336-1beb-4142-89c8-c935e84dcb8f"), 0, "Scarlet", new Guid("13be705c-968d-400f-b78e-e26f03af2e90"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson", 32 },
                    { new Guid("8411411b-7a11-4bd6-aa00-04e49bb7e6b7"), 0, "Zalinski", new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck", 38 },
                    { new Guid("1e903ced-e72e-4411-bf44-c365e1b60ccd"), 0, "Beukelaer", new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes", 33 },
                    { new Guid("6a20ea27-176a-446a-9c72-13a3842a3428"), 0, "Donckerwolcke", new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas", 105 },
                    { new Guid("ecb9368f-cddd-41ca-b800-558cdf257d8a"), 0, "Vissers", new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert", 77 },
                    { new Guid("9e523d4a-b927-4786-a13c-55ed12afec8b"), 0, "Bambino", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore", 37 },
                    { new Guid("a0a8635d-3706-4cb5-ab44-49f8ad36d0da"), 0, "Vanderplas", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja", 36 },
                    { new Guid("60038384-05a6-4d63-b685-727dc52f466d"), 0, "Mertens", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne", 34 },
                    { new Guid("89cb3954-5c2b-4948-b2ea-06551dd71f46"), 0, "Mega", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy", 31 },
                    { new Guid("cba457cf-add3-4695-b734-192583526be0"), 0, "Camara", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy", 41 },
                    { new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822"), 0, "Depardieu", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard", 88 },
                    { new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4"), 0, "Jansma", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna", 66 },
                    { new Guid("e87f18e3-cc94-4987-9a6e-90ccd59be2d7"), 0, "Franckaert", new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin", 55 },
                    { new Guid("0aa11f4c-d492-4d2b-a1bb-99190ffcd0b0"), 0, "Evenepoel", new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco", 12 },
                    { new Guid("87ae63e4-82cb-4562-9b85-0d47c76aeb40"), 0, "Hazard", new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden", 21 },
                    { new Guid("836d943c-0ca5-45a1-83bf-89c48ae696a1"), 0, "Garnaal", new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie", 50 },
                    { new Guid("35c5e8d0-596a-47f9-b90e-066a19057990"), 0, "Van Overmeire", new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc", 99 }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"), new Guid("e87f18e3-cc94-4987-9a6e-90ccd59be2d7") },
                    { new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"), new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4") },
                    { new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46"), new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4") },
                    { new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"), new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822") },
                    { new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900"), new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822") },
                    { new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"), new Guid("ecb9368f-cddd-41ca-b800-558cdf257d8a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("58ec35e7-fdb1-41d1-8803-3bd6f35b5b29"), "Merckx", new Guid("e87f18e3-cc94-4987-9a6e-90ccd59be2d7"), "Oranje zadel" },
                    { new Guid("b57144cd-e3a3-462b-b212-d480273b43c2"), "B-Twin", new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4"), "Zwart zadel" },
                    { new Guid("7a17665b-ca8e-494c-954d-e1cd81313246"), "Moldava", new Guid("ecb9368f-cddd-41ca-b800-558cdf257d8a"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("13be705c-968d-400f-b78e-e26f03af2e90"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"), new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"), new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"), new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"), new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"), new Guid("ecb9368f-cddd-41ca-b800-558cdf257d8a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900"), new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46"), new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"), new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"), new Guid("e87f18e3-cc94-4987-9a6e-90ccd59be2d7") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("58ec35e7-fdb1-41d1-8803-3bd6f35b5b29"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7a17665b-ca8e-494c-954d-e1cd81313246"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("b57144cd-e3a3-462b-b212-d480273b43c2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3a79fde0-de87-418b-b6f6-37823bcc702c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("74387139-7c9c-4fad-898f-0178c3d94c6c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("75d6bb69-a4dc-4c66-b1d3-165fedc46007"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8379484a-0ff1-47ae-ae33-681b192fe684"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8d46eeb9-5e99-479e-bd6e-0d816117c4b0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("998385b3-b7df-4f6f-bd2a-bc84908de3bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("aab8316e-bf52-4768-b168-1d9926d8e57d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c12b46d9-112b-442f-bca9-5246cf931263"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("03df1298-d547-4c0e-97ea-79cc89508817"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0aa11f4c-d492-4d2b-a1bb-99190ffcd0b0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1e903ced-e72e-4411-bf44-c365e1b60ccd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2de06264-3fb8-4222-a006-9c1388745167"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("35c5e8d0-596a-47f9-b90e-066a19057990"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("60038384-05a6-4d63-b685-727dc52f466d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6a20ea27-176a-446a-9c72-13a3842a3428"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("836d943c-0ca5-45a1-83bf-89c48ae696a1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8411411b-7a11-4bd6-aa00-04e49bb7e6b7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("87ae63e4-82cb-4562-9b85-0d47c76aeb40"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("89cb3954-5c2b-4948-b2ea-06551dd71f46"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9e523d4a-b927-4786-a13c-55ed12afec8b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0a8635d-3706-4cb5-ab44-49f8ad36d0da"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a98f43cd-d118-46d0-bd43-c12b41416a21"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cba457cf-add3-4695-b734-192583526be0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e7518336-1beb-4142-89c8-c935e84dcb8f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("01fbed77-ce92-4996-8fc2-6d85d62d15e3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("13be705c-968d-400f-b78e-e26f03af2e90"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ad91816d-f7aa-45ff-b4e6-2afae577e55b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5150e001-a7f1-4afc-805a-624ab3fb3c69"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("687cdbf9-ad3b-4196-9150-c24fe3a9e900"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9477bb0f-3b0d-4361-996c-4a33927f4c46"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ee5b1add-7f60-425d-8c79-75aafaa6f506"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("980dda79-5259-44b0-a4b3-6ad74ecd1822"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b86fcd8a-4bc3-499a-bebf-b302cd741df4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e87f18e3-cc94-4987-9a6e-90ccd59be2d7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ecb9368f-cddd-41ca-b800-558cdf257d8a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("42e2857f-03ea-4ef4-952d-dcfb974ca31b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8648cfd4-4a5b-4e89-8b6f-96bcb93bca1b"));

            migrationBuilder.DropColumn(
                name: "RecordCijfer",
                table: "RecordHistories");

            migrationBuilder.DropColumn(
                name: "RecordEenheid",
                table: "RecordHistories");

            migrationBuilder.DropColumn(
                name: "Recordnaam",
                table: "RecordHistories");

            migrationBuilder.DropColumn(
                name: "WielrennerId",
                table: "RecordHistories");

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecordCijfer = table.Column<int>(nullable: false),
                    RecordEenheid = table.Column<string>(nullable: true),
                    RecordType = table.Column<int>(nullable: false),
                    Recordnaam = table.Column<string>(nullable: true),
                    Thropy = table.Column<string>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Record_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), 0, null, "WTC", 2001 },
                    { new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), 0, null, "DCTV", 2016 },
                    { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("87d66671-6599-483c-b02a-abca56747af9"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d503544a-5236-4215-bb29-0a438d66c0ca"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("87baa3df-73fd-4610-a74c-65384cbc6a7a"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("04c22870-db87-44ba-8826-dfddff287f16"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("6b18f5f1-3aec-453e-a8cf-cbcfbd1cd623"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("1a74c971-91b8-4052-9ae0-d6603c0a3e26"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("948b42de-98ef-40a5-b632-04b83762e13e"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("02afb729-62a0-4ea8-b456-937e31f466a4"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("874b9406-7732-47d0-9e43-d812d6789317"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("c10dc505-2316-4920-bd43-65827f112fbf"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("ee7ee5ec-c062-49ac-aa0a-3c649c77dc1d"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8") },
                    { new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), new Guid("02afb729-62a0-4ea8-b456-937e31f466a4") },
                    { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24") },
                    { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24") },
                    { new Guid("87d66671-6599-483c-b02a-abca56747af9"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") },
                    { new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") },
                    { new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") },
                    { new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") },
                    { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("874b9406-7732-47d0-9e43-d812d6789317") },
                    { new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), new Guid("02afb729-62a0-4ea8-b456-937e31f466a4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam", "WattageRecord" },
                values: new object[,]
                {
                    { new Guid("c10cdece-a870-41c8-84d4-af539187b5db"), 0, "Zalinski", new Guid("87d66671-6599-483c-b02a-abca56747af9"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck", 38 },
                    { new Guid("19106615-be3e-48b1-9017-6f0fd91b6e19"), 0, "Beukelaer", new Guid("87d66671-6599-483c-b02a-abca56747af9"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes", 33 },
                    { new Guid("231f75a4-84ad-44f6-9032-e9b44ac37567"), 0, "Donckerwolcke", new Guid("87d66671-6599-483c-b02a-abca56747af9"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas", 105 },
                    { new Guid("c5fff7d3-49a3-44b4-bc2f-55470e5c1a0e"), 0, "Evenepoel", new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco", 12 },
                    { new Guid("fccd1cda-e8fe-4c34-9ae6-3c45062c224d"), 0, "Hazard", new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden", 21 },
                    { new Guid("edbacb65-46bb-4675-99f6-76dcdbef252a"), 0, "Vanderplas", new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja", 36 },
                    { new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78"), 0, "Jansma", new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna", 66 },
                    { new Guid("2573986f-d42a-4a91-b0eb-caecf65c3fd6"), 0, "Bambino", new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore", 37 },
                    { new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7"), 0, "Depardieu", new Guid("4533a7c2-90cd-4e81-aedf-59341a3aa662"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard", 88 },
                    { new Guid("0c2fd336-7a65-4caf-99b6-d4bcf6c51777"), 0, "Debruyne", new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin", 39 },
                    { new Guid("afe8145c-bba3-42b4-932e-11ac03444407"), 0, "Brokkenpap", new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend", 30 },
                    { new Guid("67293b00-f9e8-4f4c-8a63-380143e43b8e"), 0, "Camara", new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy", 41 },
                    { new Guid("09e38bda-45f7-4da0-8646-af37771a4a2a"), 0, "Vissers", new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert", 77 },
                    { new Guid("3794a162-4ee1-409f-b817-eb9705b3fcfe"), 0, "Franckaert", new Guid("7ad261ce-b2bb-4810-b2c6-968d7e64dd95"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin", 55 },
                    { new Guid("f485ed8b-ba3c-477d-bd02-a30a62a346bd"), 0, "VanHoof", new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily", 35 },
                    { new Guid("ecac6b8c-1570-4c73-8b00-a924c761cd0a"), 0, "Mertens", new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne", 34 },
                    { new Guid("0ea2c770-d9ae-4dce-8167-a2ca8be4ec32"), 0, "Scarlet", new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson", 32 },
                    { new Guid("2af1658e-e7bf-4910-9d85-5d96d9b9b99a"), 0, "Mega", new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy", 31 },
                    { new Guid("2218c363-a8fa-4ed6-b019-c6eb7a55b211"), 0, "Garnaal", new Guid("f18b7c45-1872-49de-95ae-09b4a292b97c"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie", 50 },
                    { new Guid("32f6aba1-d349-45a9-a9cd-1ad70b26ed65"), 0, "Van Overmeire", new Guid("230c4718-aefe-47da-998b-ecd6377a8837"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc", 99 }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"), new Guid("3794a162-4ee1-409f-b817-eb9705b3fcfe") },
                    { new Guid("874b9406-7732-47d0-9e43-d812d6789317"), new Guid("09e38bda-45f7-4da0-8646-af37771a4a2a") },
                    { new Guid("38b7fb3b-faab-4cae-b0e0-e1f6f3004be8"), new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7") },
                    { new Guid("02afb729-62a0-4ea8-b456-937e31f466a4"), new Guid("4edc29c8-ee9a-4e09-bec4-4ed1a2aa39a7") },
                    { new Guid("874b9406-7732-47d0-9e43-d812d6789317"), new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78") },
                    { new Guid("a2d1b03a-37c5-41e1-a97e-3215d3c3bc24"), new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("d2d0ef24-9686-4550-8de7-63afcdc22960"), "Merckx", new Guid("3794a162-4ee1-409f-b817-eb9705b3fcfe"), "Oranje zadel" },
                    { new Guid("066b5640-bd16-48a7-9c8d-6a16007a1bde"), "Moldava", new Guid("09e38bda-45f7-4da0-8646-af37771a4a2a"), "Geel zadel" },
                    { new Guid("5664d80b-4592-4ffa-93ce-ac4e823892e0"), "B-Twin", new Guid("fd7a8758-f0dd-4e0d-938b-a518b739cb78"), "Zwart zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecordHistories_RecordId",
                table: "RecordHistories",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Record_WielrennerId",
                table: "Record",
                column: "WielrennerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecordHistories_Record_RecordId",
                table: "RecordHistories",
                column: "RecordId",
                principalTable: "Record",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
