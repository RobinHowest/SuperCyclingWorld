using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class TryToChangeDateTimeDataTypeInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("0c9e7b9c-f643-40d6-8426-ba23db9b4d9d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("50eb5d04-f085-4424-b5e6-33a5657c047c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("58832045-9372-4dd9-aa15-46973fdda82b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a682ab81-8b73-4346-a29c-293f9b62cf9a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("c4c94bff-c634-4174-9e78-2a3ed2b6a8e2"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("a682ab81-8b73-4346-a29c-293f9b62cf9a"), "WTC" },
                    { new Guid("0c9e7b9c-f643-40d6-8426-ba23db9b4d9d"), "DCTV" },
                    { new Guid("58832045-9372-4dd9-aa15-46973fdda82b"), "De lustige rijders" },
                    { new Guid("c4c94bff-c634-4174-9e78-2a3ed2b6a8e2"), "WTC Melsele" },
                    { new Guid("50eb5d04-f085-4424-b5e6-33a5657c047c"), "The master cyclists" }
                });
        }
    }
}
