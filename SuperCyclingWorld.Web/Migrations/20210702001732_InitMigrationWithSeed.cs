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
                    ClubId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wielrenners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wielrenners_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    WielrennerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fietsen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fietsen_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[] { new Guid("244054d3-5270-4d89-84fa-7769c3678ff1"), "WTC" });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[] { new Guid("5c8aa204-656f-478a-bc6c-4ecdc248c852"), "B-Twin", null, "Zwart zadel" });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Voornaam" },
                values: new object[] { new Guid("8402a8d1-d547-474d-ba4c-d48bcedd7ddf"), "Supporter", "1" });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Voornaam" },
                values: new object[] { new Guid("dbde00f4-d56e-4bbc-b431-ca3219a0a59c"), "Franckaert", null, "Robin" });

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
