using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using P01_BillsPaymentSystem.Data;
using Shkembedjijnica.App.Core;
using Shkembedjijnica.App.Core.Contracts;
using Shkembedjijnica.App.Core.Controlers;
using Shkembedjijnica.Data;
using Shkembedjijnica.Services;
using Shkembedjijnica.Services.Conracts;

namespace Shkembedjijnica.App
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var service = ConfigureService();
            IEngine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ShkembedjijnicaContext>(x => x.UseSqlServer(ServerConfig.ConnectionString));

            serviceCollection.AddAutoMapper(conf => conf.AddProfile<ShkemedjijnicaProfile>());

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();
            serviceCollection.AddTransient<IManagerController, ManagerController>();
            
            
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
