using Microsoft.EntityFrameworkCore;
using Presentacion.Entities;
namespace Presentacion.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public DbSet<Custom> Customs { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
}
