using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Shkembedjijnica.App.Core.Contracts;

namespace Shkembedjijnica.App.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IServiceProvider _iServiceProvider;
        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this._iServiceProvider = serviceProvider;
        }
        public string Read(string[] input)
        {
            string commandName = input[0] + "Command";
            string[] args = input.Skip(1).ToArray();
            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName);


        }
    }
}
