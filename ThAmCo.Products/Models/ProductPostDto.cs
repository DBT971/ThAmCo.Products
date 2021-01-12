using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Products.Models
{
    public class ProductPostDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Supply { get; set; }

        public double Price { get; set; }
    }
}
