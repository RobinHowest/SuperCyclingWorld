using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddWattageToWielrenners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("173a8be2-bd13-4f75-bd8c-b5379bdda172"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("45dd75f6-1dae-4e61-ae3d-f28bc4cbe144"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d8b3a9a0-3f92-4aef-b30f-85465ef7f852"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("387affc6-34d9-44a9-8145-441eca511554"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6b9b80be-b723-4476-b2d9-42219a150ddb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7a9ae06d-6ea8-4a71-ba44-3d1ec15cf387"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("874a86df-1e68-42a0-a039-92a4b0eb26c4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("87856043-d04f-4267-9933-fcd2949037ba"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8962cf78-9067-4291-bd05-a448911f77fd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9f8841da-501f-4a2f-b4a1-7e7dc2a99a95"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("beab6730-67d1-4fff-b266-bdc189a729a3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0aadb9e8-e50d-40fc-8152-8fe49c35470d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3725d26c-9c90-4da7-896e-632829177408"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("49234ac9-93de-4622-add6-7774df8b8667"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("56eb8839-95f3-4af9-a81d-9615c7141a7a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6c22d35c-8dbb-4f67-94c9-76679b08a92f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7d9493f3-b098-4086-a4a6-6a010a5ecfb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("812a047a-c778-4496-8dc3-d6ed9825e2de"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a1c453ff-3aff-4d5e-8aeb-9406a6169325"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a716d5c4-f263-4a90-9e10-0edf468c905a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c6b434db-3313-4b3f-b9b6-1d53c3b703ec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7e7db0b-8ef5-4c08-b0c2-2971f24970b1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d9561014-5fff-4ce9-9331-eb386148c1d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d9f19d9e-72bd-4086-a715-4dd1c94b2448"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("de41aa2e-e3a6-4d5f-a27b-3879143e7899"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e40e5ad9-3eb5-4abe-9b72-bdcb3cdb1402"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f75407e2-8a97-4f4f-9051-3f266fe2f546"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cebce923-1654-4da3-ab39-260c83b77735"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("982e1006-3967-47b4-b631-f728056d3e3e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04453c14-15a5-4616-89eb-1cc233ddb858"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"));

            migrationBuilder.AddColumn<int>(
                name: "WattageRecord",
                table: "Wielrenners",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "WattageRecord",
                table: "Wielrenners");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), 0, null, "WTC", 2001 },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), 0, null, "DCTV", 2016 },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("874a86df-1e68-42a0-a039-92a4b0eb26c4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("7a9ae06d-6ea8-4a71-ba44-3d1ec15cf387"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("87856043-d04f-4267-9933-fcd2949037ba"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("387affc6-34d9-44a9-8145-441eca511554"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("6b9b80be-b723-4476-b2d9-42219a150ddb"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("8962cf78-9067-4291-bd05-a448911f77fd"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("9f8841da-501f-4a2f-b4a1-7e7dc2a99a95"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("beab6730-67d1-4fff-b266-bdc189a729a3"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3") },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5") },
                    { new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("cebce923-1654-4da3-ab39-260c83b77735"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("af21f127-db18-4921-9f43-ddb8795c7cae") },
                    { new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), new Guid("982e1006-3967-47b4-b631-f728056d3e3e") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "AantalRecords", "Achternaam", "ClubId", "Email", "GeboorteDatum", "GemiddeldKm_h", "GemiddeldeKM_Rit", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("7d9493f3-b098-4086-a4a6-6a010a5ecfb5"), 0, "Hazard", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.0, 14, "202CB962AC59075B964B07152D234B70", 118, "Eden" },
                    { new Guid("c7e7db0b-8ef5-4c08-b0c2-2971f24970b1"), 0, "Bambino", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46.0, 11, "202CB962AC59075B964B07152D234B70", 115, "Salvatore" },
                    { new Guid("49234ac9-93de-4622-add6-7774df8b8667"), 0, "Scarlet", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.0, 6, "202CB962AC59075B964B07152D234B70", 110, "Johanson" },
                    { new Guid("3725d26c-9c90-4da7-896e-632829177408"), 0, "Mega", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40.0, 5, "202CB962AC59075B964B07152D234B70", 109, "Mindy" },
                    { new Guid("a716d5c4-f263-4a90-9e10-0edf468c905a"), 0, "Garnaal", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.0, 80, "202CB962AC59075B964B07152D234B70", 107, "Sofie" },
                    { new Guid("04453c14-15a5-4616-89eb-1cc233ddb858"), 0, "Depardieu", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.0, 40, "202CB962AC59075B964B07152D234B70", 103, "Gerard" },
                    { new Guid("de41aa2e-e3a6-4d5f-a27b-3879143e7899"), 0, "Zalinski", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47.0, 12, "202CB962AC59075B964B07152D234B70", 116, "Wosznjeck" },
                    { new Guid("c6b434db-3313-4b3f-b9b6-1d53c3b703ec"), 0, "Beukelaer", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42.0, 7, "202CB962AC59075B964B07152D234B70", 111, "Koekjes" },
                    { new Guid("56eb8839-95f3-4af9-a81d-9615c7141a7a"), 0, "Donckerwolcke", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37.0, 70, "202CB962AC59075B964B07152D234B70", 106, "Thomas" },
                    { new Guid("f75407e2-8a97-4f4f-9051-3f266fe2f546"), 0, "Van Overmeire", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0, 50, "202CB962AC59075B964B07152D234B70", 104, "Marc" },
                    { new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"), 0, "Jansma", new Guid("563d53d5-3056-45ad-a1c8-341aa26c713a"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.0, 20, "202CB962AC59075B964B07152D234B70", 101, "Johanna" },
                    { new Guid("a1c453ff-3aff-4d5e-8aeb-9406a6169325"), 0, "Brokkenpap", new Guid("5261d7ed-e2be-4fca-9724-a7f95d93c030"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.0, 90, "202CB962AC59075B964B07152D234B70", 108, "Berend" },
                    { new Guid("6c22d35c-8dbb-4f67-94c9-76679b08a92f"), 0, "Debruyne", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48.0, 13, "202CB962AC59075B964B07152D234B70", 117, "Kevin" },
                    { new Guid("d9561014-5fff-4ce9-9331-eb386148c1d0"), 0, "Vanderplas", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 10, "202CB962AC59075B964B07152D234B70", 114, "Sonja" },
                    { new Guid("d9f19d9e-72bd-4086-a715-4dd1c94b2448"), 0, "VanHoof", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44.0, 9, "202CB962AC59075B964B07152D234B70", 113, "Emily" },
                    { new Guid("e40e5ad9-3eb5-4abe-9b72-bdcb3cdb1402"), 0, "Mertens", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43.0, 8, "202CB962AC59075B964B07152D234B70", 112, "Evelyne" },
                    { new Guid("812a047a-c778-4496-8dc3-d6ed9825e2de"), 0, "Camara", new Guid("cebce923-1654-4da3-ab39-260c83b77735"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36.0, 60, "202CB962AC59075B964B07152D234B70", 105, "Herdy" },
                    { new Guid("0aadb9e8-e50d-40fc-8152-8fe49c35470d"), 0, "Evenepoel", new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 15, "202CB962AC59075B964B07152D234B70", 119, "Remco" },
                    { new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"), 0, "Vissers", new Guid("df5604c8-8921-4e10-ae65-df7a1e7c6def"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.0, 30, "202CB962AC59075B964B07152D234B70", 102, "Bert" },
                    { new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"), 0, "Franckaert", new Guid("76146591-004d-4d4b-9c92-ac4655571fa2"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31.0, 10, "202CB962AC59075B964B07152D234B70", 100, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926") },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") },
                    { new Guid("6452bbee-4e0d-42bb-83cb-41cd6e24bea5"), new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63") },
                    { new Guid("af21f127-db18-4921-9f43-ddb8795c7cae"), new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7") },
                    { new Guid("330c73d2-a16a-48ab-924b-50b427f87ee3"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") },
                    { new Guid("982e1006-3967-47b4-b631-f728056d3e3e"), new Guid("04453c14-15a5-4616-89eb-1cc233ddb858") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("45dd75f6-1dae-4e61-ae3d-f28bc4cbe144"), "Merckx", new Guid("a8b9b35d-290d-4f84-be86-5f142f3d9926"), "Oranje zadel" },
                    { new Guid("d8b3a9a0-3f92-4aef-b30f-85465ef7f852"), "B-Twin", new Guid("2a2159ba-1d17-47b0-a949-8af63f8c1a63"), "Zwart zadel" },
                    { new Guid("173a8be2-bd13-4f75-bd8c-b5379bdda172"), "Moldava", new Guid("294a5dbb-9df4-4950-b102-a14ade6818c7"), "Geel zadel" }
                });
        }
    }
}
