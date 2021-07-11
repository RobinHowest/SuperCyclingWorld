using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class Seedkilometers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"), new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"), new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"), new Guid("8c21bef4-ef18-4ec7-90fc-9a1f4c8d87cf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"), new Guid("4690d765-84e3-4b2d-bbba-bddb8c9a235a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"), new Guid("485acdb5-df46-459f-a02f-e39f537bb369") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb"), new Guid("485acdb5-df46-459f-a02f-e39f537bb369") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d"), new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bbc0b5b3-c626-451c-9129-375ca80d8373"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bd347052-a949-42bf-854b-c556e08f7156"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("ccaf3fea-a631-4c17-8d65-5966b796fab8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("134b3b5d-90d7-45f5-af8e-4e6898b000fa"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("21aff2f8-595b-4941-a9bb-296a0b937206"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2f8175bd-0c94-47ab-99b1-3b88fc08f407"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5655dcea-1089-4a0c-8541-f65be06d5318"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("579dfdc0-c397-4edc-9794-bdd21da9e5de"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5b7a4207-ab99-46a6-8677-d13b8073746a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8850c833-e0f5-4b6a-a3bf-44616fe7ace9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("97d05014-f77d-46f3-8a3c-7a29b1068f9b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0b537ded-d7bb-4a7f-a509-88acaa21ab2c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c7ad8e8-6915-474c-9c45-3bd1daf899f1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2ffcee1d-d4d7-43e5-9f01-30368bc9c385"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("361fd7d6-84d6-45ec-b69d-a744667a6941"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4783c547-4a33-437e-ba45-098b47a20feb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("489c8dbb-ca16-4aa9-b62d-13d9a8cb806e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b44ee49-c2de-4f02-ae06-4fc682e0b8fd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8eba4739-4583-4f5e-bee2-f710147933ac"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("944ba1be-e23d-4d01-91b1-7d93051dc0d7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a7c5f557-8185-4757-8412-a22d127172e0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("aaca6b2e-20f5-4111-bd8d-1566396c75cb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bee50d24-a6f4-4527-9fca-5dc1ca0b4c4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c49b8b08-0cdd-4a9e-96b9-0b1f7ec3c80a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c7b50ad0-6c56-4ecf-b889-45e1daeffa6f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ca4952c2-b104-4b1c-a66a-04d31212cc93"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d1a53b5f-ab8c-4d9c-a4a4-d28b73d18f15"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4690d765-84e3-4b2d-bbba-bddb8c9a235a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("485acdb5-df46-459f-a02f-e39f537bb369"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8c21bef4-ef18-4ec7-90fc-9a1f4c8d87cf"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"));

            migrationBuilder.AddColumn<int>(
                name: "TotaalAantalGeredenKilometers",
                table: "Wielrenners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecordCijfer",
                table: "Records",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RecordEenheid",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecordType",
                table: "Records",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Recordnaam",
                table: "Records",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WielrennerId",
                table: "Records",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Records_WielrennerId",
                table: "Records",
                column: "WielrennerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Wielrenners_WielrennerId",
                table: "Records",
                column: "WielrennerId",
                principalTable: "Wielrenners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Wielrenners_WielrennerId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_WielrennerId",
                table: "Records");

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

            migrationBuilder.DropColumn(
                name: "TotaalAantalGeredenKilometers",
                table: "Wielrenners");

            migrationBuilder.DropColumn(
                name: "RecordCijfer",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "RecordEenheid",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "RecordType",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Recordnaam",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "WielrennerId",
                table: "Records");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), null, "WTC", 2001 },
                    { new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), null, "DCTV", 2016 },
                    { new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), null, "De lustige rijders", 1991 },
                    { new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), null, "WTC Melsele", 1966 },
                    { new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("134b3b5d-90d7-45f5-af8e-4e6898b000fa"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("21aff2f8-595b-4941-a9bb-296a0b937206"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("5655dcea-1089-4a0c-8541-f65be06d5318"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("8850c833-e0f5-4b6a-a3bf-44616fe7ace9"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("2f8175bd-0c94-47ab-99b1-3b88fc08f407"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("579dfdc0-c397-4edc-9794-bdd21da9e5de"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("5b7a4207-ab99-46a6-8677-d13b8073746a"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("97d05014-f77d-46f3-8a3c-7a29b1068f9b"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"), new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa") },
                    { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb") },
                    { new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb") },
                    { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d") },
                    { new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d") },
                    { new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366") },
                    { new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366") },
                    { new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8eba4739-4583-4f5e-bee2-f710147933ac"), "Debruyne", new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("c49b8b08-0cdd-4a9e-96b9-0b1f7ec3c80a"), "Zalinski", new Guid("f6a95b4b-c403-40dc-92b1-50b26aa0b00b"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("0c7ad8e8-6915-474c-9c45-3bd1daf899f1"), "Bambino", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("361fd7d6-84d6-45ec-b69d-a744667a6941"), "Vanderplas", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("c7b50ad0-6c56-4ecf-b889-45e1daeffa6f"), "Beukelaer", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("a7c5f557-8185-4757-8412-a22d127172e0"), "Scarlet", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("ca4952c2-b104-4b1c-a66a-04d31212cc93"), "Mega", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("4783c547-4a33-437e-ba45-098b47a20feb"), "Camara", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd"), "Jansma", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("6b44ee49-c2de-4f02-ae06-4fc682e0b8fd"), "Hazard", new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("aaca6b2e-20f5-4111-bd8d-1566396c75cb"), "Mertens", new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("489c8dbb-ca16-4aa9-b62d-13d9a8cb806e"), "Brokkenpap", new Guid("125b3482-91ad-4dac-88e3-7e7b87e5b9d5"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("0b537ded-d7bb-4a7f-a509-88acaa21ab2c"), "Donckerwolcke", new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("d1a53b5f-ab8c-4d9c-a4a4-d28b73d18f15"), "Van Overmeire", new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("485acdb5-df46-459f-a02f-e39f537bb369"), "Depardieu", new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("4690d765-84e3-4b2d-bbba-bddb8c9a235a"), "Franckaert", new Guid("d0121570-8ca0-4a1b-ab0c-2d0c4b099b10"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("944ba1be-e23d-4d01-91b1-7d93051dc0d7"), "Evenepoel", new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("2ffcee1d-d4d7-43e5-9f01-30368bc9c385"), "VanHoof", new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("bee50d24-a6f4-4527-9fca-5dc1ca0b4c4a"), "Garnaal", new Guid("b81344fa-ced0-4d12-b903-f8d865403b9f"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("8c21bef4-ef18-4ec7-90fc-9a1f4c8d87cf"), "Vissers", new Guid("80bcb85e-f32c-41fb-a369-7a2067e486a9"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"), new Guid("8c21bef4-ef18-4ec7-90fc-9a1f4c8d87cf") },
                    { new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"), new Guid("4690d765-84e3-4b2d-bbba-bddb8c9a235a") },
                    { new Guid("8112bb46-450f-4785-aa62-e7bb35dcf7aa"), new Guid("485acdb5-df46-459f-a02f-e39f537bb369") },
                    { new Guid("8ff56b90-e675-424c-98fe-a45bfa7016cb"), new Guid("485acdb5-df46-459f-a02f-e39f537bb369") },
                    { new Guid("0fedb7ac-4434-4450-9257-e9fec17b1366"), new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd") },
                    { new Guid("b7ae1113-e8ca-4e2b-a2cf-96be1ed45f5d"), new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("ccaf3fea-a631-4c17-8d65-5966b796fab8"), "Moldava", new Guid("8c21bef4-ef18-4ec7-90fc-9a1f4c8d87cf"), "Geel zadel" },
                    { new Guid("bbc0b5b3-c626-451c-9129-375ca80d8373"), "Merckx", new Guid("4690d765-84e3-4b2d-bbba-bddb8c9a235a"), "Oranje zadel" },
                    { new Guid("bd347052-a949-42bf-854b-c556e08f7156"), "B-Twin", new Guid("09e6f343-df37-42d7-bdb0-a51d256c5dbd"), "Zwart zadel" }
                });
        }
    }
}
