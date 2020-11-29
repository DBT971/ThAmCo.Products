using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Products.Data
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Supply { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool Available { get; set; }


    }
}
