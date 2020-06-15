using System;
using System.Collections.Generic;
using WebApplication_API_EF.Models.EFCore;

namespace WebApplication_API_EF.Models
{
    public partial class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
