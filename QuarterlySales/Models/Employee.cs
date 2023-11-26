using System;
using System.ComponentModel.DataAnnotations;

namespace QuarterlySales.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [PastDate(ErrorMessage = "Date of birth must be in the past")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Date of hire is required")]
        [DataType(DataType.Date)]
        [PastDate(ErrorMessage = "Date of hire must be in the past")]
        [DateAfterAttribute("1995-01-01", ErrorMessage = "Date of hire must be after 1/1/1995")]
        public DateTime DateOfHire { get; set; }

        public int ManagerId { get; set; }
    }
}
