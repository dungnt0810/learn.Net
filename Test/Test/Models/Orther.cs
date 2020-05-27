using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Orther
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Datecreation { get; set; }
        public bool Status { get; set; }
        public string Payment { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
