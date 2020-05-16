using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            products = new List<Product> {
                new Product {Id = "p01", Name = "name 1", Price = 1, Description = "good"},
                new Product {Id = "p02", Name = "name 2", Price = 1, Description = "good"},
                new Product {Id = "p03", Name = "name 3", Price = 1, Description = "good"},
                new Product {Id = "p04", Name = "name 4", Price = 1, Description = "good"},
                new Product {Id = "p05", Name = "name 5", Price = 5, Description = "good"},
            };
        }

        public List<Product> findAll() => products;

        public Product find(string id) => products.SingleOrDefault(p => p.Id == id);
    }
}
