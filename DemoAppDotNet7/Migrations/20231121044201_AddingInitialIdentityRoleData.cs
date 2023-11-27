using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoAppDotNet7.Migrations
{
    /// <inheritdoc />
    public partial class AddingInitialIdentityRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15a501db-cd89-46a2-8364-b3a1c6e95142", "6baa9281-9f34-4e96-803e-8adb4c07660a", "Admin", "admin" },
                    { "227f9758-3901-4692-98df-a713439c9492", "94bdddbb-c352-44c9-93a4-d892477721f5", "User", "user" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 11, 21, 7, 42, 1, 536, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2023, 11, 21, 7, 42, 1, 536, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2023, 11, 21, 7, 42, 1, 536, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2023, 11, 21, 7, 42, 1, 536, DateTimeKind.Local).AddTicks(1011));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15a501db-cd89-46a2-8364-b3a1c6e95142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "227f9758-3901-4692-98df-a713439c9492");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 11, 20, 3, 15, 10, 331, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2023, 11, 20, 3, 15, 10, 331, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2023, 11, 20, 3, 15, 10, 331, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2023, 11, 20, 3, 15, 10, 331, DateTimeKind.Local).AddTicks(1206));
        }
    }
}
