using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddClubleiderToClub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("02a92b6a-1edf-452b-85a4-86dcf7a5ff25"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("534866bb-e264-426c-ae5f-7f414f219cf9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("bf6bcae6-bd56-47b7-b0eb-a1101371f91a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cde2037b-30e5-4396-9a63-53528101e775"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f78268ed-9d0e-43ce-9bd7-aaa92709f98d"));

            migrationBuilder.AddColumn<Guid>(
                name: "Clubleider",
                table: "Clubs",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("d15ea1e1-c72b-496a-be97-d0c8c64b9b01"), null, "WTC" },
                    { new Guid("a26f7abf-4866-4256-9a21-76331f169eb4"), null, "DCTV" },
                    { new Guid("043f31a7-f4b1-4f68-9910-790a292c5e53"), null, "De lustige rijders" },
                    { new Guid("38cf8948-05c4-4d4a-a7df-2b98f945d6e9"), null, "WTC Melsele" },
                    { new Guid("7af5048a-03b6-4666-8d0e-780b319bbba5"), null, "The master cyclists" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("043f31a7-f4b1-4f68-9910-790a292c5e53"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("38cf8948-05c4-4d4a-a7df-2b98f945d6e9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7af5048a-03b6-4666-8d0e-780b319bbba5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a26f7abf-4866-4256-9a21-76331f169eb4"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d15ea1e1-c72b-496a-be97-d0c8c64b9b01"));

            migrationBuilder.DropColumn(
                name: "Clubleider",
                table: "Clubs");

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("cde2037b-30e5-4396-9a63-53528101e775"), "WTC" },
                    { new Guid("02a92b6a-1edf-452b-85a4-86dcf7a5ff25"), "DCTV" },
                    { new Guid("534866bb-e264-426c-ae5f-7f414f219cf9"), "De lustige rijders" },
                    { new Guid("f78268ed-9d0e-43ce-9bd7-aaa92709f98d"), "WTC Melsele" },
                    { new Guid("bf6bcae6-bd56-47b7-b0eb-a1101371f91a"), "The master cyclists" }
                });
        }
    }
}
