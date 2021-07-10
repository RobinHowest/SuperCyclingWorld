using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class ExtraSeedWielrenners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("051c340d-0b62-4fed-a0c3-586c6f56ea4f"), new Guid("8669c852-8810-45fe-b95a-e0433c77da36") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), new Guid("8669c852-8810-45fe-b95a-e0433c77da36") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("8791dc62-40b5-46a8-9bc9-b859ccd91a7d"), new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("be341ed7-35c9-4743-bbb0-065a0ef9aede"), new Guid("ff197918-e32a-4af1-b845-807af2ea51f5") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("ff197918-e32a-4af1-b845-807af2ea51f5") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0"), new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8669c852-8810-45fe-b95a-e0433c77da36"), new Guid("2c8b6977-30c9-4fc0-bcc0-0c17edf8973a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8669c852-8810-45fe-b95a-e0433c77da36"), new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63"), new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"), new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"), new Guid("dfe3d9a6-6177-48d0-b398-22a62fe67d91") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("599b0492-9985-4365-af08-6e0f414c2920"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("df503b3b-f842-4535-8f01-9278a5a5aa55"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("e0a12aea-e55e-4e96-960d-e26c7a1fe1c7"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cc64fabe-8a93-4d62-b067-48e4dcb8a940"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("051c340d-0b62-4fed-a0c3-586c6f56ea4f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8669c852-8810-45fe-b95a-e0433c77da36"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c8b6977-30c9-4fc0-bcc0-0c17edf8973a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("dfe3d9a6-6177-48d0-b398-22a62fe67d91"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("36f6d6db-8967-45c0-9969-fe8660735399"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("8791dc62-40b5-46a8-9bc9-b859ccd91a7d"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("be341ed7-35c9-4743-bbb0-065a0ef9aede"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), null, "WTC" },
                    { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), null, "DCTV" },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), null, "De lustige rijders" },
                    { new Guid("7696e666-3073-492d-902a-9331d25ff234"), null, "WTC Melsele" },
                    { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") },
                    { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") },
                    { new Guid("7696e666-3073-492d-902a-9331d25ff234"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") },
                    { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") },
                    { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("8e5d72fd-4702-4428-abd9-9c3f8bd7801a"), "Mega", new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Mindy" },
                    { new Guid("7e4d4b50-8389-4095-b3b9-45b33e5c5436"), "Van Overmeire", new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" },
                    { new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32"), "Depardieu", new Guid("7696e666-3073-492d-902a-9331d25ff234"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("9abb5cd6-71fc-4c7c-957d-7778e3b873ac"), "Garnaal", new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Sofie" },
                    { new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"), "Vissers", new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("847666a5-65c7-4e66-bbea-0d123adc5c9f"), "Donckerwolcke", new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"), "Jansma", new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("43648603-9ab6-4308-a3ef-6cd796e8fabe"), "Camara", new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Herdy" },
                    { new Guid("b413ba62-936b-4863-8685-562a6cd78038"), "Brokkenpap", new Guid("7696e666-3073-492d-902a-9331d25ff234"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Berend" },
                    { new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"), "Franckaert", new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff") },
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") },
                    { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") },
                    { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134") },
                    { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") },
                    { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("d2481d9a-9ba0-423d-b5ab-bbbde01714d0"), "Merckx", new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"), "Oranje zadel" },
                    { new Guid("34efc7f6-d14c-408a-b2ee-8ffba40f5434"), "B-Twin", new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"), "Zwart zadel" },
                    { new Guid("26b3155a-4f02-465d-88f1-4d89a39c50f9"), "Moldava", new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("7696e666-3073-492d-902a-9331d25ff234"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"), new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"), new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"), new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"), new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"), new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("26b3155a-4f02-465d-88f1-4d89a39c50f9"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("34efc7f6-d14c-408a-b2ee-8ffba40f5434"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d2481d9a-9ba0-423d-b5ab-bbbde01714d0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("43648603-9ab6-4308-a3ef-6cd796e8fabe"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7e4d4b50-8389-4095-b3b9-45b33e5c5436"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("847666a5-65c7-4e66-bbea-0d123adc5c9f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8e5d72fd-4702-4428-abd9-9c3f8bd7801a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9abb5cd6-71fc-4c7c-957d-7778e3b873ac"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b413ba62-936b-4863-8685-562a6cd78038"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("cabaf72e-c69e-456b-8da9-d2c9aac86ff0"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("611bcd8b-4bdb-4205-a46c-c1c46ab3432b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("94f3968d-0d2c-478d-9aae-4ae088b1da48"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a2a3ddb8-a813-4e2d-99b8-1a445f0dc7b8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("fe22ed0c-074a-439d-99dc-e23522d413ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4afd4726-fe31-4826-8bc5-83d7d86bb979"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6b4a60a0-a802-442a-bfc8-3cd4ddb6ac32"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7de9d56a-5331-466e-a465-e3e7d5a3e5ff"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a2c030e3-0a05-4038-9aca-56889e4d0134"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("568c3c3a-7c30-454f-9adf-9ab8992e1a24"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("7696e666-3073-492d-902a-9331d25ff234"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("93664e7a-b3d7-4f51-bcc7-5ea2b622173f"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b5477436-f388-4aea-9ade-b01b3875eaeb"));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "Clubleider", "Clubnaam" },
                values: new object[,]
                {
                    { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), null, "WTC" },
                    { new Guid("8791dc62-40b5-46a8-9bc9-b859ccd91a7d"), null, "DCTV" },
                    { new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), null, "De lustige rijders" },
                    { new Guid("be341ed7-35c9-4743-bbb0-065a0ef9aede"), null, "WTC Melsele" },
                    { new Guid("051c340d-0b62-4fed-a0c3-586c6f56ea4f"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("8669c852-8810-45fe-b95a-e0433c77da36"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("ff197918-e32a-4af1-b845-807af2ea51f5") },
                    { new Guid("be341ed7-35c9-4743-bbb0-065a0ef9aede"), new Guid("ff197918-e32a-4af1-b845-807af2ea51f5") },
                    { new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0") },
                    { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0") },
                    { new Guid("8791dc62-40b5-46a8-9bc9-b859ccd91a7d"), new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63") },
                    { new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63") },
                    { new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), new Guid("8669c852-8810-45fe-b95a-e0433c77da36") },
                    { new Guid("051c340d-0b62-4fed-a0c3-586c6f56ea4f"), new Guid("8669c852-8810-45fe-b95a-e0433c77da36") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("2c8b6977-30c9-4fc0-bcc0-0c17edf8973a"), "Franckaert", new Guid("d8221b19-986d-4b51-9b2b-dfbf98f3675f"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec"), "Jansma", new Guid("8791dc62-40b5-46a8-9bc9-b859ccd91a7d"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("dfe3d9a6-6177-48d0-b398-22a62fe67d91"), "Vissers", new Guid("36f6d6db-8967-45c0-9969-fe8660735399"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576"), "Depardieu", new Guid("be341ed7-35c9-4743-bbb0-065a0ef9aede"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("cc64fabe-8a93-4d62-b067-48e4dcb8a940"), "Van Overmeire", new Guid("051c340d-0b62-4fed-a0c3-586c6f56ea4f"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("8669c852-8810-45fe-b95a-e0433c77da36"), new Guid("2c8b6977-30c9-4fc0-bcc0-0c17edf8973a") },
                    { new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"), new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec") },
                    { new Guid("6d73509e-6c41-4586-bc2a-c62ab3a91fe0"), new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec") },
                    { new Guid("ff197918-e32a-4af1-b845-807af2ea51f5"), new Guid("dfe3d9a6-6177-48d0-b398-22a62fe67d91") },
                    { new Guid("8669c852-8810-45fe-b95a-e0433c77da36"), new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576") },
                    { new Guid("b9d31529-ba6f-43ac-aac8-443229d2ae63"), new Guid("99cd747f-41ca-4ea0-852b-778c6be1d576") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("e0a12aea-e55e-4e96-960d-e26c7a1fe1c7"), "Merckx", new Guid("2c8b6977-30c9-4fc0-bcc0-0c17edf8973a"), "Oranje zadel" },
                    { new Guid("599b0492-9985-4365-af08-6e0f414c2920"), "B-Twin", new Guid("59d02212-23d0-4247-b1e3-cdf8fe37bcec"), "Zwart zadel" },
                    { new Guid("df503b3b-f842-4535-8f01-9278a5a5aa55"), "Moldava", new Guid("dfe3d9a6-6177-48d0-b398-22a62fe67d91"), "Geel zadel" }
                });
        }
    }
}
