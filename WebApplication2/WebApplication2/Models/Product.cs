﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string photo { get; set; }
        public DateTime created { get; set; }

    }
}