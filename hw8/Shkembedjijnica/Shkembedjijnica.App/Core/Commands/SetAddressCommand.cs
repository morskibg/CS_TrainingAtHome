using System;
using System.Collections.Generic;
using System.Text;
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
            this._employeeController.SetAddress(id, args[1]);
            return String.Format(Messages.SuccessifulChangeAddress + args[1]);
        }
    
    }
}
