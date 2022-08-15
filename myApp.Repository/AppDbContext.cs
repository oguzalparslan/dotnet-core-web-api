using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using myApp.Core.Models;
using System.Reflection;

namespace myApp.Repository
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        
        }
        DbSet<ActiveWorks> ActiveWorks { get; set; }
        DbSet<Device> Devices { get; set; }
        DbSet<TechnicalService> TechnicalServices { get; set; }
        DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
