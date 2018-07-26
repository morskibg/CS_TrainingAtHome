using System;


namespace Shkembedjijnica.App.Core.DTOs
{
    public class EmployeeFullInfoDto
    {
       
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
    }
}
