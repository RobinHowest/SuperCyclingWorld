using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class WielrennerRecords3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WielrennerRecords_Wielrenners_WielrennerId",
                table: "WielrennerRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WielrennerRecords",
                table: "WielrennerRecords");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("0d954ef3-8e8c-4c13-8ace-bd9d0744898d"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("9c23eec8-80ec-4ec8-a12a-5b459e8c7ce3"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d2a1e7b5-f11f-4bfe-9158-9a4ef54581b8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3df57f63-fb85-4311-9938-017afa6604b9"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("62d0725e-9a69-409b-8c50-eae1631af0dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a0edf372-2381-466e-bc06-ff41640b4627"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2fdf7ed-f4d8-470a-b32c-9d8d2aa32a6d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a966c410-01de-473e-89f8-1940dfa29a78"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d24364df-ad04-4e8e-aec8-5c67554a4bb2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d44a7aab-23ff-4db7-b1e7-5b6a3ffb823b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe200d2e-e039-4b99-80ae-0df22e33602a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("01190cdb-8a84-4909-9b0f-0e8dc26ba267"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("06b84abc-6885-4d75-b5fc-a9749a583530"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("19099198-5b87-448b-8d5c-f1b8ba606184"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("201f464e-54e8-4fd1-ba1c-e0c686f4ff98"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2027e6ab-8786-4766-8d11-3e69b98ba33e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2d863a91-c79a-42e6-b602-0e126b77670a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("37db1132-88d6-4209-9833-2fa52f28028b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("79d93d2a-3c5c-449e-9102-56357ec9d2dd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7bae6c19-27c7-4149-8f18-36f7febd4e4c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b37db182-678a-434a-9c9c-e73d7bb87b7b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("be75615a-2a6e-4e53-a405-f6028f072713"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c0d47a62-8883-4fa1-968b-0e0d55959915"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d011c3c6-bdc4-42fa-97a1-58170066c8ea"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d28ee37e-bb2e-41d2-b64e-7445a754ca0b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ddcc2560-cd0d-4fec-bf8d-15de297bc939"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f9025da7-1cd1-4381-a2c7-d3b2a486a2c7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d70a6694-84a9-4417-8003-44f93dc72607"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"));

            migrationBuilder.DropColumn(
                name: "WielrennersId",
                table: "WielrennerRecords");

            migrationBuilder.AlterColumn<Guid>(
                name: "WielrennerId",
                table: "WielrennerRecords",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WielrennerRecords",
                table: "WielrennerRecords",
                columns: new[] { "RecordId", "WielrennerId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_WielrennerRecords_Wielrenners_WielrennerId",
                table: "WielrennerRecords",
                column: "WielrennerId",
                principalTable: "Wielrenners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WielrennerRecords_Wielrenners_WielrennerId",
                table: "WielrennerRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WielrennerRecords",
                table: "WielrennerRecords");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "WielrennerId",
                table: "WielrennerRecords",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "WielrennersId",
                table: "WielrennerRecords",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_WielrennerRecords",
                table: "WielrennerRecords",
                columns: new[] { "RecordId", "WielrennersId" });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), null, "WTC", 2001 },
                    { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), null, "DCTV", 2016 },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), null, "De lustige rijders", 1991 },
                    { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), null, "WTC Melsele", 1966 },
                    { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("3df57f63-fb85-4311-9938-017afa6604b9"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("fe200d2e-e039-4b99-80ae-0df22e33602a"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("d24364df-ad04-4e8e-aec8-5c67554a4bb2"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("a966c410-01de-473e-89f8-1940dfa29a78"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("62d0725e-9a69-409b-8c50-eae1631af0dd"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("a2fdf7ed-f4d8-470a-b32c-9d8d2aa32a6d"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("a0edf372-2381-466e-bc06-ff41640b4627"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("d44a7aab-23ff-4db7-b1e7-5b6a3ffb823b"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") },
                    { new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("879436d7-e038-47b8-a83f-1763a544e2ef") },
                    { new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                    { new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8") },
                    { new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("7bae6c19-27c7-4149-8f18-36f7febd4e4c"), "Mertens", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("d011c3c6-bdc4-42fa-97a1-58170066c8ea"), "Beukelaer", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145"), "Depardieu", new Guid("673105ca-d860-48d0-b21a-ae075559e7f4"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("01190cdb-8a84-4909-9b0f-0e8dc26ba267"), "Scarlet", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("f9025da7-1cd1-4381-a2c7-d3b2a486a2c7"), "Brokkenpap", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), "Jansma", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), "Franckaert", new Guid("ec30c4ee-f600-446d-980f-ad53b6144b38"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("b37db182-678a-434a-9c9c-e73d7bb87b7b"), "Bambino", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("37db1132-88d6-4209-9833-2fa52f28028b"), "Garnaal", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), "Vissers", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("79d93d2a-3c5c-449e-9102-56357ec9d2dd"), "Debruyne", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("06b84abc-6885-4d75-b5fc-a9749a583530"), "Mega", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("c0d47a62-8883-4fa1-968b-0e0d55959915"), "Donckerwolcke", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("2d863a91-c79a-42e6-b602-0e126b77670a"), "Van Overmeire", new Guid("7d98c09e-babc-42c4-8eba-70c0076d9fdd"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("201f464e-54e8-4fd1-ba1c-e0c686f4ff98"), "Hazard", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("d28ee37e-bb2e-41d2-b64e-7445a754ca0b"), "Zalinski", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("2027e6ab-8786-4766-8d11-3e69b98ba33e"), "Vanderplas", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("ddcc2560-cd0d-4fec-bf8d-15de297bc939"), "VanHoof", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("19099198-5b87-448b-8d5c-f1b8ba606184"), "Evenepoel", new Guid("d70a6694-84a9-4417-8003-44f93dc72607"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("be75615a-2a6e-4e53-a405-f6028f072713"), "Camara", new Guid("566d7d47-89f3-47ba-b94a-577e4fc8fcc3"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951") },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9") },
                    { new Guid("fe556d08-b96d-464b-9eb6-0957ad0cf3e8"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                    { new Guid("879436d7-e038-47b8-a83f-1763a544e2ef"), new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1") },
                    { new Guid("27393c9d-6712-4845-bf50-ae491c4a05f4"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") },
                    { new Guid("727e4f74-23be-4c82-86a5-ec711d8b6df0"), new Guid("dbf1007b-40ed-473f-a9ed-cb18996da145") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("d2a1e7b5-f11f-4bfe-9158-9a4ef54581b8"), "Moldava", new Guid("c61cb1fb-8cc0-4cf8-a5d4-2bd7965c3951"), "Geel zadel" },
                    { new Guid("0d954ef3-8e8c-4c13-8ace-bd9d0744898d"), "Merckx", new Guid("b5cf7014-ed83-47bf-b7ec-993e1e04c8c9"), "Oranje zadel" },
                    { new Guid("9c23eec8-80ec-4ec8-a12a-5b459e8c7ce3"), "B-Twin", new Guid("f556f6c4-958c-436c-8b84-b92e931ca7a1"), "Zwart zadel" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WielrennerRecords_Wielrenners_WielrennerId",
                table: "WielrennerRecords",
                column: "WielrennerId",
                principalTable: "Wielrenners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
