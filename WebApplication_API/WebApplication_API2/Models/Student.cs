using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_API2.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public Faculty Faculty { get; set; }
        public List<Course> Courses { get; set; }
    }
}
