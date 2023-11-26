using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuarterlySales.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[] { 2, new DateTime(1791, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1830, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", "Babbage", 0 });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "SalesDataId", "Amount", "EmployeeId", "Quarter", "Year" },
                values: new object[,]
                {
                    { 1, 50000.00m, 1, 1, 2023 },
                    { 2, 75000.00m, 1, 2, 2023 },
                    { 3, 60000.00m, 2, 1, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 3);
        }
    }
}
