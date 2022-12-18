using E_Commerce_Web_Application.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce_Web_Application.Entity
{
    public class DataContext : DbContext
    {
        public DataContext(): base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<RegisterCustomer> RegisterCustomers { get; set; }
        //public DbSet<AspNetUsers> AspNetUser { get; set; }

    }
}