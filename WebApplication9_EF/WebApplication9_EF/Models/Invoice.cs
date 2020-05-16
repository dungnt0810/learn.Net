using System;
using System.Collections.Generic;

namespace WebApplication9_EF.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Created { get; set; }
        public string Payment { get; set; }
        public string Status { get; set; }
        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
