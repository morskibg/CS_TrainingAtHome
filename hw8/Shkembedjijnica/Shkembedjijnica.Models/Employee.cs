
using System;
using System.ComponentModel.DataAnnotations;

namespace Shkembedjijnica.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }

    }
}
