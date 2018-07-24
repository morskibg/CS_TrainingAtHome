using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using P01_BillsPaymentSystem.Data;
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
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ShkembedjijnicaContext>(x => x.UseSqlServer(ServerConfig.ConnectionString));
            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
