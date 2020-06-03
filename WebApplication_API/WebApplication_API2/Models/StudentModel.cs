using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_API2.Models
{
    public class StudentModel
    {
        private List<Student> students;

        public StudentModel()
        {

            students = new List<Student>
            {
                new Student {
                    Id = "p01", Name = "name 1", Email = "email1", Status = true ,
                    Faculty = new Faculty{
                        Id = "fal 1",
                        Name = "namefal 1",
                    } ,
                    Courses = new List<Course> {
                        new Course {Id = "cour 1", Name = "namecour 1", Score = 10},
                        new Course {Id = "cour 2", Name = "namecour 2", Score = 5},
                        new Course {Id = "cour 3", Name = "namecour 3", Score = 7},
                    } },
                new Student {
                    Id = "p01", Name = "name 1", Email = "email1", Status = true ,
                    Faculty = new Faculty{
                        Id = "fal 1",
                        Name = "namefal 1",
                    } ,
                    Courses = new List<Course> {
                        new Course {Id = "cour 1", Name = "namecour 1", Score = 10},
                        new Course {Id = "cour 2", Name = "namecour 2", Score = 5},
                        new Course {Id = "cour 3", Name = "namecour 3", Score = 7},
                    } },
                new Student {
                    Id = "p01", Name = "name 1", Email = "email1", Status = true ,
                    Faculty = new Faculty{
                        Id = "fal 1",
                        Name = "namefal 1",
                    } ,
                    Courses = new List<Course> {
                        new Course {Id = "cour 1", Name = "namecour 1", Score = 10},
                        new Course {Id = "cour 2", Name = "namecour 2", Score = 5},
                        new Course {Id = "cour 3", Name = "namecour 3", Score = 7},
                    } },
            };
        }

        public List<Student> findAll => students;

        public Student find(String id) => students.Where(s => s.Id == id).FirstOrDefault();

        public List<Student> findByFaculty(string facultyId) => students.Where(s => s.Faculty.Id == facultyId).ToList();

        public List<Student> listOfNStudent(int n) => students.Take(n).ToList();

        public int totalOfStudents => students.Count();

        //public List<double> lisOfScoreStudent => students.SingleOrDefault().Courses.Average(s => s.Score);
    }

}

