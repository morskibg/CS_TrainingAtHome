
using Shkembedjijnica.Models;

namespace Shkembedjijnica.App.Core.DTOs
{
    public class AgeComparingEmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
}
