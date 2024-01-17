using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthCareMonitoring.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedfrthistime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4d2f9fc1-a85a-47cd-b44e-2bd03af2edcc", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKU2tHvoeTSZtQpY07JD5b4G09Y4st/PjLoRvr2PGmzFEUFVAcOw7WfUCs48eA8CPQ==", null, false, "e37466b7-6874-4a63-895e-b7b47e9e2865", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "100 Bukit Timah Road", "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3571), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3582), null, "KK Women’s and Children’s Hospital", "System" },
                    { 2, "Outram Road", "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3585), null, "Singapore General Hospital", "System" },
                    { 3, "Napier Road", "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3587), null, "Gleneagles Hospital", "System" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ExpiryDate", "MedicineFee", "Name", "StartDate", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3960), "Used for headaches", null, 5, "Paracetamol", null, "Tablet", "System" },
                    { 2, "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3962), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3963), "Strong Painkiller, Only used when needed", null, 5, "Ibuprofen", null, "Tablet", "System" },
                    { 3, "System", new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 1, 17, 12, 24, 9, 154, DateTimeKind.Local).AddTicks(3965), "Used to treat anxiety disorders", null, 5, "Xanax", null, "Pill", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
