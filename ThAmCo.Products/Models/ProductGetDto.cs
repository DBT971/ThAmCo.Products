using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Products.Models
{
    public class ProductGetDto
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Supply { get; set; }

        public double Price { get; set; }

        public static ProductGetDto FromModel(Data.Products products)
        {
            return new ProductGetDto
            {
                ID = products.ID,
                Name = products.Name,
                Description = products.Description,
                Supply = products.Supply,
                Price = products.Price,
            };
        }
    }
}
