using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ThAmCo.Products.Data
{
    public class ProductsDBContext : DbContext
    {
        public ProductsDBContext (DbContextOptions<ProductsDBContext> options)
            : base(options)
        {

        }

        public DbSet<ThAmCo.Products.Data.Products> Products { get; set; }
    }
}
