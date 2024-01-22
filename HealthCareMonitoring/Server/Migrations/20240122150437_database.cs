using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthCareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85f74d08-7931-4e26-8d7a-32bf9807a0eb", "AQAAAAIAAYagAAAAEOMWOw5PXbPI1TRuZst+OzF1hnEQU4Q6kF6NRs799s6VhYo5phy9sfSCQ9mYeO9P1A==", "3d475b5c-1685-40bd-be7b-c5c2e1ef3d4e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e44b6d99-4292-45c8-bc5a-5bb19352f581", 0, "c4ba4f3d-6e3b-46ab-9f28-f2bc19a7fcaf", "test@blazor.com", false, "Test", "User", false, null, "TEST@BLAZOR.COM", "TEST@BLAZOR.COM", "AQAAAAIAAYagAAAAEKL3eXFxTPRgL7xaeXbbJqa3cL0gQIUp6DRi64DH98zmyZ3DXUYmlY0paoHKeCeT6g==", null, false, "d953e0d8-a736-41d6-8974-c8217110371e", false, "test@blazor.com" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3330), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3909), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3914), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 1, 22, 23, 4, 36, 573, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "ContactNo", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DateYearJoined", "EmailAddress", "FirstName", "LastName", "Password", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, 12345678, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5635), "michealtan@blazor.com", "Micheal", "Tan", "ilovekfc@123", "System", "Mike" },
                    { 2, 87654321, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5675), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5674), "johntoh@blazor.com", "John", "Toh", "ihatekfc@321", "System", "Jonny" },
                    { 3, 13243546, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5677), "lilyleow@blazor.com", "Lily", "Leow", "ilovemcs@123", "System", "Lil lee" },
                    { 4, 65432146, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5681), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5680), "ryantan@blazor.com", "Ryan", "Tan", "ihatemcs@321", "System", "Raiden" },
                    { 5, 84745671, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 1, 22, 23, 4, 36, 927, DateTimeKind.Local).AddTicks(5683), "nicolelim@blazor.com", "Nicole", "Lim", "tysagoat@123", "System", "Nicolas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e44b6d99-4292-45c8-bc5a-5bb19352f581");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be329c58-84ac-4669-afb6-5654522d58b3", "AQAAAAIAAYagAAAAEKkSADRExPSLFfcDebNTlDFspQRmeX20HMCIJB7sGvlinvvR9BAqA3hFsclMTHKC+Q==", "5275f7b1-9881-4f9c-a562-cf4323e1deb4" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 1, 22, 21, 45, 40, 74, DateTimeKind.Local).AddTicks(4000) });
        }
    }
}
