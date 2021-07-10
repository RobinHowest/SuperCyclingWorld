using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class AddMoreSeedFanRegistratie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), new Guid("f73fac46-1d34-42db-8c25-30a4b564241a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("bfaeafaa-89e5-4561-add2-3eb55bb11078"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d1fafbab-50a8-492b-9fa0-552c2d7b8ffe"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("de12a019-0bab-4f11-b430-b2278c18b9d3"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("51dc42b2-26cf-4ce7-82d1-fb2f6b234cb8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("28e28b97-4881-446b-86ac-1075708d2467"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), null, "WTC" },
                    { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), null, "DCTV" },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), null, "De lustige rijders" },
                    { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), null, "WTC Melsele" },
                    { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), null, "The master cyclists" }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") },
                    { new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), new Guid("28e28b97-4881-446b-86ac-1075708d2467") },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") },
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d31a367c-0a8b-4831-9613-30a6bc6dd2fb") },
                    { new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") },
                    { new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), new Guid("d97d020f-114f-4892-9555-a14de0bc5a0e") },
                    { new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") },
                    { new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"), "Franckaert", new Guid("b6f66765-ca41-41e1-99cd-cd164ddb6e9b"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Robin" },
                    { new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"), "Jansma", new Guid("703084c6-44c7-44a2-8a3a-3ed585171d75"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Johanna" },
                    { new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"), "Vissers", new Guid("f28f61a2-a7fa-4ff3-82a2-247af348a0f4"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0"), "Depardieu", new Guid("1c35a2e0-a1c0-4c6e-94ef-4c37c33422e9"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Gerard" },
                    { new Guid("51dc42b2-26cf-4ce7-82d1-fb2f6b234cb8"), "Van Overmeire", new Guid("3ccece87-cfce-4ab5-86e9-b038aae4df80"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marc" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("28e28b97-4881-446b-86ac-1075708d2467"), new Guid("f73fac46-1d34-42db-8c25-30a4b564241a") },
                    { new Guid("8a8cc9a5-0443-47ee-bc49-41652659e896"), new Guid("a0fe90c5-fac6-477c-9d10-d1d30c1139b0") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("bfaeafaa-89e5-4561-add2-3eb55bb11078"), "Merckx", new Guid("1aa2812b-b898-4136-9154-0ac4630afd81"), "Oranje zadel" },
                    { new Guid("d1fafbab-50a8-492b-9fa0-552c2d7b8ffe"), "B-Twin", new Guid("f73fac46-1d34-42db-8c25-30a4b564241a"), "Zwart zadel" },
                    { new Guid("de12a019-0bab-4f11-b430-b2278c18b9d3"), "Moldava", new Guid("2c34e09c-a4a0-4294-b8dc-35a28bbadee8"), "Geel zadel" }
                });
        }
    }
}
