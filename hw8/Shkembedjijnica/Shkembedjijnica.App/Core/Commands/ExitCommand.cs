
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core.Commands
{
    public class ExitCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;

        public ExitCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            this._employeeController.Exit();
            return null;
        }
    }
}
