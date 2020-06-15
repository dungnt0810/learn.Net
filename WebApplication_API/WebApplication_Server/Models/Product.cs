using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Server.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }
    }
}
