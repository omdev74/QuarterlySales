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
                }, new Employee
                {
                    EmployeeId = 3,
                    Firstname = "Alan",
                    Lastname = "Turing",
                    DOB = new DateTime(1912, 6, 23),
                    DateOfHire = new DateTime(1936, 1, 1),
                    ManagerId = 0
                },
    new Employee
    {
        EmployeeId = 4,
        Firstname = "Grace",
        Lastname = "Hopper",
        DOB = new DateTime(1906, 12, 9),
        DateOfHire = new DateTime(1943, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 5,
        Firstname = "Tim",
        Lastname = "Berners-Lee",
        DOB = new DateTime(1955, 6, 8),
        DateOfHire = new DateTime(1989, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 6,
        Firstname = "Margaret",
        Lastname = "Hamilton",
        DOB = new DateTime(1936, 8, 17),
        DateOfHire = new DateTime(1965, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 7,
        Firstname = "John",
        Lastname = "McCarthy",
        DOB = new DateTime(1927, 9, 4),
        DateOfHire = new DateTime(1956, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 8,
        Firstname = "Donald",
        Lastname = "Knuth",
        DOB = new DateTime(1938, 1, 10),
        DateOfHire = new DateTime(1963, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 9,
        Firstname = "Barbara",
        Lastname = "Liskov",
        DOB = new DateTime(1939, 11, 7),
        DateOfHire = new DateTime(1968, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 10,
        Firstname = "Ken",
        Lastname = "Thompson",
        DOB = new DateTime(1943, 2, 4),
        DateOfHire = new DateTime(1969, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 11,
        Firstname = "Dennis",
        Lastname = "Ritchie",
        DOB = new DateTime(1941, 9, 9),
        DateOfHire = new DateTime(1967, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 12,
        Firstname = "Linus",
        Lastname = "Torvalds",
        DOB = new DateTime(1969, 12, 28),
        DateOfHire = new DateTime(1991, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 13,
        Firstname = "Ada",
        Lastname = "Yonath",
        DOB = new DateTime(1939, 6, 22),
        DateOfHire = new DateTime(1988, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 14,
        Firstname = "Andrew",
        Lastname = "Ng",
        DOB = new DateTime(1976, 4, 18),
        DateOfHire = new DateTime(2000, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 15,
        Firstname = "Shafi",
        Lastname = "Goldwasser",
        DOB = new DateTime(1958, 9, 11),
        DateOfHire = new DateTime(1983, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 16,
        Firstname = "Maurice",
        Lastname = "Wilkes",
        DOB = new DateTime(1913, 6, 26),
        DateOfHire = new DateTime(1936, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 17,
        Firstname = "Frances",
        Lastname = "Allen",
        DOB = new DateTime(1932, 8, 4),
        DateOfHire = new DateTime(1957, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 18,
        Firstname = "Jeff",
        Lastname = "Bezos",
        DOB = new DateTime(1964, 1, 12),
        DateOfHire = new DateTime(1994, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 19,
        Firstname = "Elon",
        Lastname = "Musk",
        DOB = new DateTime(1971, 6, 28),
        DateOfHire = new DateTime(1996, 1, 1),
        ManagerId = 0
    },
    new Employee
    {
        EmployeeId = 20,
        Firstname = "Satya",
        Lastname = "Nadella",
        DOB = new DateTime(1967, 8, 19),
        DateOfHire = new DateTime(1992, 1, 1),
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
                },
                 new SalesData
                 {
                     SalesDataId = 4,
                     Quarter = 3,
                     Year = 2023,
                     Amount = 55000.00m,
                     EmployeeId = 1
                 },
    new SalesData
    {
        SalesDataId = 5,
        Quarter = 4,
        Year = 2023,
        Amount = 70000.00m,
        EmployeeId = 1
    },
    new SalesData
    {
        SalesDataId = 6,
        Quarter = 2,
        Year = 2023,
        Amount = 65000.00m,
        EmployeeId = 2
    },
    // Add more sales data as needed...
    new SalesData
    {
        SalesDataId = 7,
        Quarter = 3,
        Year = 2023,
        Amount = 60000.00m,
        EmployeeId = 3
    },
    new SalesData
    {
        SalesDataId = 8,
        Quarter = 1,
        Year = 2023,
        Amount = 75000.00m,
        EmployeeId = 3
    },
    new SalesData
    {
        SalesDataId = 9,
        Quarter = 2,
        Year = 2023,
        Amount = 80000.00m,
        EmployeeId = 4
    },
    new SalesData
    {
        SalesDataId = 10,
        Quarter = 4,
        Year = 2023,
        Amount = 60000.00m,
        EmployeeId = 4
    },
    new SalesData
    {
        SalesDataId = 11,
        Quarter = 1,
        Year = 2023,
        Amount = 70000.00m,
        EmployeeId = 5
    },
    new SalesData
    {
        SalesDataId = 12,
        Quarter = 3,
        Year = 2023,
        Amount = 55000.00m,
        EmployeeId = 5
    },
    new SalesData
    {
        SalesDataId = 13,
        Quarter = 2,
        Year = 2023,
        Amount = 75000.00m,
        EmployeeId = 6
    },
    new SalesData
    {
        SalesDataId = 14,
        Quarter = 4,
        Year = 2023,
        Amount = 60000.00m,
        EmployeeId = 6
    },
    new SalesData
    {
        SalesDataId = 15,
        Quarter = 1,
        Year = 2023,
        Amount = 65000.00m,
        EmployeeId = 7
    },
    new SalesData
    {
        SalesDataId = 16,
        Quarter = 3,
        Year = 2023,
        Amount = 70000.00m,
        EmployeeId = 7
    },
    new SalesData
    {
        SalesDataId = 17,
        Quarter = 2,
        Year = 2023,
        Amount = 80000.00m,
        EmployeeId = 8
    },
    new SalesData
    {
        SalesDataId = 18,
        Quarter = 4,
        Year = 2023,
        Amount = 55000.00m,
        EmployeeId = 8
    },
    new SalesData
    {
        SalesDataId = 19,
        Quarter = 1,
        Year = 2023,
        Amount = 75000.00m,
        EmployeeId = 9
    },
    new SalesData
    {
        SalesDataId = 20,
        Quarter = 3,
        Year = 2023,
        Amount = 60000.00m,
        EmployeeId = 9
    }

            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
