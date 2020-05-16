using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>
            {
                new Product { Id = "p01", Name = "name 1", Price = 4,},
                new Product { Id = "p02", Name = "name 2", Price = 4,},
                new Product { Id = "p03", Name = "name 3", Price = 6,},
            };
        }

        public List<Product> findAll => Products;

        public Product find(String id) => Products.Select(p => p.Id == id).Take(1);
    }
}
