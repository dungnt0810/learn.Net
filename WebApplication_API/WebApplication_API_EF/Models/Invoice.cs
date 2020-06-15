using System;
using System.Collections.Generic;
using WebApplication_API_EF.Models.EFCore;

namespace WebApplication_API_EF.Models
{
    public partial class Invoice : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Total { get; set; }
        public string Payment { get; set; }
    }
}
