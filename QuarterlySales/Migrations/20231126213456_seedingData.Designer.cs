﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuarterlySales.Models;

#nullable disable

namespace QuarterlySales.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231126213456_seedingData")]
    partial class seedingData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuarterlySales.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfHire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DOB = new DateTime(1956, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Ada",
                            Lastname = "Lovelace",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            DOB = new DateTime(1791, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1830, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Charles",
                            Lastname = "Babbage",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 3,
                            DOB = new DateTime(1912, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1936, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Alan",
                            Lastname = "Turing",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 4,
                            DOB = new DateTime(1906, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1943, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Grace",
                            Lastname = "Hopper",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 5,
                            DOB = new DateTime(1955, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Tim",
                            Lastname = "Berners-Lee",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 6,
                            DOB = new DateTime(1936, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Margaret",
                            Lastname = "Hamilton",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 7,
                            DOB = new DateTime(1927, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1956, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "John",
                            Lastname = "McCarthy",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 8,
                            DOB = new DateTime(1938, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Donald",
                            Lastname = "Knuth",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 9,
                            DOB = new DateTime(1939, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Barbara",
                            Lastname = "Liskov",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 10,
                            DOB = new DateTime(1943, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1969, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Ken",
                            Lastname = "Thompson",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 11,
                            DOB = new DateTime(1941, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1967, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Dennis",
                            Lastname = "Ritchie",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 12,
                            DOB = new DateTime(1969, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Linus",
                            Lastname = "Torvalds",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 13,
                            DOB = new DateTime(1939, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Ada",
                            Lastname = "Yonath",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 14,
                            DOB = new DateTime(1976, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Andrew",
                            Lastname = "Ng",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 15,
                            DOB = new DateTime(1958, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Shafi",
                            Lastname = "Goldwasser",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 16,
                            DOB = new DateTime(1913, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1936, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Maurice",
                            Lastname = "Wilkes",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 17,
                            DOB = new DateTime(1932, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1957, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Frances",
                            Lastname = "Allen",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 18,
                            DOB = new DateTime(1964, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Jeff",
                            Lastname = "Bezos",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 19,
                            DOB = new DateTime(1971, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Elon",
                            Lastname = "Musk",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 20,
                            DOB = new DateTime(1967, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Satya",
                            Lastname = "Nadella",
                            ManagerId = 0
                        });
                });

            modelBuilder.Entity("QuarterlySales.Models.SalesData", b =>
                {
                    b.Property<int>("SalesDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesDataId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Quarter")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("SalesDataId");

                    b.ToTable("SalesData");

                    b.HasData(
                        new
                        {
                            SalesDataId = 1,
                            Amount = 50000.00m,
                            EmployeeId = 1,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 2,
                            Amount = 75000.00m,
                            EmployeeId = 1,
                            Quarter = 2,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 3,
                            Amount = 60000.00m,
                            EmployeeId = 2,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 4,
                            Amount = 55000.00m,
                            EmployeeId = 1,
                            Quarter = 3,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 5,
                            Amount = 70000.00m,
                            EmployeeId = 1,
                            Quarter = 4,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 6,
                            Amount = 65000.00m,
                            EmployeeId = 2,
                            Quarter = 2,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 7,
                            Amount = 60000.00m,
                            EmployeeId = 3,
                            Quarter = 3,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 8,
                            Amount = 75000.00m,
                            EmployeeId = 3,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 9,
                            Amount = 80000.00m,
                            EmployeeId = 4,
                            Quarter = 2,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 10,
                            Amount = 60000.00m,
                            EmployeeId = 4,
                            Quarter = 4,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 11,
                            Amount = 70000.00m,
                            EmployeeId = 5,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 12,
                            Amount = 55000.00m,
                            EmployeeId = 5,
                            Quarter = 3,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 13,
                            Amount = 75000.00m,
                            EmployeeId = 6,
                            Quarter = 2,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 14,
                            Amount = 60000.00m,
                            EmployeeId = 6,
                            Quarter = 4,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 15,
                            Amount = 65000.00m,
                            EmployeeId = 7,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 16,
                            Amount = 70000.00m,
                            EmployeeId = 7,
                            Quarter = 3,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 17,
                            Amount = 80000.00m,
                            EmployeeId = 8,
                            Quarter = 2,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 18,
                            Amount = 55000.00m,
                            EmployeeId = 8,
                            Quarter = 4,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 19,
                            Amount = 75000.00m,
                            EmployeeId = 9,
                            Quarter = 1,
                            Year = 2023
                        },
                        new
                        {
                            SalesDataId = 20,
                            Amount = 60000.00m,
                            EmployeeId = 9,
                            Quarter = 3,
                            Year = 2023
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
