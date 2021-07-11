using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddRealisticGemiddeldeKMPErRitWielrenner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("2a256162-f9ba-48f4-aa40-6049dd844294") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("6c8b4320-cc47-4ed1-8f7a-f3faaafdb2b7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7328fc02-3a93-4fc8-a781-8b7db9d539a5"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c810e934-261a-4089-af76-83650a0fd0fa"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2c3f1a86-5d39-4c31-8efc-c74c3f61c42d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4714c8da-c92d-47a5-9af5-7a2c1f7b4e32"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5abc3233-0e2e-472e-8de3-dff7cc79647c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("75a36637-99a0-4d3c-9715-7db08798a2dc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8219f84b-1c79-46ec-8c4e-3dfc7b4757e9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d2a31910-5dda-4288-95c2-b0f9ba408605"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f7bf8e60-53c2-4f4e-af3c-f5880096f70a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fa2521b0-1f7f-4204-b425-b6a387ba3e89"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1dbf2afc-6418-4a3a-9979-320f6a394f2d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("341cdc06-a248-4304-b919-a5801e936539"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4233cb5b-f66a-4dd4-a712-d3053b0471a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5534f506-e85c-4012-a113-9c49b05983fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5575eaf1-d828-46b2-bde1-861a5f6292db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58e5ae1e-17a6-4681-a4a9-bf7c7a553d7c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6ff39d7e-9dc7-4f1c-9d84-ddef3748f5e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72205c80-f5d8-4a91-86de-84a10d0ec7e3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9a82887f-5832-4ac5-af9f-9f90686213d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0988b94-0be3-4c94-8716-b4b386d38368"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a789d598-b574-449a-8b16-27fa3d4e8ffb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("abef85e4-075f-4c95-ab79-34462e40a430"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b97a66dd-5e23-4a5f-a305-df433c8f7865"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec268c16-3bcd-46e9-8573-dac50d0b16ed"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb4c24fb-3a10-4e51-95f4-4173033395db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fe1adc9c-36b9-42bd-9088-259260a1ec78"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("104c1651-2ccb-4081-b20b-0202e060866f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), 0, null, "WTC", 2001 },
                    { new Guid("475a6579-5042-4180-91bd-048aecf84150"), 0, null, "DCTV", 2016 },
                    { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("7354dd50-de79-4ec6-b8b5-48622b93367c"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("a1dcf9aa-7145-4716-924d-62a764c56868"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("12482812-c703-429a-8905-5d736489b4f6"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("7eef6c44-c72e-4e48-8b21-b64ba31c1849"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("d8629184-3f4e-44ff-9ff4-b86aa4d31cc9"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("00853906-07a3-41f6-9dec-bb5193bf6813"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("fe899789-f7e3-49a0-ac3b-8451cfad705c"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("e355e6e3-ec25-46d6-a889-2f2f67448d13"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3") },
                    { new Guid("475a6579-5042-4180-91bd-048aecf84150"), new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be") },
                    { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc") },
                    { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc") },
                    { new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") },
                    { new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") },
                    { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") },
                    { new Guid("475a6579-5042-4180-91bd-048aecf84150"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") },
                    { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") },
                    { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("71f413ab-f6f5-43d6-99f0-2c6dabf015e7"), 0, "Debruyne", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 165, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("12cce350-3fe5-4ccd-b4eb-5f3158741918"), 0, "Beukelaer", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 232, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("ff86f8ea-2d90-4f8e-afb7-68ece7ef839e"), 0, "Mega", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 230, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("bd54483b-f3cf-42bb-a0d0-6d124b543cf9"), 0, "Brokkenpap", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 185, "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("005390b5-ec27-49b3-9f8e-25d8495fccba"), 0, "Donckerwolcke", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 202, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("d5493c36-199f-402c-8308-8322a36f5e9b"), 0, "Franckaert", new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 110, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("3a8a41b3-4baa-49f5-b9f5-c947e511b4e4"), 0, "Zalinski", new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 174, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("1a271d48-45f3-48c7-a6a2-224092f1b852"), 0, "Garnaal", new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 166, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19"), 0, "Jansma", new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 203, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("f611a518-938b-43b5-a50d-afd9158ea73e"), 0, "Vanderplas", new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 163, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("22bd0d9a-acb0-4a6f-b7ce-a86027a6076c"), 0, "Evenepoel", new Guid("475a6579-5042-4180-91bd-048aecf84150"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 166, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("ef90cca0-cdc7-4668-a9e6-237437ab1401"), 0, "Van Overmeire", new Guid("475a6579-5042-4180-91bd-048aecf84150"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 190, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("49d14838-ffc6-4703-8750-8c348a4f7158"), 0, "Depardieu", new Guid("475a6579-5042-4180-91bd-048aecf84150"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 206, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("2a3d9a40-6169-4b19-81e4-92bacff8c2b7"), 0, "Vissers", new Guid("475a6579-5042-4180-91bd-048aecf84150"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 150, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("0e065e22-eccb-4eea-9e93-1b4e98b3cd1e"), 0, "Bambino", new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 159, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("77cf6ee3-3447-439b-a8d9-1abfd9e88d11"), 0, "VanHoof", new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 136, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("5aaa0ea9-615a-4f37-9360-78c804954516"), 0, "Mertens", new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 155, "202CB962AC59075B964B07152D234B70", 1250, "Evelyne" },
                    { new Guid("bc1c6ac2-dfc7-44c7-abd3-00b34e4fb202"), 0, "Scarlet", new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 111, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("2fcb0f34-71a9-4dc2-a160-d5436802e479"), 0, "Hazard", new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 166, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("c9e4671a-f264-47b8-9ef2-7b2e7e833763"), 0, "Camara", new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 156, "202CB962AC59075B964B07152D234B70", 504, "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"), new Guid("2a3d9a40-6169-4b19-81e4-92bacff8c2b7") },
                    { new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"), new Guid("49d14838-ffc6-4703-8750-8c348a4f7158") },
                    { new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be"), new Guid("49d14838-ffc6-4703-8750-8c348a4f7158") },
                    { new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"), new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19") },
                    { new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc"), new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19") },
                    { new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"), new Guid("d5493c36-199f-402c-8308-8322a36f5e9b") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("dc84b8aa-a218-4186-ba32-4a781498fb24"), "Moldava", new Guid("2a3d9a40-6169-4b19-81e4-92bacff8c2b7"), "Geel zadel" },
                    { new Guid("28907c6e-11d7-4762-a896-d5cec214e5fa"), "B-Twin", new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19"), "Zwart zadel" },
                    { new Guid("e0a7f632-ffd9-4f50-ad99-17c73fd00008"), "Merckx", new Guid("d5493c36-199f-402c-8308-8322a36f5e9b"), "Oranje zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("475a6579-5042-4180-91bd-048aecf84150"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("475a6579-5042-4180-91bd-048aecf84150"), new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"), new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"), new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc"), new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"), new Guid("2a3d9a40-6169-4b19-81e4-92bacff8c2b7") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"), new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be"), new Guid("49d14838-ffc6-4703-8750-8c348a4f7158") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"), new Guid("49d14838-ffc6-4703-8750-8c348a4f7158") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"), new Guid("d5493c36-199f-402c-8308-8322a36f5e9b") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("28907c6e-11d7-4762-a896-d5cec214e5fa"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("dc84b8aa-a218-4186-ba32-4a781498fb24"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e0a7f632-ffd9-4f50-ad99-17c73fd00008"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("00853906-07a3-41f6-9dec-bb5193bf6813"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("12482812-c703-429a-8905-5d736489b4f6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7354dd50-de79-4ec6-b8b5-48622b93367c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7eef6c44-c72e-4e48-8b21-b64ba31c1849"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a1dcf9aa-7145-4716-924d-62a764c56868"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d8629184-3f4e-44ff-9ff4-b86aa4d31cc9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e355e6e3-ec25-46d6-a889-2f2f67448d13"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe899789-f7e3-49a0-ac3b-8451cfad705c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("005390b5-ec27-49b3-9f8e-25d8495fccba"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0e065e22-eccb-4eea-9e93-1b4e98b3cd1e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("12cce350-3fe5-4ccd-b4eb-5f3158741918"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1a271d48-45f3-48c7-a6a2-224092f1b852"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("22bd0d9a-acb0-4a6f-b7ce-a86027a6076c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2fcb0f34-71a9-4dc2-a160-d5436802e479"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3a8a41b3-4baa-49f5-b9f5-c947e511b4e4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5aaa0ea9-615a-4f37-9360-78c804954516"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("71f413ab-f6f5-43d6-99f0-2c6dabf015e7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("77cf6ee3-3447-439b-a8d9-1abfd9e88d11"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bc1c6ac2-dfc7-44c7-abd3-00b34e4fb202"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bd54483b-f3cf-42bb-a0d0-6d124b543cf9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c9e4671a-f264-47b8-9ef2-7b2e7e833763"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef90cca0-cdc7-4668-a9e6-237437ab1401"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f611a518-938b-43b5-a50d-afd9158ea73e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff86f8ea-2d90-4f8e-afb7-68ece7ef839e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6e030d6a-2fe0-493e-b5e4-996a8bc91f90"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c4bb7267-7362-44a4-b4c6-9996f88554e7"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("290c9bb1-a8af-4296-ab25-ef64557b72cc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5489c933-f7f6-4c4b-8640-cd6dbce82475"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c22ccfea-db4c-44d9-9d5c-04a31cec25be"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ebee3857-3c33-4296-afb6-cb091cea53e3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2a3d9a40-6169-4b19-81e4-92bacff8c2b7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("49d14838-ffc6-4703-8750-8c348a4f7158"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("889c0085-a089-4d1b-8eb2-6e9e58588f19"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d5493c36-199f-402c-8308-8322a36f5e9b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("26efe7b5-da82-4a1b-9727-72a9b24f4e2e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3dc9b764-78e9-486c-9d4f-4a20b5ccd489"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("475a6579-5042-4180-91bd-048aecf84150"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), 0, null, "WTC", 2001 },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), 0, null, "DCTV", 2016 },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("75a36637-99a0-4d3c-9715-7db08798a2dc"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("d2a31910-5dda-4288-95c2-b0f9ba408605"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("8219f84b-1c79-46ec-8c4e-3dfc7b4757e9"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("f7bf8e60-53c2-4f4e-af3c-f5880096f70a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("fa2521b0-1f7f-4204-b425-b6a387ba3e89"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("5abc3233-0e2e-472e-8de3-dff7cc79647c"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("2c3f1a86-5d39-4c31-8efc-c74c3f61c42d"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("4714c8da-c92d-47a5-9af5-7a2c1f7b4e32"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("2a256162-f9ba-48f4-aa40-6049dd844294") },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25") },
                    { new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182") },
                    { new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ec268c16-3bcd-46e9-8573-dac50d0b16ed"), 0, "Vanderplas", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.6, 15, "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("fb4c24fb-3a10-4e51-95f4-4173033395db"), 0, "VanHoof", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.55, 15, "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("6ff39d7e-9dc7-4f1c-9d84-ddef3748f5e2"), 0, "Garnaal", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.1, 15, "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("abef85e4-075f-4c95-ab79-34462e40a430"), 0, "Camara", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.51, 15, "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), 0, "Vissers", new Guid("9286fd50-09af-485d-8a81-3247cfca8be9"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.6, 15, "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("4233cb5b-f66a-4dd4-a712-d3053b0471a2"), 0, "Bambino", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("9a82887f-5832-4ac5-af9f-9f90686213d3"), 0, "Scarlet", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.5, 15, "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("fe1adc9c-36b9-42bd-9088-259260a1ec78"), 0, "Mega", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.15, 15, "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("58e5ae1e-17a6-4681-a4a9-bf7c7a553d7c"), 0, "Van Overmeire", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.5, 15, "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), 0, "Jansma", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.8, 15, "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), 0, "Franckaert", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5, 15, "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("5575eaf1-d828-46b2-bde1-861a5f6292db"), 0, "Evenepoel", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.53, 15, "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("72205c80-f5d8-4a91-86de-84a10d0ec7e3"), 0, "Beukelaer", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.6, 15, "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("a0988b94-0be3-4c94-8716-b4b386d38368"), 0, "Donckerwolcke", new Guid("cd7fd7f3-27aa-48d7-806e-7853abfd80dd"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132"), 0, "Depardieu", new Guid("d8a60e33-4ac9-486c-8f59-a31a61791537"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5534f506-e85c-4012-a113-9c49b05983fc"), 0, "Hazard", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.2, 15, "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("341cdc06-a248-4304-b919-a5801e936539"), 0, "Debruyne", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.9, 15, "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("a789d598-b574-449a-8b16-27fa3d4e8ffb"), 0, "Zalinski", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.6, 15, "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("1dbf2afc-6418-4a3a-9979-320f6a394f2d"), 0, "Mertens", new Guid("f5ea0d84-9033-48ba-bd08-4bbcd644e6fc"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.65, 15, "202CB962AC59075B964B07152D234B70", 1250, "Evelyne" },
                    { new Guid("b97a66dd-5e23-4a5f-a305-df433c8f7865"), 0, "Brokkenpap", new Guid("1b4c4e0c-2446-4e52-9036-ca66410f6eab"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.5, 15, "202CB962AC59075B964B07152D234B70", 125, "Berend" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") },
                    { new Guid("deae354e-d3f2-4fba-aabd-8e257657f0ef"), new Guid("58a16c4f-e5a6-43c0-bf8a-9a20a3895132") },
                    { new Guid("2a256162-f9ba-48f4-aa40-6049dd844294"), new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a") },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                    { new Guid("dd67d0ec-287d-475d-8a82-5bcb71c87d25"), new Guid("104c1651-2ccb-4081-b20b-0202e060866f") },
                    { new Guid("ca756deb-7c44-4bf6-8f02-2b15ad2d4182"), new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("6c8b4320-cc47-4ed1-8f7a-f3faaafdb2b7"), "Merckx", new Guid("330a06d6-67bc-4e0c-884a-413afcf3114a"), "Oranje zadel" },
                    { new Guid("7328fc02-3a93-4fc8-a781-8b7db9d539a5"), "B-Twin", new Guid("104c1651-2ccb-4081-b20b-0202e060866f"), "Zwart zadel" },
                    { new Guid("c810e934-261a-4089-af76-83650a0fd0fa"), "Moldava", new Guid("9da27aa4-279a-4d7f-a819-ecd43cb1a0b3"), "Geel zadel" }
                });
        }
    }
}
