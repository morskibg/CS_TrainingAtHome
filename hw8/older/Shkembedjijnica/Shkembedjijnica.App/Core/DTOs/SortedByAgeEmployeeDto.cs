using System;
using System.Collections.Generic;
using System.Text;

namespace Shkembedjijnica.App.Core.DTOs
{
    public class SortedByAgeEmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int? ManagerId { get; set; }
    }
}
