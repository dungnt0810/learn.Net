using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class StudentModel
    {
        public  Student find()
        {
            return new Student
            {
                Id = "sd1",
                Name = "name 1",
                Address = "Address 1",
                Birthday = DateTime.Parse("10/20/2000"),
                faculty = new Facutly
                {
                    Id = "id",
                    Name = "Cntt",
                },
                courses = new List<Course>
                {
                    new Course
                    {
                        Id = "11",
                        Name = "probability",
                        Score = 10
                    },
                    new Course
                    {
                        Id = "10",
                        Name = "Physic 1",
                        Score = 8
                    },
                    new Course
                    {
                        Id = "12",
                        Name = "Physic 3",
                        Score = 9
                    },
                },
            };
        }

    }
}
