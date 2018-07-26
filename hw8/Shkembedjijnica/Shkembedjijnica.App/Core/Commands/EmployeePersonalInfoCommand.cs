
using System;
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core.Commands
{
    
    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;

        public EmployeePersonalInfoCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            var employee = this._employeeController.GetEmployeePersonalInfo(id);
            string personalDataToPrint =
                $"ID: {employee.EmployeeId} - {employee.FirstName} {employee.LastName} - ${employee.Salary:f2}{Environment.NewLine}" +
                $"Birthday: {employee.Birthdate.Value.ToString("dd-MM-yyyy")}{Environment.NewLine}" +
                $"Address: {employee.Address}";
            return personalDataToPrint;
        }
    }
}
