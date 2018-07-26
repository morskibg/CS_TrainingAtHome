using System;

using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.DTOs;

namespace Shkembedjijnica.App.Core.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;
        public AddEmployeeCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            string firstName = args[0];
            string lastName = args[1];
            decimal salary = decimal.Parse(args[2]);
            EmployeeDto employeeDto = new EmployeeDto
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            };
            this._employeeController.AddEmployee(employeeDto); 
            return String.Format(Messages.SuccessifulEmpAdding + employeeDto.FirstName + " " + employeeDto.LastName);
        }
    }
}
