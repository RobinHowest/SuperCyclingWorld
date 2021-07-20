using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class RecordTypeToRecordHistories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "RecordType",
                table: "RecordHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), 0, null, "WTC", 2001 },
                    { new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), 0, null, "DCTV", 2016 },
                    { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("e03ac4c6-f3f5-40b4-bc36-701f9e5be66d"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("76f44a3c-7875-4c05-8588-67a246a95655"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("1dcd15c1-7c1d-4b96-a28c-d5ba25de9183"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("cb57efbd-68c6-4d9c-a335-86d8c3e4e59b"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("2a5af7a1-1a6d-4950-a803-129c2c99147c"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("57d8cc6c-b093-4354-9224-61eac040e672"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("31279284-f485-4a35-9f5f-1a7430f00466"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("133a1822-c693-4f39-a46a-ee32bf66edf7"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("d1f40896-f653-4d1f-8edd-30ac045c660d"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80") },
                    { new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), new Guid("31279284-f485-4a35-9f5f-1a7430f00466") },
                    { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d") },
                    { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d") },
                    { new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") },
                    { new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") },
                    { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") },
                    { new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") },
                    { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") },
                    { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("31279284-f485-4a35-9f5f-1a7430f00466") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam", "WattageRecord" },
                values: new object[,]
                {
                    { new Guid("33fde466-a4b4-4c7e-8c29-f218048dfaab"), 0, "Vanderplas", new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja", 36 },
                    { new Guid("5c5b4fe4-1d39-4c37-b4c3-c1edefde1785"), 0, "Mega", new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy", 31 },
                    { new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be"), 0, "Depardieu", new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard", 88 },
                    { new Guid("6873fcf8-137e-46b5-b4f6-e10446879d9a"), 0, "Vissers", new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert", 77 },
                    { new Guid("2ca3a38a-a556-4626-bdb0-3b8bac945e02"), 0, "VanHoof", new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily", 35 },
                    { new Guid("cf866f89-f81b-402b-8ebb-c8e10424ba61"), 0, "Beukelaer", new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes", 33 },
                    { new Guid("cf6a2c27-d01e-4520-ad12-22331f407996"), 0, "Garnaal", new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie", 50 },
                    { new Guid("d732fbba-05a9-462f-9678-0f7ecf9639fc"), 0, "Camara", new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy", 41 },
                    { new Guid("8be76248-7ae9-4c73-a88d-9c8fd2ab0d13"), 0, "Evenepoel", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco", 12 },
                    { new Guid("bd945087-4e9f-426a-903f-b930f042eb1e"), 0, "Debruyne", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin", 39 },
                    { new Guid("b0835b25-abff-470b-a8ec-4229868073fc"), 0, "Bambino", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore", 37 },
                    { new Guid("d400b16a-c696-4105-b4e9-01dae83ed00c"), 0, "Mertens", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne", 34 },
                    { new Guid("705b8e4b-a892-4a89-870a-b1c178386052"), 0, "Brokkenpap", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend", 30 },
                    { new Guid("f17bf21d-18d3-406b-b8fc-e8b1a922be2b"), 0, "Van Overmeire", new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc", 99 },
                    { new Guid("426a1b16-5c53-4a6e-aa3d-4ffce22b2d85"), 0, "Hazard", new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden", 21 },
                    { new Guid("75abdafc-3192-4a1e-b974-9659581b4404"), 0, "Zalinski", new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck", 38 },
                    { new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8"), 0, "Jansma", new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna", 66 },
                    { new Guid("2eb680a6-ff08-4655-807b-c528aa7764cf"), 0, "Donckerwolcke", new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas", 105 },
                    { new Guid("535e478c-4d4b-473c-993b-354ac0e962be"), 0, "Scarlet", new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson", 32 },
                    { new Guid("4f8c98f7-97bb-49d0-a0d8-8032ff3aaa46"), 0, "Franckaert", new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin", 55 }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"), new Guid("4f8c98f7-97bb-49d0-a0d8-8032ff3aaa46") },
                    { new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"), new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8") },
                    { new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d"), new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8") },
                    { new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"), new Guid("6873fcf8-137e-46b5-b4f6-e10446879d9a") },
                    { new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"), new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be") },
                    { new Guid("31279284-f485-4a35-9f5f-1a7430f00466"), new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("b06bb235-b44d-4f69-b24b-04641b264f1f"), "Merckx", new Guid("4f8c98f7-97bb-49d0-a0d8-8032ff3aaa46"), "Oranje zadel" },
                    { new Guid("39fe173b-4d7a-42e8-8645-eeba00647857"), "B-Twin", new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8"), "Zwart zadel" },
                    { new Guid("6a220082-ce12-4adc-b8bf-299a99ee3b8a"), "Moldava", new Guid("6873fcf8-137e-46b5-b4f6-e10446879d9a"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("31279284-f485-4a35-9f5f-1a7430f00466") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), new Guid("31279284-f485-4a35-9f5f-1a7430f00466") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"), new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d"), new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("31279284-f485-4a35-9f5f-1a7430f00466"), new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"), new Guid("4f8c98f7-97bb-49d0-a0d8-8032ff3aaa46") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"), new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"), new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"), new Guid("6873fcf8-137e-46b5-b4f6-e10446879d9a") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("39fe173b-4d7a-42e8-8645-eeba00647857"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6a220082-ce12-4adc-b8bf-299a99ee3b8a"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("b06bb235-b44d-4f69-b24b-04641b264f1f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("133a1822-c693-4f39-a46a-ee32bf66edf7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1dcd15c1-7c1d-4b96-a28c-d5ba25de9183"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2a5af7a1-1a6d-4950-a803-129c2c99147c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("57d8cc6c-b093-4354-9224-61eac040e672"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("76f44a3c-7875-4c05-8588-67a246a95655"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cb57efbd-68c6-4d9c-a335-86d8c3e4e59b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d1f40896-f653-4d1f-8edd-30ac045c660d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e03ac4c6-f3f5-40b4-bc36-701f9e5be66d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2ca3a38a-a556-4626-bdb0-3b8bac945e02"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2eb680a6-ff08-4655-807b-c528aa7764cf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("33fde466-a4b4-4c7e-8c29-f218048dfaab"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("426a1b16-5c53-4a6e-aa3d-4ffce22b2d85"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("535e478c-4d4b-473c-993b-354ac0e962be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5c5b4fe4-1d39-4c37-b4c3-c1edefde1785"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("705b8e4b-a892-4a89-870a-b1c178386052"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("75abdafc-3192-4a1e-b974-9659581b4404"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8be76248-7ae9-4c73-a88d-9c8fd2ab0d13"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b0835b25-abff-470b-a8ec-4229868073fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bd945087-4e9f-426a-903f-b930f042eb1e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cf6a2c27-d01e-4520-ad12-22331f407996"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cf866f89-f81b-402b-8ebb-c8e10424ba61"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d400b16a-c696-4105-b4e9-01dae83ed00c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d732fbba-05a9-462f-9678-0f7ecf9639fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f17bf21d-18d3-406b-b8fc-e8b1a922be2b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("132f1034-6f3c-4b50-ab35-c3a8c9591f76"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bea36d49-508a-41d1-9508-0209303bd5fc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25fa693e-5de5-4062-9de6-6bbad8c77f9d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("31279284-f485-4a35-9f5f-1a7430f00466"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("561f7456-e29c-4be7-a19b-111a3f59ef80"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9670a0a8-eca8-42b5-a76c-dcac39c61709"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("06980df0-ba30-4bbf-8c9a-1471d4569fa8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4f8c98f7-97bb-49d0-a0d8-8032ff3aaa46"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6873fcf8-137e-46b5-b4f6-e10446879d9a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("94a9c7de-8434-4604-bc0a-1fab5f07e4be"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("367cfc0a-c910-485f-a905-43133d10d1b6"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("55c66dff-692d-429d-95ae-a14a4e0b43e9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7d8bf1e6-b435-42b6-9e19-9d1f931cac82"));

            migrationBuilder.DropColumn(
                name: "RecordType",
                table: "RecordHistories");

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
    }
}
