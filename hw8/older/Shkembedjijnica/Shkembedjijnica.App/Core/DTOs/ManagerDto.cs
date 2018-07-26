using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shkembedjijnica.App.Core.DTOs
{
    public class ManagerDto
    {

        public ManagerDto()
        {
            this.EmployeeDtos = new List<EmployeeDto>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<EmployeeDto> EmployeeDtos { get; set; }
        public int EmployeeCount => this.EmployeeDtos.Count();
    }
}
