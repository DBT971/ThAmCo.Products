using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Products.Models;

namespace ThAmCo.Products.Data
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ProductsDbContext (DbContextOptions<ProductsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
