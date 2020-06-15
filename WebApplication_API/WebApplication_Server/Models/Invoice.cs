using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApplication_Server.Models
{
    public class Invoice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Payment { get; set; }

        public Customer Customer { get; set; }
        public List<InvoiceDetail> invoiceDetails { get; set; }
    }
}
