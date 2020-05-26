using System;
using System.Collections.Generic;

namespace WebApplication_Authorization.Models
{
    public partial class Account
    {
        public Account()
        {
            RoleAccount = new HashSet<RoleAccount>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
    }
}
