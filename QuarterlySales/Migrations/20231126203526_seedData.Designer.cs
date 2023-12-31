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
    [Migration("20231126203526_seedData")]
    partial class seedData
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
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
