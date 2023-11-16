using FirstFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FirstFluentAPI.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Bicycles> Bicycles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
        }
    }
}
