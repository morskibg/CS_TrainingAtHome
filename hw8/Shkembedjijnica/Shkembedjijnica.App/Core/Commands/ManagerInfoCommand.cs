
using System.Text;
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly IManagerController _managerController;

        public ManagerInfoCommand(IManagerController managerController)
        {
            this._managerController = managerController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            var managerDto = _managerController.GetManagerInfo(employeeId);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{managerDto.FirstName} {managerDto.LastName} | Employees: {managerDto.EmployeeCount}");
            foreach (var emp in managerDto.EmployeeDtos)
            {
                sb.AppendLine($"    - {emp.FirstName} {emp.LastName} - ${emp.Salary:f2}");
            }
            return sb.ToString();
        }
    }
}
