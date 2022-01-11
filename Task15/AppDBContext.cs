using System;

using Microsoft.EntityFrameworkCore;
using task15.Models;

namespace task15
{
    public class AppDBContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public AppDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Cities.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().Navigation(x => x.Cities).AutoInclude();
            modelBuilder.Entity<City>().Navigation(x => x.Country).AutoInclude();
        }
    }
}
