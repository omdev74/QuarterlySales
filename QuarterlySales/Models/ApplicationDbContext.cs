using Microsoft.EntityFrameworkCore;
using System;

namespace QuarterlySales.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalesData> SalesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            // Add seed data for employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Firstname = "Ada",
                    Lastname = "Lovelace",
                    DOB = new DateTime(1956, 12, 10),
                    DateOfHire = new DateTime(1995, 1, 1),
                    ManagerId = 0
                },
                new Employee
                {
                    EmployeeId = 2,
                    Firstname = "Charles",
                    Lastname = "Babbage",
                    DOB = new DateTime(1791, 12, 26),
                    DateOfHire = new DateTime(1830, 1, 1),
                    ManagerId = 0
                }
            );

            // Add seed data for sales data
            modelBuilder.Entity<SalesData>().HasData(
                new SalesData
                {
                    SalesDataId = 1,
                    Quarter = 1,
                    Year = 2023,
                    Amount = 50000.00m,
                    EmployeeId = 1
                },
                new SalesData
                {
                    SalesDataId = 2,
                    Quarter = 2,
                    Year = 2023,
                    Amount = 75000.00m,
                    EmployeeId = 1
                },
                new SalesData
                {
                    SalesDataId = 3,
                    Quarter = 1,
                    Year = 2023,
                    Amount = 60000.00m,
                    EmployeeId = 2
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
