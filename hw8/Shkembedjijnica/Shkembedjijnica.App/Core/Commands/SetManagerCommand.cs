
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core.Commands
{
    public class SetManagerCommand : ICommand
    {
        private readonly IManagerController _managerController;

        public SetManagerCommand(IManagerController managerController)
        {
            this._managerController = managerController;
        }
        public string Execute(string[] args)
        {
            int managerId = int.Parse(args[0]);
            int employeeId = int.Parse(args[1]);
            this._managerController.AddManager(managerId, employeeId);
            return string.Format(Messages.SuccessifulSetManager);
        }

    }
}