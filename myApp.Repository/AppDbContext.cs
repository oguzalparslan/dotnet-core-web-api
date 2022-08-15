using Microsoft.EntityFrameworkCore;
using myApp.Core.Models;
using System.Reflection;

namespace myApp.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<ActiveWorks>? activeWorks { get; set; }
        DbSet<Device>? device { get; set; }
        DbSet<TechnicalService>? technicalService { get; set; }
        //DbSet<TechnicalService>? technicalService { get; set; }
        //DbSet<Customer> customer { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
