using System;
using System.Collections.Generic;
using System.Text;

namespace Shkembedjijnica.App.Core.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
