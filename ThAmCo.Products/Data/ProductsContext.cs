using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Products.Models;

namespace ThAmCo.Products.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext (DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }

        public DbSet<ThAmCo.Products.Models.ProductGetDto> ProductGetDto { get; set; }
    }
}
