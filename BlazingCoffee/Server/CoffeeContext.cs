using BlazingCoffee.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingCoffee.Server
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Locale> Locales { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
