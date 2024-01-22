using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthCareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class pluspatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a53c916e-2b7a-4ca0-8ed8-10b1b4b00f07", "AQAAAAIAAYagAAAAEOND1WdFjk8eR1meNzXK1AeEVzM1d1Q8I4OCYean5JIG9LRBDxhJm5vUFpdxY3SLiw==", "5336196b-9d39-49ee-9040-e09b1a059680" });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7338), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7931), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 1, 22, 21, 51, 4, 337, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "ContactNo", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DateYearJoined", "EmailAddress", "FirstName", "LastName", "Password", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, 12345678, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(7976), "michealtan@blazor.com", "Micheal", "Tan", "ilovekfc@123", "System", "Mike" },
                    { 2, 87654321, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8008), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8007), "johntoh@blazor.com", "John", "Toh", "ihatekfc@321", "System", "Jonny" },
                    { 3, 13243546, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8012), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8010), "lilyleow@blazor.com", "Lily", "Leow", "ilovemcs@123", "System", "Lil lee" },
                    { 4, 65432146, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8015), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8014), "ryantan@blazor.com", "Ryan", "Tan", "ihatemcs@321", "System", "Raiden" },
                    { 5, 84745671, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1977, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 1, 22, 21, 51, 4, 488, DateTimeKind.Local).AddTicks(8019), "nicolelim@blazor.com", "Nicole", "Lim", "tysagoat@123", "System", "Nicolas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
