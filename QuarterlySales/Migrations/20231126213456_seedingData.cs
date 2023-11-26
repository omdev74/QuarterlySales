using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuarterlySales.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DateOfHire", "Firstname", "Lastname", "ManagerId" },
                values: new object[,]
                {
                    { 3, new DateTime(1912, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1936, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan", "Turing", 0 },
                    { 4, new DateTime(1906, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1943, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace", "Hopper", 0 },
                    { 5, new DateTime(1955, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tim", "Berners-Lee", 0 },
                    { 6, new DateTime(1936, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margaret", "Hamilton", 0 },
                    { 7, new DateTime(1927, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "McCarthy", 0 },
                    { 8, new DateTime(1938, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donald", "Knuth", 0 },
                    { 9, new DateTime(1939, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barbara", "Liskov", 0 },
                    { 10, new DateTime(1943, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1969, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ken", "Thompson", 0 },
                    { 11, new DateTime(1941, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis", "Ritchie", 0 },
                    { 12, new DateTime(1969, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linus", "Torvalds", 0 },
                    { 13, new DateTime(1939, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ada", "Yonath", 0 },
                    { 14, new DateTime(1976, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrew", "Ng", 0 },
                    { 15, new DateTime(1958, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shafi", "Goldwasser", 0 },
                    { 16, new DateTime(1913, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1936, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurice", "Wilkes", 0 },
                    { 17, new DateTime(1932, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1957, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frances", "Allen", 0 },
                    { 18, new DateTime(1964, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeff", "Bezos", 0 },
                    { 19, new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elon", "Musk", 0 },
                    { 20, new DateTime(1967, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Satya", "Nadella", 0 }
                });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "SalesDataId", "Amount", "EmployeeId", "Quarter", "Year" },
                values: new object[,]
                {
                    { 4, 55000.00m, 1, 3, 2023 },
                    { 5, 70000.00m, 1, 4, 2023 },
                    { 6, 65000.00m, 2, 2, 2023 },
                    { 7, 60000.00m, 3, 3, 2023 },
                    { 8, 75000.00m, 3, 1, 2023 },
                    { 9, 80000.00m, 4, 2, 2023 },
                    { 10, 60000.00m, 4, 4, 2023 },
                    { 11, 70000.00m, 5, 1, 2023 },
                    { 12, 55000.00m, 5, 3, 2023 },
                    { 13, 75000.00m, 6, 2, 2023 },
                    { 14, 60000.00m, 6, 4, 2023 },
                    { 15, 65000.00m, 7, 1, 2023 },
                    { 16, 70000.00m, 7, 3, 2023 },
                    { 17, 80000.00m, 8, 2, 2023 },
                    { 18, 55000.00m, 8, 4, 2023 },
                    { 19, 75000.00m, 9, 1, 2023 },
                    { 20, 60000.00m, 9, 3, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SalesData",
                keyColumn: "SalesDataId",
                keyValue: 20);
        }
    }
}
