using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class RandomClubOfWielrenners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("caeb9ece-702e-4d38-9720-34e351811477") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("035e420b-da9b-47fd-b284-63721cfec6bd"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5944cd1a-1b61-43c9-a437-1dba6bdd72ab"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f59b3acd-5a4c-4c7a-bc11-f90d3185ab6a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("002325d7-e96d-4301-becf-b92fec46abf4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0902b607-8934-4b7c-8a0e-6f4255ef434a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("12eba1aa-892c-4d1e-b30b-84e7373911ab"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("686fb06c-05d9-4872-a97c-110e3637b03e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7d39e646-a83e-474a-867e-3fcaf88c1a34"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("880d8cb8-11b9-49b6-80fa-0d25669fa478"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("88804fe0-7810-4296-b172-bb6ef1ce802f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d32fd3a9-74b8-4ce6-a1b5-f99558460cc4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0578ed5a-c17d-473f-bf0d-cc4bed869b0a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2e227195-99cf-4402-8121-be4bcb7e3ce4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3faa3b48-40f4-4c82-9acf-cab9347c5d3a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5688cedd-8505-44a3-a6f6-dfb7932d8874"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5c497e9c-34af-4e48-aa09-8fb77cb862d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6cf6c9fd-07c6-4b52-8410-9ef7d1880f4a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7b4abb71-98da-4104-b63f-c008961ce82f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8e011213-ff3b-463b-aef2-cba0d43cfead"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("94ebed51-6c44-4b24-96ef-e179a05d9c8b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d59e14a-c17d-45ff-b2a9-3fe783b86f76"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cccb3372-ec39-4de6-a11a-e1e0cef0d2b5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d90e41f1-86e3-4d77-a770-42f79ebfb06b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ee96e9a9-ac99-462c-b9e8-3e99e33062d8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f1f54e7c-2cc1-4c9d-82f9-b68bf07758a5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f7d1bc37-9af3-4af2-a0a0-ab2b845f2c60"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fa8b0cc9-37f7-4cfc-be42-e56761b76d97"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("caeb9ece-702e-4d38-9720-34e351811477"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), null, "WTC" },
                    { new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), null, "DCTV" },
                    { new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), null, "De lustige rijders" },
                    { new Guid("ed952d83-e788-4c66-bf85-0143859f120b"), null, "WTC Melsele" },
                    { new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("fa4c28f2-1ddd-4a19-8286-ca4b5d99b99b"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("01545422-6a34-4feb-8df6-ab1c76cd84c1"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("89aee80e-f503-42a1-9034-92017c2389be"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("d7205a08-e69e-4a74-8981-1c956ea2635e"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("a970a7e8-1270-441d-9a8d-41a1939c654c"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("3efb3bd3-77ac-41be-9b68-76df2f0313dd"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("583d618d-1bd8-46b1-8369-723dbf29d126"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("ade6b0ec-e8f8-4ed8-a14a-b79f65018061"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("d8f01dcc-a562-433e-90bf-d74fb6905b7d"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74") },
                    { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e") },
                    { new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e") },
                    { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("583d618d-1bd8-46b1-8369-723dbf29d126") },
                    { new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), new Guid("583d618d-1bd8-46b1-8369-723dbf29d126") },
                    { new Guid("ed952d83-e788-4c66-bf85-0143859f120b"), new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0") },
                    { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0") },
                    { new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("b5486b98-1944-45a7-9838-cdb7758aa807"), "Evenepoel", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("aa18a2c0-f08a-40e4-83e2-9b3188c54bce"), "Hazard", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("0ee2f749-ac44-4881-8132-1fea359b7815"), "Brokkenpap", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("cf9a1ddd-3b10-44e9-a925-f15b0f50de2a"), "Garnaal", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("88454017-8023-4d00-a86e-7ecd7d899a6d"), "Van Overmeire", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b"), "Jansma", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("b98ab10a-e854-4ec2-a2bc-7f8b9cd9f99b"), "Franckaert", new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("9bfdc1a1-c9ba-4f0e-b9c5-9eda2a9b8604"), "Camara", new Guid("ed952d83-e788-4c66-bf85-0143859f120b"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("45dfe8d8-0c55-4e98-b840-afa7d5df042d"), "Bambino", new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("a7d44fa5-bcdf-4986-8910-2062f2105a0b"), "VanHoof", new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("47f609cf-f40f-425d-883d-3762592c3ea5"), "Depardieu", new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("8f7b22c4-b9b9-47c5-b07a-c0f38654b533"), "Debruyne", new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("1d5cc85c-1cff-4a07-9e6f-7a22da6edf61"), "Zalinski", new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("bf7b1648-f1f7-42d3-a15d-ce89eac2ebfd"), "Vanderplas", new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("98a923b2-1abb-4bcb-9d3e-4c1bbb74994c"), "Mertens", new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("b43cb09c-371e-4ce4-95ed-b627413c5772"), "Beukelaer", new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("375c24c2-2366-4f3d-b7f2-d52319c97ea7"), "Mega", new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("c2fe08ab-3fa2-4793-a815-78bba06d0166"), "Donckerwolcke", new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("5f25879c-79a5-46f4-91fd-66358dbb2399"), "Scarlet", new Guid("ed952d83-e788-4c66-bf85-0143859f120b"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("95897512-6814-4fff-b33f-0d74f001681b"), "Vissers", new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"), new Guid("95897512-6814-4fff-b33f-0d74f001681b") },
                    { new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"), new Guid("47f609cf-f40f-425d-883d-3762592c3ea5") },
                    { new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e"), new Guid("47f609cf-f40f-425d-883d-3762592c3ea5") },
                    { new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"), new Guid("b98ab10a-e854-4ec2-a2bc-7f8b9cd9f99b") },
                    { new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"), new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b") },
                    { new Guid("583d618d-1bd8-46b1-8369-723dbf29d126"), new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("5f57e9b1-7286-4656-81a8-6912323d9760"), "Moldava", new Guid("95897512-6814-4fff-b33f-0d74f001681b"), "Geel zadel" },
                    { new Guid("1a06bdfb-eec7-4fad-9d0c-b740130cc0e6"), "Merckx", new Guid("b98ab10a-e854-4ec2-a2bc-7f8b9cd9f99b"), "Oranje zadel" },
                    { new Guid("8f68ef89-791f-4a9c-88bd-8e5368f99c9d"), "B-Twin", new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b"), "Zwart zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"), new Guid("583d618d-1bd8-46b1-8369-723dbf29d126") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("34f81176-2917-42c3-b518-8b02bb8be713"), new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"), new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), new Guid("583d618d-1bd8-46b1-8369-723dbf29d126") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"), new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ed952d83-e788-4c66-bf85-0143859f120b"), new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e"), new Guid("47f609cf-f40f-425d-883d-3762592c3ea5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"), new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"), new Guid("95897512-6814-4fff-b33f-0d74f001681b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("583d618d-1bd8-46b1-8369-723dbf29d126"), new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"), new Guid("47f609cf-f40f-425d-883d-3762592c3ea5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"), new Guid("b98ab10a-e854-4ec2-a2bc-7f8b9cd9f99b") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("1a06bdfb-eec7-4fad-9d0c-b740130cc0e6"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5f57e9b1-7286-4656-81a8-6912323d9760"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("8f68ef89-791f-4a9c-88bd-8e5368f99c9d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("01545422-6a34-4feb-8df6-ab1c76cd84c1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3efb3bd3-77ac-41be-9b68-76df2f0313dd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("89aee80e-f503-42a1-9034-92017c2389be"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a970a7e8-1270-441d-9a8d-41a1939c654c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ade6b0ec-e8f8-4ed8-a14a-b79f65018061"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d7205a08-e69e-4a74-8981-1c956ea2635e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d8f01dcc-a562-433e-90bf-d74fb6905b7d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fa4c28f2-1ddd-4a19-8286-ca4b5d99b99b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0ee2f749-ac44-4881-8132-1fea359b7815"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1d5cc85c-1cff-4a07-9e6f-7a22da6edf61"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("375c24c2-2366-4f3d-b7f2-d52319c97ea7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("45dfe8d8-0c55-4e98-b840-afa7d5df042d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5f25879c-79a5-46f4-91fd-66358dbb2399"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("88454017-8023-4d00-a86e-7ecd7d899a6d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8f7b22c4-b9b9-47c5-b07a-c0f38654b533"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("98a923b2-1abb-4bcb-9d3e-4c1bbb74994c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9bfdc1a1-c9ba-4f0e-b9c5-9eda2a9b8604"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a7d44fa5-bcdf-4986-8910-2062f2105a0b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("aa18a2c0-f08a-40e4-83e2-9b3188c54bce"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b43cb09c-371e-4ce4-95ed-b627413c5772"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b5486b98-1944-45a7-9838-cdb7758aa807"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bf7b1648-f1f7-42d3-a15d-ce89eac2ebfd"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c2fe08ab-3fa2-4793-a815-78bba06d0166"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cf9a1ddd-3b10-44e9-a925-f15b0f50de2a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bb7f1996-516a-4419-b46d-c11b3ecc4cbd"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ed952d83-e788-4c66-bf85-0143859f120b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("2bf72cb3-08f3-4b6e-b449-6beee971776e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3142f58f-ced4-43f2-9695-861a715d8ed0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("583d618d-1bd8-46b1-8369-723dbf29d126"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5d35f628-12db-42b7-ac20-feb62d7b5d74"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("31083c41-4e2a-4559-8341-eb64e8ebbd2b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("47f609cf-f40f-425d-883d-3762592c3ea5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("95897512-6814-4fff-b33f-0d74f001681b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b98ab10a-e854-4ec2-a2bc-7f8b9cd9f99b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("00bf9430-e1cb-45f5-beac-8660eb34ec2d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("34f81176-2917-42c3-b518-8b02bb8be713"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d336dfe2-36f1-42c6-988c-f878ece07c9e"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), null, "WTC" },
                    { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), null, "DCTV" },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), null, "De lustige rijders" },
                    { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), null, "WTC Melsele" },
                    { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d32fd3a9-74b8-4ce6-a1b5-f99558460cc4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("12eba1aa-892c-4d1e-b30b-84e7373911ab"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("686fb06c-05d9-4872-a97c-110e3637b03e"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("0902b607-8934-4b7c-8a0e-6f4255ef434a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("880d8cb8-11b9-49b6-80fa-0d25669fa478"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("88804fe0-7810-4296-b172-bb6ef1ce802f"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("002325d7-e96d-4301-becf-b92fec46abf4"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("7d39e646-a83e-474a-867e-3fcaf88c1a34"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") },
                    { new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5") },
                    { new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") },
                    { new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f") },
                    { new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8e011213-ff3b-463b-aef2-cba0d43cfead"), "Evenepoel", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("fa8b0cc9-37f7-4cfc-be42-e56761b76d97"), "Vanderplas", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("ee96e9a9-ac99-462c-b9e8-3e99e33062d8"), "Mega", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("5688cedd-8505-44a3-a6f6-dfb7932d8874"), "Van Overmeire", new Guid("6d5c1a5a-66d4-41b5-b095-39d43220fb89"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("cccb3372-ec39-4de6-a11a-e1e0cef0d2b5"), "Hazard", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("9d59e14a-c17d-45ff-b2a9-3fe783b86f76"), "VanHoof", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("3faa3b48-40f4-4c82-9acf-cab9347c5d3a"), "Brokkenpap", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("0578ed5a-c17d-473f-bf0d-cc4bed869b0a"), "Debruyne", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("6cf6c9fd-07c6-4b52-8410-9ef7d1880f4a"), "Mertens", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("f1f54e7c-2cc1-4c9d-82f9-b68bf07758a5"), "Garnaal", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"), "Vissers", new Guid("082bbab5-7054-4e64-8de9-2619061e2b74"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("5c497e9c-34af-4e48-aa09-8fb77cb862d0"), "Zalinski", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("7b4abb71-98da-4104-b63f-c008961ce82f"), "Beukelaer", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("f7d1bc37-9af3-4af2-a0a0-ab2b845f2c60"), "Donckerwolcke", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"), "Jansma", new Guid("cd56a08f-f26a-48a9-b4b0-4c909b4c024f"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("94ebed51-6c44-4b24-96ef-e179a05d9c8b"), "Bambino", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("d90e41f1-86e3-4d77-a770-42f79ebfb06b"), "Scarlet", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("2e227195-99cf-4402-8121-be4bcb7e3ce4"), "Camara", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d"), "Depardieu", new Guid("b4e99adc-49fe-43c4-a06f-154383e04aeb"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("caeb9ece-702e-4d38-9720-34e351811477"), "Franckaert", new Guid("d71d2eb2-5371-47db-9f74-845ce50afb35"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("caeb9ece-702e-4d38-9720-34e351811477") },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") },
                    { new Guid("1ba44f9c-12e7-4cde-9137-5383a305b6a5"), new Guid("b762245b-16cb-4d35-be62-94de4e68aea4") },
                    { new Guid("e2fa9283-d60f-4b88-85c3-bc5977cf498f"), new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d") },
                    { new Guid("761bbf5c-dc81-4259-a998-ecf6b7c1a4e4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") },
                    { new Guid("3f1a3581-5727-4ed7-ab83-49131c194ff4"), new Guid("95e011d3-bbf8-42a9-b191-57efd8cd6c4d") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("f59b3acd-5a4c-4c7a-bc11-f90d3185ab6a"), "Merckx", new Guid("caeb9ece-702e-4d38-9720-34e351811477"), "Oranje zadel" },
                    { new Guid("035e420b-da9b-47fd-b284-63721cfec6bd"), "B-Twin", new Guid("b762245b-16cb-4d35-be62-94de4e68aea4"), "Zwart zadel" },
                    { new Guid("5944cd1a-1b61-43c9-a437-1dba6bdd72ab"), "Moldava", new Guid("f31f89c4-90ea-48cb-96f2-d2e5dbf5bd3d"), "Geel zadel" }
                });
        }
    }
}
