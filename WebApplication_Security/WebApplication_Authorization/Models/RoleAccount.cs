using System;
using System.Collections.Generic;

namespace WebApplication_Authorization.Models
{
    public partial class RoleAccount
    {
        public int AccountId { get; set; }
        public int RoleId { get; set; }
        public bool? Enabled { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
