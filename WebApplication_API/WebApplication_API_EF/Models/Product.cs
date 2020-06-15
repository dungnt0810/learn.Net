using System;
using System.Collections.Generic;

namespace WebApplication_API_EF.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
