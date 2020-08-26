using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Propiedad para poder mapear tablas.
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }

        // funcion de indice para que no se puedan repetir los paises
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
            .HasIndex(t => t.Name)
            .IsUnique();
            
            modelBuilder.Entity<Country>()
            .HasIndex(t => t.Name)
            .IsUnique();
            
            modelBuilder.Entity<Department>()
            .HasIndex(t => t.Name)
            .IsUnique();


        }
    }
}
