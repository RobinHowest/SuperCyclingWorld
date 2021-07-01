using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class InitMigrationWithSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Clubnaam = table.Column<string>(nullable: true),
                    SupporterId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wielrenners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    ClubId = table.Column<Guid>(nullable: true),
                    SupporterId = table.Column<Guid>(nullable: true),
                    WielrennerId = table.Column<Guid>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Wielrenners_Supporters_SupporterId",
                        column: x => x.SupporterId,
                        principalTable: "Supporters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wielrenners_Wielrenners_WielrennerId",
                        column: x => x.WielrennerId,
                        principalTable: "Wielrenners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "Clubnaam", "SupporterId" },
                values: new object[] { new Guid("f5aca5b9-ced7-4d06-8588-1c629c014e1f"), "WTC", null });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Voornaam" },
                values: new object[] { new Guid("85a7a708-f086-442e-bb65-35a616293177"), "Supporter", "1" });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "SupporterId", "Voornaam", "WielrennerId" },
                values: new object[] { new Guid("71097bc7-d5ac-4ec5-a6ab-a219aa668769"), "Franckaert", null, null, "Robin", null });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[] { new Guid("75df8319-a9f0-4b6a-a250-2ffcaebc9392"), "B-Twin", new Guid("71097bc7-d5ac-4ec5-a6ab-a219aa668769"), "Zwart zadel" });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SupporterId",
                table: "Clubs",
                column: "SupporterId");

            migrationBuilder.CreateIndex(
                name: "IX_Fietsen_WielrennerId",
                table: "Fietsen",
                column: "WielrennerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wielrenners_ClubId",
                table: "Wielrenners",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Wielrenners_SupporterId",
                table: "Wielrenners",
                column: "SupporterId");

            migrationBuilder.CreateIndex(
                name: "IX_Wielrenners_WielrennerId",
                table: "Wielrenners",
                column: "WielrennerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fietsen");

            migrationBuilder.DropTable(
                name: "Wielrenners");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Supporters");
        }
    }
}
