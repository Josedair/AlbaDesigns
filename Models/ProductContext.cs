using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebStore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WebStore")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
    }
}