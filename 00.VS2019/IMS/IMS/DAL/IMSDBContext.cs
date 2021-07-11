using IMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IMS.DAL
{
    public class IMSDBContext: DbContext
    {
        public IMSDBContext() : base("IMSDBContext")
        { 
        }

        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}