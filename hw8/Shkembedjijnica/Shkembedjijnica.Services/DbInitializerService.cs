
using Shkembedjijnica.Data;
using Shkembedjijnica.Services.Conracts;
using Microsoft.EntityFrameworkCore;

namespace Shkembedjijnica.Services
{
    public class DbInitializerService : IDbInitializerService
    {
        private readonly ShkembedjijnicaContext context;
        public DbInitializerService(ShkembedjijnicaContext context)
        {
            this.context = context;
        }
        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
