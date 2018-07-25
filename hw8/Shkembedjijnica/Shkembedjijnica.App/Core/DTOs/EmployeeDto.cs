﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shkembedjijnica.App.Core.DTOs
{
    public class EmployeeDto
    {
        
        public int EmployeeId { get; set; }
    
        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}
