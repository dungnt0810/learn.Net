using System;
using System.Collections.Generic;

namespace WebApplication9_FlowerShop.Models
{
    public partial class Account
    {
        public Account()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
