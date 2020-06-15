using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_testAPI.Models
{
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }
    }
}
