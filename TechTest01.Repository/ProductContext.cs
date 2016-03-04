using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductContext : DbContext
    {
        public ProductContext(): base("ProductContext")
       {

       }
       
       public DbSet<Product> Products { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
       }
    }
}
