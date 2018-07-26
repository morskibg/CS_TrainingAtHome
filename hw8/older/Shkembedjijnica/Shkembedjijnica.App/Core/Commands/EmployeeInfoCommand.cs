using System;
using System.Collections.Generic;
using System.Text;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.DTOs;

namespace Shkembedjijnica.App.Core.Commands
{
    public class EmployeeInfoCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;

        public EmployeeInfoCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }
        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            EmployeeDto employee = this._employeeController.GetEmployeeInfo(id);
            string employeeInfo =
                $"ID: {employee.EmployeeId} - {employee.FirstName} {employee.LastName} - ${employee.Salary:f2}";
            return employeeInfo;

        }
    }
}
