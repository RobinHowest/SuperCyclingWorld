using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperCyclingWorld.Web.Migrations
{
    public partial class replaceNullInAantalRecordsTableClubsTo0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("c6c0344d-9fce-44da-91de-7f7278f9eb4b"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("d588a55b-8024-4e60-a0da-c994c2f0d53e"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("f8162a50-8e22-48b6-b0ea-ffcef4274c28"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0676c2c1-995c-42a7-a0a3-970a60826be8"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3f916b16-54f7-4d6d-b484-507783da5853"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("45ed9e4c-0f85-4a36-84d4-ce790dc97084"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("97de10eb-c741-4956-9119-8d5ccd34e576"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("9a2745be-bd0b-4137-80dc-6a8c08ea7e6b"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a1bed1fd-37ee-4a66-bf6c-fef4a5ef92d6"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("c2776fd7-6e6f-4009-ad20-05595cd3a2f4"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("dd4a15e9-10c7-4423-8c46-cdb3f7a63dc0"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c51e230-8741-4e89-8e53-00b21dbce485"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2e19af0f-3289-4c8c-b7cb-5b14d086f043"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("41537fea-3945-4f3f-973f-71c193e15f7f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("448fa4bd-1980-4966-ac23-33b7d14cf71f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4c4195a5-e2a3-46e7-aa6d-1e5625946d0f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5d05e90c-eeb0-458c-9e24-ca5a8d7fd460"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("679bbd72-87e8-4fd3-90c4-553444ec0f11"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6cee4373-2ca7-4d67-80fe-14e61fa4f526"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("6df7252b-b702-4d9c-93c7-8fd34ff98dcf"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("92931377-a9c9-437c-8a24-11ad1dea5208"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("af34b235-9552-474f-b3ae-14195f68ed7d"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("b8f6b1d3-1793-46ad-b2da-4bedee397e7e"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("cb0b938e-a0d7-4626-96ef-a68d4ce34f1c"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d88b53ed-bc61-4ecf-97e5-cc3b919f310a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ef8e14df-2e22-4ef3-a729-396b054cbaaa"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("f90da381-77b3-4e97-a9df-25af2ae9a34a"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("4970a64d-32d6-49a1-9f79-18556310f440"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("82234998-22b7-4f4b-8108-d7dea256d508"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"));

            migrationBuilder.AlterColumn<int>(
                name: "AantalRecords",
                table: "Clubs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), 0, null, "WTC", 2001 },
                    { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), 0, null, "DCTV", 2016 },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), 0, null, "De lustige rijders", 1991 },
                    { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), 0, null, "WTC Melsele", 1966 },
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), 0, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("16297bba-af01-4512-89bf-e96382a7c16e"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("6d353a6c-4815-433f-b6f0-6d3e56b5dd79"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("e3192694-659d-4023-8d98-1ae0cff16581"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("78b4f8c5-b7ab-48a7-a221-78e300fdbde2"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("23e640f1-2fe4-472e-8769-cee566dd3f8f"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("588c4892-ef3d-4226-8407-8079ca405d0e"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("47d04e37-4de9-4a46-9869-ea460c47f8af"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("4933c2eb-350b-4217-b657-a7858f5b75bd"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") },
                    { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") },
                    { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") },
                    { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") },
                    { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") },
                    { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("4bece46d-cc32-4e45-8e39-c0c90773c603"), "Zalinski", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("bb9990a1-af16-447e-bc2f-d1592c98cca8"), "VanHoof", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("5930de5d-cac0-4ac6-8ffb-40d712e63c64"), "Beukelaer", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("ed75c951-dbbd-4bbc-8240-760d2e9a399c"), "Mega", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("e9b5a5c2-5355-4ae9-a33c-d51359e6d87f"), "Camara", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" },
                    { new Guid("c53539b6-7052-43fc-9904-43dec517109f"), "Depardieu", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("e0d3c513-ab26-4a0e-9b4c-41d11e462ffb"), "Evenepoel", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("495ead54-0b1c-4c9a-a331-40c55546743a"), "Hazard", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("7f288331-e21d-46f4-849e-7a03ce997007"), "Bambino", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("177ce8bf-7a85-4acc-9b1e-71f970777ef5"), "Vanderplas", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"), "Franckaert", new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("4fe826ae-d931-4b35-9874-f4f7040d91a2"), "Brokkenpap", new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("9d1f45fc-090e-4317-9cb0-14d89d1ecf07"), "Debruyne", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("a97df5a7-6d20-414f-8432-2a47fcf2a61f"), "Scarlet", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("853223ee-ed78-4337-aa76-708402e63b47"), "Garnaal", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("59a36da6-8d4f-4402-a664-2c18626aeba2"), "Donckerwolcke", new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("7337c55a-159e-4a9c-ab86-c2a0af7fe188"), "Mertens", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("0c03c760-4f46-47f8-a68f-c44ca3bb4033"), "Van Overmeire", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"), "Vissers", new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"), "Jansma", new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") },
                    { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2") },
                    { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536") },
                    { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") },
                    { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("69e138a1-cda0-46c4-bd3b-7e9cd3bfc3d7"), "B-Twin", new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"), "Zwart zadel" },
                    { new Guid("267aa54d-642d-4ee0-a0de-0ce2432da23f"), "Merckx", new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"), "Oranje zadel" },
                    { new Guid("70f9c5ed-ca91-4613-819d-3582c8f44d59"), "Moldava", new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"), "Geel zadel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"), new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"), new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc") });

            migrationBuilder.DeleteData(
                table: "ClubSupporter",
                keyColumns: new[] { "ClubId", "SupporterId" },
                keyValues: new object[] { new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"), new Guid("25c8bafa-3c6b-4a42-a310-53708001f391") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"), new Guid("d58663c5-480d-4972-a1c7-41279b5629b8") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2") });

            migrationBuilder.DeleteData(
                table: "FanRegistratie",
                keyColumns: new[] { "SupporterId", "WielrennerId" },
                keyValues: new object[] { new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"), new Guid("c53539b6-7052-43fc-9904-43dec517109f") });

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("267aa54d-642d-4ee0-a0de-0ce2432da23f"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("69e138a1-cda0-46c4-bd3b-7e9cd3bfc3d7"));

            migrationBuilder.DeleteData(
                table: "Fietsen",
                keyColumn: "Id",
                keyValue: new Guid("70f9c5ed-ca91-4613-819d-3582c8f44d59"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("16297bba-af01-4512-89bf-e96382a7c16e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("23e640f1-2fe4-472e-8769-cee566dd3f8f"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("47d04e37-4de9-4a46-9869-ea460c47f8af"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("4933c2eb-350b-4217-b657-a7858f5b75bd"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("588c4892-ef3d-4226-8407-8079ca405d0e"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("6d353a6c-4815-433f-b6f0-6d3e56b5dd79"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("78b4f8c5-b7ab-48a7-a221-78e300fdbde2"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("e3192694-659d-4023-8d98-1ae0cff16581"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("0c03c760-4f46-47f8-a68f-c44ca3bb4033"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("177ce8bf-7a85-4acc-9b1e-71f970777ef5"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("495ead54-0b1c-4c9a-a331-40c55546743a"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4bece46d-cc32-4e45-8e39-c0c90773c603"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("4fe826ae-d931-4b35-9874-f4f7040d91a2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("5930de5d-cac0-4ac6-8ffb-40d712e63c64"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("59a36da6-8d4f-4402-a664-2c18626aeba2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7337c55a-159e-4a9c-ab86-c2a0af7fe188"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("7f288331-e21d-46f4-849e-7a03ce997007"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("853223ee-ed78-4337-aa76-708402e63b47"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("9d1f45fc-090e-4317-9cb0-14d89d1ecf07"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("a97df5a7-6d20-414f-8432-2a47fcf2a61f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("bb9990a1-af16-447e-bc2f-d1592c98cca8"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e0d3c513-ab26-4a0e-9b4c-41d11e462ffb"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("e9b5a5c2-5355-4ae9-a33c-d51359e6d87f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("ed75c951-dbbd-4bbc-8240-760d2e9a399c"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("a99471fe-df5a-4741-bf8a-25001d32f736"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("ecb91ae6-e1b7-4941-a777-94ce6cc92589"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("0a28b4cd-9901-4809-a25c-5f11415cd72d"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("25c8bafa-3c6b-4a42-a310-53708001f391"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("81476747-22ef-4ad1-8b20-4726f53b69dc"));

            migrationBuilder.DeleteData(
                table: "Supporters",
                keyColumn: "Id",
                keyValue: new Guid("f4b9e0f7-44ba-4071-93c9-06e9abcfa32f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("2ab491cd-9677-46c2-be8a-5d9b151d4536"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("8a649fc6-2c9d-48c3-99d2-01285de1b5e2"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("c53539b6-7052-43fc-9904-43dec517109f"));

            migrationBuilder.DeleteData(
                table: "Wielrenners",
                keyColumn: "Id",
                keyValue: new Guid("d58663c5-480d-4972-a1c7-41279b5629b8"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("2fdac0a6-c7a2-4330-951e-7f94e9bf3192"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("9dd4aee6-bd28-435b-bfd8-3fa00bfacf8e"));

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "Id",
                keyValue: new Guid("e9a29e5f-c3de-4bd1-96b4-712c99d71606"));

            migrationBuilder.AlterColumn<int>(
                name: "AantalRecords",
                table: "Clubs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "AantalRecords", "Clubleider", "Clubnaam", "Oprichtingsjaar" },
                values: new object[,]
                {
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), null, null, "WTC", 2001 },
                    { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), null, null, "DCTV", 2016 },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), null, null, "De lustige rijders", 1991 },
                    { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), null, null, "WTC Melsele", 1966 },
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), null, null, "The master cyclists", 2011 }
                });

            migrationBuilder.InsertData(
                table: "Supporters",
                columns: new[] { "Id", "Achternaam", "Email", "GeboorteDatum", "Paswoord", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("97de10eb-c741-4956-9119-8d5ccd34e576"), "Clooney", "Clooney@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "George" },
                    { new Guid("3f916b16-54f7-4d6d-b484-507783da5853"), "Monroe", "Monroe@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Marlyn" },
                    { new Guid("c2776fd7-6e6f-4009-ad20-05595cd3a2f4"), "AppelGate", "Appelgate@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Christina" },
                    { new Guid("9a2745be-bd0b-4137-80dc-6a8c08ea7e6b"), "Opdorp", "Opdorp@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Alfons" },
                    { new Guid("a1bed1fd-37ee-4a66-bf6c-fef4a5ef92d6"), "Wezemaal", "Wezemaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Bert" },
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), "Kronenburg", "Kronenburg@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Koen" },
                    { new Guid("0676c2c1-995c-42a7-a0a3-970a60826be8"), "Peeters", "Peeters@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Jan" },
                    { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), "VanKerkhove", "VanKerkhove@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Nico" },
                    { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), "Van Achtmaal", "VanAchtmaal@live.be", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Thomas" },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), "The Pooh", "ThePooh@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Winnie" },
                    { new Guid("dd4a15e9-10c7-4423-8c46-cdb3f7a63dc0"), "Van Kruisem", "VanKruisem@live.be", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Willy" },
                    { new Guid("45ed9e4c-0f85-4a36-84d4-ce790dc97084"), "Reyns", "Reyns@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", "Rita" }
                });

            migrationBuilder.InsertData(
                table: "ClubSupporter",
                columns: new[] { "ClubId", "SupporterId" },
                values: new object[,]
                {
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") },
                    { new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), new Guid("82234998-22b7-4f4b-8108-d7dea256d508") },
                    { new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("6f9c152a-7369-4261-89f9-4eb53856888c") },
                    { new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") },
                    { new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969") },
                    { new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708") }
                });

            migrationBuilder.InsertData(
                table: "Wielrenners",
                columns: new[] { "Id", "Achternaam", "ClubId", "Email", "GeboorteDatum", "Paswoord", "TotaalAantalGeredenKilometers", "Voornaam" },
                values: new object[,]
                {
                    { new Guid("2e19af0f-3289-4c8c-b7cb-5b14d086f043"), "Debruyne", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Debruyne@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 450, "Kevin" },
                    { new Guid("4c4195a5-e2a3-46e7-aa6d-1e5625946d0f"), "Garnaal", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Garnaal@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 250, "Sofie" },
                    { new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"), "Vissers", new Guid("3f6a34ad-ceac-474d-9f97-4a39c2861326"), "Vissers@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 301, "Bert" },
                    { new Guid("0c51e230-8741-4e89-8e53-00b21dbce485"), "Zalinski", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Zalinski@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 233, "Wosznjeck" },
                    { new Guid("f90da381-77b3-4e97-a9df-25af2ae9a34a"), "Vanderplas", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Vanderplas@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 59, "Sonja" },
                    { new Guid("41537fea-3945-4f3f-973f-71c193e15f7f"), "VanHoof", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Vanhoof@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 306, "Emily" },
                    { new Guid("ef8e14df-2e22-4ef3-a729-396b054cbaaa"), "Beukelaer", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Beukelaer@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1250, "Koekjes" },
                    { new Guid("6df7252b-b702-4d9c-93c7-8fd34ff98dcf"), "Donckerwolcke", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Donckerwolcke@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 1100, "Thomas" },
                    { new Guid("6cee4373-2ca7-4d67-80fe-14e61fa4f526"), "Evenepoel", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Evenepoel@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 111, "Remco" },
                    { new Guid("b8f6b1d3-1793-46ad-b2da-4bedee397e7e"), "Scarlet", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Scarlet@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 308, "Johanson" },
                    { new Guid("af34b235-9552-474f-b3ae-14195f68ed7d"), "Van Overmeire", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "VanOvermeire@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 256, "Marc" },
                    { new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61"), "Depardieu", new Guid("2f17ac7e-e2f2-416e-ba3d-f146bc787366"), "Depardieu@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 85, "Gerard" },
                    { new Guid("448fa4bd-1980-4966-ac23-33b7d14cf71f"), "Hazard", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Hazard@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 23, "Eden" },
                    { new Guid("cb0b938e-a0d7-4626-96ef-a68d4ce34f1c"), "Mega", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Mega@live.be", new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 568, "Mindy" },
                    { new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"), "Jansma", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Jansma@live.be", new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 260, "Johanna" },
                    { new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"), "Franckaert", new Guid("9043158c-7c67-4bab-aa60-1ac6f92d3945"), "Franckaert@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 103, "Robin" },
                    { new Guid("679bbd72-87e8-4fd3-90c4-553444ec0f11"), "Bambino", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Bambino@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 257, "Salvatore" },
                    { new Guid("5d05e90c-eeb0-458c-9e24-ca5a8d7fd460"), "Brokkenpap", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Brokkenpap@live.be", new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 125, "Berend" },
                    { new Guid("92931377-a9c9-437c-8a24-11ad1dea5208"), "Mertens", new Guid("1ceae862-e828-41dd-9289-b0a022cdf061"), "Mertens@live.be", new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 110, "Evelyne" },
                    { new Guid("d88b53ed-bc61-4ecf-97e5-cc3b919f310a"), "Camara", new Guid("4970a64d-32d6-49a1-9f79-18556310f440"), "Camara@live.be", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "202CB962AC59075B964B07152D234B70", 504, "Herdy" }
                });

            migrationBuilder.InsertData(
                table: "FanRegistratie",
                columns: new[] { "SupporterId", "WielrennerId" },
                values: new object[,]
                {
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2") },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") },
                    { new Guid("6f9c152a-7369-4261-89f9-4eb53856888c"), new Guid("1c630941-1fb2-477e-9649-5857bb465e5a") },
                    { new Guid("a702f1c5-2012-4ca8-af75-0a1e7c745708"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") },
                    { new Guid("82234998-22b7-4f4b-8108-d7dea256d508"), new Guid("ff068a9b-ec6f-4972-951f-65ddf0be1e61") },
                    { new Guid("3c2c35df-7b46-465b-8c5a-75aa66156969"), new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557") }
                });

            migrationBuilder.InsertData(
                table: "Fietsen",
                columns: new[] { "Id", "Merk", "WielrennerId", "Zadel" },
                values: new object[,]
                {
                    { new Guid("f8162a50-8e22-48b6-b0ea-ffcef4274c28"), "Merckx", new Guid("991edbe2-eea4-4421-a8cf-a5bf23851ab2"), "Oranje zadel" },
                    { new Guid("c6c0344d-9fce-44da-91de-7f7278f9eb4b"), "B-Twin", new Guid("1c630941-1fb2-477e-9649-5857bb465e5a"), "Zwart zadel" },
                    { new Guid("d588a55b-8024-4e60-a0da-c994c2f0d53e"), "Moldava", new Guid("28ccd503-e5dd-46ab-9950-bddb20fad557"), "Geel zadel" }
                });
        }
    }
}
