using System;

using System.Linq;

using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly IEmployeeController _employeeController;

        public SetAddressCommand(IEmployeeController employeeController)
        {
            this._employeeController = employeeController;
        }
        public string Execute(string[] args)
        {
            int id = int.Parse(args[0]);
            var rawAddress = args.Skip(1).ToArray();
            string address = string.Join(", ", rawAddress);
            this._employeeController.SetAddress(id, address);
            return String.Format(Messages.SuccessifulChangeAddress + address);
        }
    
    }
}
