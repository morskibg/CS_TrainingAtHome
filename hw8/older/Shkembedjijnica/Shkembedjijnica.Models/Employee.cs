
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shkembedjijnica.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Employees = new HashSet<Employee>();
        }
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
