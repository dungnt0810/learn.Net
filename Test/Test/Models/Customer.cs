using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orther = new HashSet<Orther>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Orther> Orther { get; set; }
    }
}
