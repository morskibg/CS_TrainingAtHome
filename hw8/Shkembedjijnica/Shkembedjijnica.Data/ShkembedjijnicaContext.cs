
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using Shkembedjijnica.Models;

namespace Shkembedjijnica.Data
{
    public class ShkembedjijnicaContext : DbContext
    {
        public ShkembedjijnicaContext()
        {
        }

        public ShkembedjijnicaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ServerConfig.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasMany(x => x.EmployeesManager).WithOne(x => x.Manager)
                .HasForeignKey(x => x.ManagerId);
        }
    }
}
