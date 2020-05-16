using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            products = new List<Product> {
                new Product{ Id = "p01", Name = "name 1", Price = 1},
                new Product{ Id = "p02", Name = "name 2", Price = 23},
                new Product{ Id = "p03", Name = "name 3", Price = 5},
                new Product{ Id = "p04", Name = "name 4", Price = 2},
                new Product{ Id = "p05", Name = "name 5", Price = 66 },
            };
        }

        public List<Product> findAll()
        {
            return products;
        }

        public List<Product> Search(string keyword) => products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();

        public List<Product> Search(double min, double max) => products.Where(p => p.Price >= min && p.Price <= max).ToList();

    }
}
