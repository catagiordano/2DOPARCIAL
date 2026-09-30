using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Data
{
    // public class AplicationDbContext : DbContext
    {
     //   public DbSet<>  { get; set; }

     //   public DbSet<>  { get; set; }

     //   public DbSet<>  { get; set; }

     //   public DbSet<>  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=C:\\Database\\2DOPARCIAL.db"
            );
        }
    }
}
