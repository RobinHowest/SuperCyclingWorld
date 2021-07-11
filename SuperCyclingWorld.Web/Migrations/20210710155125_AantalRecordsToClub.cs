using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AantalRecordsToClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f1641c0a-8724-4a21-a323-ea732e1ba1fb"), new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0"), new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"), new Guid("9025fed5-041a-4af0-ad77-595b4005c444") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"), new Guid("ef3f80eb-8d0b-4e28-83ff-1f46ffc4db4c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"), new Guid("5ffc4bce-8dd7-4424-8811-38b782a25e7e") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"), new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e"), new Guid("9025fed5-041a-4af0-ad77-595b4005c444") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("247f533a-6036-4d00-aaf1-093d7c0782de"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("7d0d352b-5f39-4250-abeb-4666db975f82"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d44bb046-6e70-4c58-91bd-250c2678a3b2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1ec169be-9b6d-4881-821f-b970d5766697"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("33febd47-887d-4bba-ab78-b845d0c627b4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("64e7776d-0879-4a07-ad00-e7891caee4a4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a1c832c6-5448-4581-9be7-0b6c8f2ed735"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d2ae6619-823a-4ebb-89b9-a8e678722d81"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("da3993c1-7d99-4706-9ffb-211e8321a6b6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("de9a601f-a2d6-4e30-8516-14103a3e9e15"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e25a502e-daa9-420c-859e-b0a1f2cf4531"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c7a7d3b-bc45-4f8d-8109-4a57597dd69c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("102b3188-f86b-4d37-9465-56814bfbb517"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("13feac95-61d2-4de0-9934-fa32a5aa9aee"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3eef1b01-bf58-4423-a9f1-71caa852cfb2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("488a5f51-53a0-4b07-bd25-1ca1e9a6796d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7b8fa465-8b84-4041-a675-d50acd41ba25"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7f0aa36c-d185-4804-9242-21972bb7277b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("81be58ea-e56e-4197-990d-178f44ec9f30"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8727013c-57d2-4384-9f50-ab13f34aaac0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("87623e5c-8adb-44f1-9f6b-597776179162"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9cca39e5-4443-4b37-b0eb-d949d818867c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b6373340-ef61-4614-8862-e413b726e5c9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("deaf9bbc-e6ba-4598-87fa-9728221fbe04"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e49c5cf8-aeee-4cae-868b-6e70ff0c62cc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e640ad42-89de-4e59-982e-c11ba5baca5d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f1332ece-f5bd-4f8b-837e-c53d0d883e23"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f1641c0a-8724-4a21-a323-ea732e1ba1fb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5ffc4bce-8dd7-4424-8811-38b782a25e7e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9025fed5-041a-4af0-ad77-595b4005c444"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef3f80eb-8d0b-4e28-83ff-1f46ffc4db4c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"));

            migrationBuilder.AddColumn<int>(
                name: "AantalRecords",
                table: "Clubs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), null, null, "WTC", 2001 },
                    { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), null, null, "DCTV", 2016 },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), null, null, "De lustige rijders", 1991 },
                    { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), null, null, "WTC Melsele", 1966 },
                    { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), null, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("9b06436e-bc3a-4513-b472-738af1ecb252"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("7129dce8-2512-44f4-81fe-645b32bf3aae"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("67b57944-7889-4e2f-9caf-8d90a201881d"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("ee287df7-e81a-4cd2-a489-09027473f59f"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("92baf6f3-a96a-424f-9c3b-6f417bb56322"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("04e39160-eba3-4a73-b64f-354f301dbe8a"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("76efa838-c80f-4728-90bd-508670e1ffbf"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("ed9c6fa3-c097-4bba-9746-eec97166446e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") },
                    { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") },
                    { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") },
                    { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") },
                    { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("f2537ae5-9070-4f84-af99-4f90fd927029"), "Evenepoel", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("0a56518b-abbb-46de-a33a-aac3557e08df"), "Zalinski", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("206a866c-4b63-4a5a-8b21-e73e06c0b974"), "Beukelaer", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("17f26329-c361-4732-9f12-c3c005e09538"), "Mega", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("00eeeb2b-a733-4294-8bf4-c86a80e1a3be"), "Brokkenpap", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("04af8132-644e-42ce-922b-64e0e44843d8"), "Garnaal", new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("3eac50db-3fe5-474e-b2d9-791818ac85a2"), "Bambino", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("db54d54d-0da3-4655-9c52-6429a7a85395"), "Donckerwolcke", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("0634ce45-8b83-4b96-be60-7651c709547b"), "Camara", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("77f2b596-ed80-49c7-9a15-8e764d01db63"), "Van Overmeire", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("a407a370-dbcc-4a82-af8d-9af308512d09"), "Depardieu", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"), "Jansma", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"), "Franckaert", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("f0f5a076-5386-4103-8c7d-df44b0b589a4"), "Debruyne", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("40ebb97c-94c1-4482-afa3-4ec4379054d6"), "Mertens", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"), "Vissers", new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("382d98d2-52ae-4ee4-be1f-a4a0977e898f"), "Hazard", new Guid("2e2c8704-567f-44db-a674-26649a31e243"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("cd5e5c4f-08e7-40e7-904e-1a3deaf6f64f"), "Scarlet", new Guid("2e2c8704-567f-44db-a674-26649a31e243"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("ca7d2a38-2650-4c6a-a3d5-3e1aeea8653f"), "Vanderplas", new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("251a755e-8bda-4015-b14c-80a425b89f0b"), "VanHoof", new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("58470357-c242-446e-8dff-4bdf9c83a42c") },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f") },
                    { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") },
                    { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") },
                    { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") },
                    { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("c14722c5-07af-43e4-8aaf-d5f3bc8faa95"), "Moldava", new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"), "Geel zadel" },
                    { new Guid("c79d26da-d34c-41b8-9016-8584f47ebcda"), "Merckx", new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"), "Oranje zadel" },
                    { new Guid("bae1b48a-4252-45fc-8c81-069e92858774"), "B-Twin", new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"), "Zwart zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2e2c8704-567f-44db-a674-26649a31e243"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("451c725a-45a2-4f9b-98c3-ce595352667f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"), new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"), new Guid("58470357-c242-446e-8dff-4bdf9c83a42c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("a407a370-dbcc-4a82-af8d-9af308512d09") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"), new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"), new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bae1b48a-4252-45fc-8c81-069e92858774"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c14722c5-07af-43e4-8aaf-d5f3bc8faa95"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c79d26da-d34c-41b8-9016-8584f47ebcda"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("04e39160-eba3-4a73-b64f-354f301dbe8a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("67b57944-7889-4e2f-9caf-8d90a201881d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7129dce8-2512-44f4-81fe-645b32bf3aae"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("76efa838-c80f-4728-90bd-508670e1ffbf"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("92baf6f3-a96a-424f-9c3b-6f417bb56322"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9b06436e-bc3a-4513-b472-738af1ecb252"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ed9c6fa3-c097-4bba-9746-eec97166446e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ee287df7-e81a-4cd2-a489-09027473f59f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("00eeeb2b-a733-4294-8bf4-c86a80e1a3be"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04af8132-644e-42ce-922b-64e0e44843d8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0634ce45-8b83-4b96-be60-7651c709547b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0a56518b-abbb-46de-a33a-aac3557e08df"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("17f26329-c361-4732-9f12-c3c005e09538"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("206a866c-4b63-4a5a-8b21-e73e06c0b974"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("251a755e-8bda-4015-b14c-80a425b89f0b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("382d98d2-52ae-4ee4-be1f-a4a0977e898f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3eac50db-3fe5-474e-b2d9-791818ac85a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("40ebb97c-94c1-4482-afa3-4ec4379054d6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("77f2b596-ed80-49c7-9a15-8e764d01db63"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ca7d2a38-2650-4c6a-a3d5-3e1aeea8653f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cd5e5c4f-08e7-40e7-904e-1a3deaf6f64f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("db54d54d-0da3-4655-9c52-6429a7a85395"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0f5a076-5386-4103-8c7d-df44b0b589a4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f2537ae5-9070-4f84-af99-4f90fd927029"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2e2c8704-567f-44db-a674-26649a31e243"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("745b3969-eafd-4a37-939b-0a30f4d14c42"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c5e50a47-1fa0-490f-bfd1-400416386ef8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("451c725a-45a2-4f9b-98c3-ce595352667f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5868e40d-dc2e-43ee-813f-1be6c012dcb0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("806bda6a-84b8-453f-8e59-2d1ca7484c5d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9029ec6a-15f9-4eee-b274-89f57f81693c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5318234d-1318-4278-a69a-2c58fc0f8c24"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("58470357-c242-446e-8dff-4bdf9c83a42c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a407a370-dbcc-4a82-af8d-9af308512d09"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("dfaee7d0-a57c-4d96-8b20-b133120c1f6f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("5dad3bcd-5423-4b4d-9bbf-f73d8842772d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ee17d8e0-ced4-4792-8404-c573c2d4ed04"));

            migrationBuilder.DropColumn(
                name: "AantalRecords",
                table: "Clubs");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), null, "WTC", 2001 },
                    { new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), null, "DCTV", 2016 },
                    { new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), null, "De lustige rijders", 1991 },
                    { new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), null, "WTC Melsele", 1966 },
                    { new Guid("f1641c0a-8724-4a21-a323-ea732e1ba1fb"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("a1c832c6-5448-4581-9be7-0b6c8f2ed735"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("de9a601f-a2d6-4e30-8516-14103a3e9e15"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("1ec169be-9b6d-4881-821f-b970d5766697"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("33febd47-887d-4bba-ab78-b845d0c627b4"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("e25a502e-daa9-420c-859e-b0a1f2cf4531"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("64e7776d-0879-4a07-ad00-e7891caee4a4"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d2ae6619-823a-4ebb-89b9-a8e678722d81"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("da3993c1-7d99-4706-9ffb-211e8321a6b6"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("f1641c0a-8724-4a21-a323-ea732e1ba1fb"), new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6") },
                    { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e") },
                    { new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e") },
                    { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0") },
                    { new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0") },
                    { new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8") },
                    { new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8") },
                    { new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("81be58ea-e56e-4197-990d-178f44ec9f30"), "Evenepoel", new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("e640ad42-89de-4e59-982e-c11ba5baca5d"), "Bambino", new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("7f0aa36c-d185-4804-9242-21972bb7277b"), "Mega", new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("87623e5c-8adb-44f1-9f6b-597776179162"), "Camara", new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a"), "Jansma", new Guid("d181aa44-02c1-4b81-b8d4-11d0c3018e98"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("488a5f51-53a0-4b07-bd25-1ca1e9a6796d"), "Zalinski", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("7b8fa465-8b84-4041-a675-d50acd41ba25"), "Beukelaer", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("deaf9bbc-e6ba-4598-87fa-9728221fbe04"), "Van Overmeire", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("5ffc4bce-8dd7-4424-8811-38b782a25e7e"), "Vissers", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("ef3f80eb-8d0b-4e28-83ff-1f46ffc4db4c"), "Franckaert", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("102b3188-f86b-4d37-9465-56814bfbb517"), "Vanderplas", new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("0c7a7d3b-bc45-4f8d-8109-4a57597dd69c"), "Mertens", new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("3eef1b01-bf58-4423-a9f1-71caa852cfb2"), "Brokkenpap", new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("8727013c-57d2-4384-9f50-ab13f34aaac0"), "Garnaal", new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("9025fed5-041a-4af0-ad77-595b4005c444"), "Depardieu", new Guid("f32a3812-fcb9-424a-bfd7-79ac4c859bc4"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("b6373340-ef61-4614-8862-e413b726e5c9"), "Hazard", new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("9cca39e5-4443-4b37-b0eb-d949d818867c"), "Debruyne", new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("f1332ece-f5bd-4f8b-837e-c53d0d883e23"), "VanHoof", new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("13feac95-61d2-4de0-9934-fa32a5aa9aee"), "Scarlet", new Guid("7f1bc323-3ea1-4f27-861d-7ec2de2f4e29"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("e49c5cf8-aeee-4cae-868b-6e70ff0c62cc"), "Donckerwolcke", new Guid("d9e2fee0-57fe-4c15-89ad-688d6ddedcc7"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"), new Guid("9025fed5-041a-4af0-ad77-595b4005c444") },
                    { new Guid("c40073c6-7294-49fb-9834-b0fe6f72eb3e"), new Guid("9025fed5-041a-4af0-ad77-595b4005c444") },
                    { new Guid("42f3b2cf-182a-4238-bcc3-4a2c4d9edda6"), new Guid("ef3f80eb-8d0b-4e28-83ff-1f46ffc4db4c") },
                    { new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"), new Guid("5ffc4bce-8dd7-4424-8811-38b782a25e7e") },
                    { new Guid("a0457c5f-660c-40f3-9933-1c397ef308e8"), new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a") },
                    { new Guid("3725aa52-3949-4555-8be1-8ae7e0dfaad0"), new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("7d0d352b-5f39-4250-abeb-4666db975f82"), "Merckx", new Guid("ef3f80eb-8d0b-4e28-83ff-1f46ffc4db4c"), "Oranje zadel" },
                    { new Guid("d44bb046-6e70-4c58-91bd-250c2678a3b2"), "Moldava", new Guid("5ffc4bce-8dd7-4424-8811-38b782a25e7e"), "Geel zadel" },
                    { new Guid("247f533a-6036-4d00-aaf1-093d7c0782de"), "B-Twin", new Guid("f2a88249-b0ad-491f-9786-5df9f0702d4a"), "Zwart zadel" }
                });
        }
    }
}
