using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Propiedad para poder mapear tablas.
        public DbSet<Country> Countries { get; set; }

        // funcion de indice para que no se puedan repetir los paises
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
            .HasIndex(t => t.Name)
            .IsUnique();
        }
    }
}
