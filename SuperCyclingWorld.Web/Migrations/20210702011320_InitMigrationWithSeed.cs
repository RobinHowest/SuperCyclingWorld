using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class InitMigrationWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Clubnaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supporters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supporters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wielrenners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    ClubId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wielrenners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wielrenners_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubSupporter",
                columns: table => new
                {
                    ClubId = table.Column<Guid>(nullable: false),
                    SupporterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubSupporter", x => new { x.ClubId, x.SupporterId });
                    table.ForeignKey(
                        name: "FK_ClubSupporter_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubSupporter_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanRegistratie",
                columns: table => new
                {
                    WielrennerId = table.Column<Guid>(nullable: false),
                    SupporterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanRegistratie", x => new { x.SupporterId, x.WielrennerId });
                    table.ForeignKey(
                        name: "FK_FanRegistratie_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FanRegistratie_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fietsen",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Zadel = table.Column<string>(nullable: true),
                    Merk = table.Column<string>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fietsen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fietsen_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), "WTC" },
                    { new Guid("79c660e4-8667-4e60-abe3-286d5f49007f"), "DCTV" },
                    { new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), "De lustige rijders" },
                    { new Guid("7268ce67-24f3-403a-9179-ffee1adca253"), "WTC Melsele" },
                    { new Guid("6434fc64-6499-461b-ab4e-cbefaeafa087"), "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("61d87552-0514-4612-b64d-f783da4b26b3"), "The Pooh", "Winnie" },
                    { new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0"), "Van Achtmaal", "Thomas" },
                    { new Guid("3633e9cb-8bf7-4324-8500-fe0a67516e28"), "VanKerkhove", "Nico" },
                    { new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"), "Kronenburg", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), new Guid("61d87552-0514-4612-b64d-f783da4b26b3") },
                    { new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), new Guid("01dd0181-d64f-4073-b0a6-eae101e296c0") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ff336620-9855-4e74-93d7-a2bf92296596"), "Franckaert", new Guid("abe765b3-8623-40ef-8e35-86d372a23698"), "Robin" },
                    { new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4"), "Jansma", new Guid("79c660e4-8667-4e60-abe3-286d5f49007f"), "Johanna" },
                    { new Guid("10df0c5f-b9ee-43d4-aacb-b924e8269378"), "Vissers", new Guid("c312c3a9-bd2c-4a98-8167-d9100e17bce7"), "Bert" },
                    { new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865"), "Depardieu", new Guid("7268ce67-24f3-403a-9179-ffee1adca253"), "Gerard" },
                    { new Guid("de154ae1-d8c0-4412-baf9-4fa9a0298c87"), "Van Overmeire", new Guid("6434fc64-6499-461b-ab4e-cbefaeafa087"), "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("61d87552-0514-4612-b64d-f783da4b26b3"), new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4") },
                    { new Guid("39adae42-a02c-48bd-ac20-b23d123adab7"), new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("042c040e-e93b-4a41-982f-80c30e59855f"), "Moldava", new Guid("ff336620-9855-4e74-93d7-a2bf92296596"), "Geel zadel" },
                    { new Guid("40ddb9ad-c0ef-4183-9d84-0c7b67d042e9"), "Merckx", new Guid("b261748b-01f4-4a7c-bc89-bdbdbb6173d4"), "Oranje zadel" },
                    { new Guid("f27c456f-c649-470f-a4f3-513b046f6a17"), "B-Twin", new Guid("8496ffd1-d49e-4251-8bd8-912b71f3e865"), "Zwart zadel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubSupporter_SupporterId",
                table: "ClubSupporter",
                column: "SupporterId");

            migrationBuilder.CreateIndex(
                name: "IX_FanRegistratie_WielrennerId",
                table: "FanRegistratie",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fietsen_WielrennerId",
                table: "Fietsen",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wielrenners_ClubId",
                table: "Wielrenners",
                column: "ClubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubSupporter");

            migrationBuilder.DropTable(
                name: "FanRegistratie");

            migrationBuilder.DropTable(
                name: "Fietsen");

            migrationBuilder.DropTable(
                name: "Supporters");

            migrationBuilder.DropTable(
                name: "Wielrenners");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
