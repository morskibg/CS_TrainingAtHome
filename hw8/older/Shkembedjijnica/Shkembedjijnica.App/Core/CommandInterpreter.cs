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
        private readonly IServiceProvider _serviceProvider;
        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }
        public string Read(string[] input)
        {
            string commandName = input[0] + "Command";
            string[] args = input.Skip(1).ToArray();
            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName);
            var constructor = type.GetConstructors().First();
            var constructorParams = constructor.GetParameters()
                                                 .Select(x => x.ParameterType)
                                                 .ToArray();
            var service = constructorParams.Select(_serviceProvider.GetService).ToArray();

            var command = (ICommand)constructor.Invoke(service);
            string result = command.Execute(args);
            return result;

        }
    }
}
