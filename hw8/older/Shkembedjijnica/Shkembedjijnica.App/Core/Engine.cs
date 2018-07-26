using System;
using Microsoft.Extensions.DependencyInjection;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.Services.Conracts;

namespace Shkembedjijnica.App.Core
{
    public class Engine : IEngine
    {
        private readonly IServiceProvider _serviceProvider;
        public Engine(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }
        public void Run()
        {
            var initializeDb = this._serviceProvider.GetService<IDbInitializerService>();
            initializeDb.InitializeDatabase();
            var commandInterpreter = this._serviceProvider.GetService<ICommandInterpreter>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
