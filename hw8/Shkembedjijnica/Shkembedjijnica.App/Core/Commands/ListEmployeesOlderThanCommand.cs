using Shkembedjijnica.App.Core.Contracts;
using System.Text;

namespace Shkembedjijnica.App.Core.Commands
{
    public class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;

        public ListEmployeesOlderThanCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int age = int.Parse(args[0]);
            
            var result = this._employeeController.GetListEmployeesOlderThan(age);
            foreach (var emp in result)
            {
                sb.AppendLine(
                    $"{emp.FirstName} {emp.LastName} - ${emp.Salary:f2} - Manager: " +
                    $"{(emp.ManagerId == null ? "[no manager]" : emp.Manager.LastName)}");
            }
            return sb.ToString() ;
        }
    }
}
