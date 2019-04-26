using System;
using System.Data.Entity;
using System.Linq;
using TheWorldCountries.Models;

namespace TheWorldCountries.DataAccess
{
    public class DataContext : DbContext
    {

        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Street> Streets { get; set; }
    }
}