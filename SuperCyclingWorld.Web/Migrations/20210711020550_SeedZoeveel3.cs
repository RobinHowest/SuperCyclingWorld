using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class SeedZoeveel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("1c8eed52-ebc4-4141-a590-6323ceefb266"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("5c3475e3-55b8-49d5-b5fd-79d4589466ea"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("82f91289-258b-4dea-b041-49be98252f0d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("09ba45f6-741d-4496-81aa-4a32c47cff28"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("46fa8116-d0d4-46e5-a9cf-b75239dc144c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4cbfef3b-c60e-405d-8356-d34f9c95f40b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("54a63cb2-4938-473a-9a60-35f08acd10bc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("5cb20494-25c6-4179-af48-ce8b6997224b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6aa5e12e-c657-480f-a50d-dd4ca9af1273"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8f571ad6-b43e-4b7c-82f6-98ee02c967d4"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("05e4f932-16c4-4ef7-8d51-ea3d90a6d11a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("160c6efd-3b9d-4f84-94f2-9dad9dec4433"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1b4f7524-0704-4e5b-8bc5-b08923577258"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3ad145aa-a2be-4539-ba6c-695ab6a987b8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5c75f356-7c30-4532-afed-c1b4f46bf0cb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5cacc0e0-033c-499c-be70-bce6319bf057"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5dc84776-c3aa-49b3-9e2d-d5a7fdebdd16"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6989fe60-e616-4d67-96de-1bb65409b422"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6dc0f0ff-efc5-4e22-83c7-1f2273d1eb60"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("852e4e89-93f1-4a18-86d3-3200ebef635f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9f131089-91cc-4b41-9445-3bd7d7224d48"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a5434e89-36c8-4a81-a6fe-098626fe7e07"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a5d5c07d-b862-401c-b29e-8d5a096e53a9"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ce358bbf-7c07-4d63-b7f6-686e7cf80325"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ce776019-6454-45c0-9d9c-8f428ab6c263"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d65ef2bc-6022-4c22-b35c-ec39cacf14e2"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("410e49d8-5056-4236-af1c-718fc70c1699"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), 0, null, "WTC", 2001 },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), 0, null, "DCTV", 2016 },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1676ba06-42a3-4400-9c8f-806449308a17"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("9ae17db2-861e-4c0d-8e18-12c57571ab57"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("a988280a-8c13-4d59-9253-264046ed9a60"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("acee2067-e053-4e0c-8011-948c6416ca6a"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("1a8dc8db-dd3f-4c62-b99d-53bcdaeb818e"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("bad97b6c-a0d5-4835-bce2-32ee66ecb7f2"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("25ae9c9d-ef8e-4128-b4da-2d60d39c9d20"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("b20212a3-b556-4a4f-bb70-dfb8872ad84e"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558") },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") },
                    { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") },
                    { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("865a7e8a-ec7f-43d0-8080-843c9d9a926f"), "Hazard", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("874d1982-bf82-4fff-9974-c8517d108ee7"), "VanHoof", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("d48d3567-24c6-4f56-a593-fa197ff73e2c"), "Mega", new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("b406f30e-69fe-45a5-b2a9-5a97f2e3fd6a"), "Debruyne", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("1c9d63a4-57de-4871-816b-194d32806ccf"), "Depardieu", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), "Vissers", new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("72dd0c7c-335c-4f99-8ce0-0f5ea95eb148"), "Bambino", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("6b187433-eff0-4e90-b0d7-5c6c36e7d542"), "Beukelaer", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("f0f1650f-0e01-48e3-9e9d-d08943487ea5"), "Scarlet", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("603ab875-5194-4110-b55e-2ab0d6333771"), "Garnaal", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("346a7c39-79be-4a02-814e-fce9f8a78bd7"), "Van Overmeire", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("10104c9b-c5a8-429c-9ab3-614ba900fb9c"), "Zalinski", new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("07768fe0-aef0-4641-9cfd-adf53ea5eb3b"), "Brokkenpap", new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("ca39562d-fb33-4e47-9468-d52b3784391d"), "Vanderplas", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("ef44c545-2da0-4b20-99ef-3423b5924713"), "Mertens", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("ec5193a6-5975-4909-92f7-76dd0524a10a"), "Donckerwolcke", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("04a1b5ff-2ac8-4ea8-846d-0aee440091f6"), "Camara", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), "Jansma", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("a48e6bd3-b87b-4fda-940b-cb4c85464be6"), "Evenepoel", new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), "Franckaert", new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219") },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                    { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") },
                    { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc") },
                    { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") },
                    { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("3bd9e414-f548-4b6f-b3ab-06a163b3425d"), "Merckx", new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"), "Oranje zadel" },
                    { new Guid("1e9c518a-3587-4f0d-a455-7eec7dd553c3"), "B-Twin", new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"), "Zwart zadel" },
                    { new Guid("e48cecb7-0381-462d-b311-70c31585b088"), "Moldava", new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"), new Guid("6ed294d1-5815-458f-b806-303d1d9d814d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"), new Guid("68694416-8004-4879-88f8-95f25bbdc025") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("1c9d63a4-57de-4871-816b-194d32806ccf") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"), new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("68694416-8004-4879-88f8-95f25bbdc025"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"), new Guid("a54302b3-a9f1-4b38-bb95-94459539f808") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("1e9c518a-3587-4f0d-a455-7eec7dd553c3"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("3bd9e414-f548-4b6f-b3ab-06a163b3425d"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e48cecb7-0381-462d-b311-70c31585b088"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1676ba06-42a3-4400-9c8f-806449308a17"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("1a8dc8db-dd3f-4c62-b99d-53bcdaeb818e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25ae9c9d-ef8e-4128-b4da-2d60d39c9d20"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9ae17db2-861e-4c0d-8e18-12c57571ab57"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a988280a-8c13-4d59-9253-264046ed9a60"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("acee2067-e053-4e0c-8011-948c6416ca6a"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b20212a3-b556-4a4f-bb70-dfb8872ad84e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("bad97b6c-a0d5-4835-bce2-32ee66ecb7f2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("04a1b5ff-2ac8-4ea8-846d-0aee440091f6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("07768fe0-aef0-4641-9cfd-adf53ea5eb3b"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("10104c9b-c5a8-429c-9ab3-614ba900fb9c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("346a7c39-79be-4a02-814e-fce9f8a78bd7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("603ab875-5194-4110-b55e-2ab0d6333771"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b187433-eff0-4e90-b0d7-5c6c36e7d542"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("72dd0c7c-335c-4f99-8ce0-0f5ea95eb148"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("865a7e8a-ec7f-43d0-8080-843c9d9a926f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("874d1982-bf82-4fff-9974-c8517d108ee7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a48e6bd3-b87b-4fda-940b-cb4c85464be6"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b406f30e-69fe-45a5-b2a9-5a97f2e3fd6a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ca39562d-fb33-4e47-9468-d52b3784391d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d48d3567-24c6-4f56-a593-fa197ff73e2c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ec5193a6-5975-4909-92f7-76dd0524a10a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef44c545-2da0-4b20-99ef-3423b5924713"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f0f1650f-0e01-48e3-9e9d-d08943487ea5"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1bc4b9b4-203a-4303-967b-19df1b83006c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("390d1708-c7f2-4d24-a996-2ada78ecc6ce"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("50a98a13-6d0c-46d1-96d6-0b15a4ac44d0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("41124f26-6d6e-4190-8c9a-2d20e91bccb4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("46260f1c-c87b-49ac-ba0b-e82e76766558"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("68694416-8004-4879-88f8-95f25bbdc025"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6ed294d1-5815-458f-b806-303d1d9d814d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1c9d63a4-57de-4871-816b-194d32806ccf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("3c32fe3a-2c0e-446f-8b4f-77c202ba28fc"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8890c50a-f32e-41a7-aa8e-be9ff5110219"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a54302b3-a9f1-4b38-bb95-94459539f808"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8612fe5c-8212-49d0-9680-b6163b4ce5f8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d3768baf-737f-464d-a287-9c2efb60fcef"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), 0, null, "WTC", 2001 },
                    { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), 0, null, "DCTV", 2016 },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8f571ad6-b43e-4b7c-82f6-98ee02c967d4"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("09ba45f6-741d-4496-81aa-4a32c47cff28"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("6aa5e12e-c657-480f-a50d-dd4ca9af1273"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("4cbfef3b-c60e-405d-8356-d34f9c95f40b"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("54a63cb2-4938-473a-9a60-35f08acd10bc"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("5cb20494-25c6-4179-af48-ce8b6997224b"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("46fa8116-d0d4-46e5-a9cf-b75239dc144c"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("d3717119-7ae3-4c96-91dd-5ea31ecb4065") },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), new Guid("8220dc7f-8c06-4155-87c3-917be1d09491") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), new Guid("410e49d8-5056-4236-af1c-718fc70c1699") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8") },
                    { new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("d65ef2bc-6022-4c22-b35c-ec39cacf14e2"), "Hazard", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("6dc0f0ff-efc5-4e22-83c7-1f2273d1eb60"), "Scarlet", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("1b4f7524-0704-4e5b-8bc5-b08923577258"), "Garnaal", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("9f131089-91cc-4b41-9445-3bd7d7224d48"), "Camara", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), "Vissers", new Guid("b9fee2c5-2411-449c-86f9-7b8fc5e884fb"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("ce358bbf-7c07-4d63-b7f6-686e7cf80325"), "Zalinski", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("ce776019-6454-45c0-9d9c-8f428ab6c263"), "Donckerwolcke", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8"), "Depardieu", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("5dc84776-c3aa-49b3-9e2d-d5a7fdebdd16"), "Mertens", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("5c75f356-7c30-4532-afed-c1b4f46bf0cb"), "Brokkenpap", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), "Franckaert", new Guid("eac93df6-36b1-49c5-a18e-d5db76ccbaa2"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("6989fe60-e616-4d67-96de-1bb65409b422"), "Evenepoel", new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("852e4e89-93f1-4a18-86d3-3200ebef635f"), "Vanderplas", new Guid("6dab1deb-5e89-4856-9338-dcef153dd980"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("160c6efd-3b9d-4f84-94f2-9dad9dec4433"), "Bambino", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("a5434e89-36c8-4a81-a6fe-098626fe7e07"), "VanHoof", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("a5d5c07d-b862-401c-b29e-8d5a096e53a9"), "Beukelaer", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("05e4f932-16c4-4ef7-8d51-ea3d90a6d11a"), "Mega", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("5cacc0e0-033c-499c-be70-bce6319bf057"), "Van Overmeire", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("3ad145aa-a2be-4539-ba6c-695ab6a987b8"), "Debruyne", new Guid("a1553f9c-629c-4d70-8ba1-93825f50fccc"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), "Jansma", new Guid("b4770de4-dbde-479c-93b8-e2474e3f6487"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                    { new Guid("410e49d8-5056-4236-af1c-718fc70c1699"), new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda") },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c") },
                    { new Guid("1f6da884-87e3-419c-8177-663b2beb4c5b"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") },
                    { new Guid("8220dc7f-8c06-4155-87c3-917be1d09491"), new Guid("49568ce0-1648-4ab7-97bc-9e1fd03cb3f8") },
                    { new Guid("468ec81f-4e81-4c74-a3e4-38009330f6f8"), new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("82f91289-258b-4dea-b041-49be98252f0d"), "B-Twin", new Guid("fb3f8ae3-877c-426c-8d60-a9d4c62c0dda"), "Zwart zadel" },
                    { new Guid("5c3475e3-55b8-49d5-b5fd-79d4589466ea"), "Merckx", new Guid("cb4a40ba-36c5-46a4-9e0c-a4b93a6f9e9c"), "Oranje zadel" },
                    { new Guid("1c8eed52-ebc4-4141-a590-6323ceefb266"), "Moldava", new Guid("55d939b2-4edc-43b0-a1cc-1e269038e092"), "Geel zadel" }
                });
        }
    }
}
