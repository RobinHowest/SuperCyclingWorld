using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class WielrennerRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Oprichtingsjaar",
                table: "Clubs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Record",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WielrennerRecords",
                columns: table => new
                {
                    WielrennerId = table.Column<Guid>(nullable: true),
                    WielrennersId = table.Column<Guid>(nullable: false),
                    RecordId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WielrennerRecords", x => new { x.RecordId, x.WielrennersId });
                    table.ForeignKey(
                        name: "FK_WielrennerRecords_Record_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WielrennerRecords_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), null, "WTC", 2001 },
                    { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), null, "DCTV", 2016 },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), null, "De lustige rijders", 1991 },
                    { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), null, "WTC Melsele", 1966 },
                    { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("097a08ed-4c10-4b5a-8257-90ff8c7442bb"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("429b606e-78b0-43e8-bed4-5c9360805eb2"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("13c6d9e6-db14-4424-8977-0f2fdbb2972b"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("0f1c2d6d-18ca-4cf5-8f1c-ab1008abb023"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("22515542-1fa1-4dd2-b5e0-8d13e0933f8c"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("cfdc0a9b-146c-431d-856c-6082756341d0"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("7e9bac83-be9e-4c80-ba30-a3b6a05b4238"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("1bea80c7-941c-444b-91af-eb9fd9f6262a"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") },
                    { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") },
                    { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") },
                    { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") },
                    { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("60ba045e-9c5c-4221-bba9-38ca1f1d4ab0"), "Debruyne", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Kevin" },
                    { new Guid("fafab49e-a3be-4ddd-b5d9-23b94017c4b8"), "VanHoof", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Emily" },
                    { new Guid("f7da1553-d0b5-4c68-ae5f-ff88b8f7213a"), "Scarlet", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanson" },
                    { new Guid("691c388c-aed4-4b21-a0bd-82da980fa6ff"), "Garnaal", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("973a8a73-ba2f-460a-85c8-dbb7dceb7cb5"), "Donckerwolcke", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429"), "Depardieu", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"), "Vissers", new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("d192323a-38af-44c3-b8dd-b7b84571ebc3"), "Evenepoel", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Remco" },
                    { new Guid("3b91dc4c-e965-4c60-a276-3eebb3b22aaf"), "Hazard", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Eden" },
                    { new Guid("343c422e-79d3-4cdf-83c2-1f9bdc06b2db"), "Bambino", new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Salvatore" },
                    { new Guid("c4448a46-dc96-4d59-a14a-fa4f178aefe1"), "Vanderplas", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sonja" },
                    { new Guid("32aa830f-acaa-448e-a31a-acf3b62bf2b2"), "Beukelaer", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koekjes" },
                    { new Guid("41bf269d-5cdd-4961-9c7a-cb10bed065b6"), "Mega", new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("72764d21-0f0c-49b0-9138-e0697b5305af"), "Zalinski", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Wosznjeck" },
                    { new Guid("c9c46416-1337-48fb-aeab-88ba6db2bb8c"), "Mertens", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Evelyne" },
                    { new Guid("3f840b58-310a-4584-a47b-6d967339280b"), "Brokkenpap", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("13bfbcb7-b5eb-429d-9dcc-bcd23f951847"), "Camara", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("d48a8bd2-e377-43eb-b843-54e8ee4bc3b7"), "Van Overmeire", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"), "Jansma", new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"), "Franckaert", new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2") },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") },
                    { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") },
                    { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5") },
                    { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") },
                    { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("922f07e7-5239-4626-a6d0-0df059231bfa"), "Merckx", new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"), "Oranje zadel" },
                    { new Guid("a8b0834e-5e9b-4804-8887-684ba4b5bef1"), "B-Twin", new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"), "Zwart zadel" },
                    { new Guid("99061927-f768-4d86-b5e1-b66d8a6dedb1"), "Moldava", new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"), "Geel zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WielrennerRecords_WielrennerId",
                table: "WielrennerRecords",
                column: "WielrennerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WielrennerRecords");

            migrationBuilder.DropTable(
                name: "Record");

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"), new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"), new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"), new Guid("c8e89702-d798-4a9d-b021-916f55088f9c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eb397a64-2044-46a5-b044-993e052dbe21"), new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"), new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"), new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("922f07e7-5239-4626-a6d0-0df059231bfa"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("99061927-f768-4d86-b5e1-b66d8a6dedb1"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("a8b0834e-5e9b-4804-8887-684ba4b5bef1"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("097a08ed-4c10-4b5a-8257-90ff8c7442bb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0f1c2d6d-18ca-4cf5-8f1c-ab1008abb023"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("13c6d9e6-db14-4424-8977-0f2fdbb2972b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1bea80c7-941c-444b-91af-eb9fd9f6262a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("22515542-1fa1-4dd2-b5e0-8d13e0933f8c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("429b606e-78b0-43e8-bed4-5c9360805eb2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("7e9bac83-be9e-4c80-ba30-a3b6a05b4238"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("cfdc0a9b-146c-431d-856c-6082756341d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("13bfbcb7-b5eb-429d-9dcc-bcd23f951847"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("32aa830f-acaa-448e-a31a-acf3b62bf2b2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("343c422e-79d3-4cdf-83c2-1f9bdc06b2db"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3b91dc4c-e965-4c60-a276-3eebb3b22aaf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3f840b58-310a-4584-a47b-6d967339280b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41bf269d-5cdd-4961-9c7a-cb10bed065b6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("60ba045e-9c5c-4221-bba9-38ca1f1d4ab0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("691c388c-aed4-4b21-a0bd-82da980fa6ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72764d21-0f0c-49b0-9138-e0697b5305af"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("973a8a73-ba2f-460a-85c8-dbb7dceb7cb5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c4448a46-dc96-4d59-a14a-fa4f178aefe1"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c9c46416-1337-48fb-aeab-88ba6db2bb8c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d192323a-38af-44c3-b8dd-b7b84571ebc3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d48a8bd2-e377-43eb-b843-54e8ee4bc3b7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f7da1553-d0b5-4c68-ae5f-ff88b8f7213a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fafab49e-a3be-4ddd-b5d9-23b94017c4b8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8318f2f2-cf36-46ff-ac34-57bf167dd9f7"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("97ed76cb-9f8e-4547-a293-0947533c6322"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("14f5678d-6304-4acd-aa8f-ae8b810f76ff"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b9c2dd2c-a44d-466c-bf0c-7118f96db0cd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c8e89702-d798-4a9d-b021-916f55088f9c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe015baa-02dc-4ce8-bc73-d3d833978b84"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0072bde4-324b-4bec-bd3d-11f8b3a8d429"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4eb535cf-f66d-4e1c-9eeb-944e49a14ca5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("891e1273-1fee-430e-b94b-9ebb9c2d5cb2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b8ae5f5c-52ff-4c89-a193-d3673aee30d2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6578a3ea-08b1-4049-8790-9a6bc38974bc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a0954cf7-796d-4bbc-9123-7fb9dde1ce13"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eb397a64-2044-46a5-b044-993e052dbe21"));

            migrationBuilder.DropColumn(
                name: "Oprichtingsjaar",
                table: "Clubs");

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
    }
}
