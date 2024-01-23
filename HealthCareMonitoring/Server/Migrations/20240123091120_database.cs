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
            migrationBuilder.RenameColumn(
                name: "DateTimeJoined",
                table: "Staffs",
                newName: "DateYearJoined");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Medicines",
                newName: "ManufacturedDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc73bd3f-1ec1-4efa-8edf-6ddd44838c6c", "AQAAAAIAAYagAAAAEDNbGxduC9rHXYz0y5C5PwuAVIQJULpCZ4DuyfjrcR3maWVuCH3kGO13akKO6yyaIQ==", "ec1d1cb4-035a-4dff-a0d7-e923f84fc917" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b51266b-b91f-4439-ad2d-a6d37eab697a", 0, "386ddcae-32e0-44ba-8709-cf405be50e0a", "test@blazor.com", false, "Test", "User", false, null, "TEST@BLAZOR.COM", "TEST@BLAZOR.COM", "AQAAAAIAAYagAAAAEImkTTY8wyMMrFzR0uXOQMCiq7tRW8+FQAhmdJFzR5JL+cRNQMI+aDOEn5qbXrMzkw==", null, false, "02d6174a-214d-4735-8fcc-03763ff8df80", false, "test@blazor.com" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3434), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3436), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 1, 23, 17, 11, 19, 743, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "ContactNo", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DateYearJoined", "EmailAddress", "FirstName", "LastName", "Password", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, 12345678, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1848), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1830), "michealtan@blazor.com", "Micheal", "Tan", "ilovekfc@123", "System", "Mike" },
                    { 2, 87654321, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1852), "johntoh@blazor.com", "John", "Toh", "ihatekfc@321", "System", "Jonny" },
                    { 3, 13243546, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1856), "lilyleow@blazor.com", "Lily", "Leow", "ilovemcs@123", "System", "Lil lee" },
                    { 4, 65432146, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1859), "ryantan@blazor.com", "Ryan", "Tan", "ihatemcs@321", "System", "Raiden" },
                    { 5, 84745671, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 1, 23, 17, 11, 19, 907, DateTimeKind.Local).AddTicks(1862), "nicolelim@blazor.com", "Nicole", "Lim", "tysagoat@123", "System", "Nicolas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b51266b-b91f-4439-ad2d-a6d37eab697a");

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

            migrationBuilder.RenameColumn(
                name: "DateYearJoined",
                table: "Staffs",
                newName: "DateTimeJoined");

            migrationBuilder.RenameColumn(
                name: "ManufacturedDate",
                table: "Medicines",
                newName: "StartDate");

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
