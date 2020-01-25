using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ozcan.MvcWebUI.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}