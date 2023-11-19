using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoAppDotNet7.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathPropForTblEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "HireDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 11, 19, 5, 13, 23, 196, DateTimeKind.Local).AddTicks(8902), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "HireDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 11, 19, 5, 13, 23, 196, DateTimeKind.Local).AddTicks(8937), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "HireDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 11, 19, 5, 13, 23, 196, DateTimeKind.Local).AddTicks(8939), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "HireDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 11, 19, 5, 13, 23, 196, DateTimeKind.Local).AddTicks(8941), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 11, 7, 3, 3, 10, 471, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2023, 11, 7, 3, 3, 10, 471, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2023, 11, 7, 3, 3, 10, 471, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2023, 11, 7, 3, 3, 10, 471, DateTimeKind.Local).AddTicks(7839));
        }
    }
}
