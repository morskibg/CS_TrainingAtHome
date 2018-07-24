using System;
using System.Collections.Generic;
using System.Text;
using Shkembedjijnica.App.Core.DTOs;

namespace Shkembedjijnica.App.Core.Contracts
{
    public interface IEmployeeController
    {
        void AddEmployee(EmployeeDto employeeDto);
    }
}
