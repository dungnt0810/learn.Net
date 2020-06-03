using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API2.Models;

namespace WebApplication_API2.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //xay dung api thuc hien cac yeue cau sau
        
        //liet ke n sinh vien
        //tinh diem trung binh cua sinh vien
        //dem co bao nhie sinh vien hoc trong 1 khoa
        //them sinh vien moi (POST)
        //cap nhat thong tin sinh vien
        //XOa sinh vien th eo id


        [HttpGet("allstudent")]
        public async Task<IActionResult> AllStudent()
        {
            try
            {
                var studentModel = new StudentModel();
                
                return Ok(studentModel.findAll);
            }
            catch 
            {

                return BadRequest();
            }
        }


        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetStudent(string id)
        {
            try
            {
                var studentModel = new StudentModel();

                return Ok(studentModel.find(id));
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("student/faculty/{facultyId}")]
        public async Task<IActionResult> GetStudentByFacultyId(string facultyId)
        {
            try
            {
                var studentModel = new StudentModel();

                return Ok(studentModel.findByFaculty(facultyId));
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("student/listofN/{n}")]
        public async Task<IActionResult> GetNStudent(int n)
        {
            try
            {
                var studentModel = new StudentModel();
                if (n > studentModel.totalOfStudents)
                {
                    return Ok("ahahhah ngu vl");
                }
                else
                {
                    return Ok(studentModel.listOfNStudent(n));
                }
                
            }
            catch
            {

                return BadRequest();
            }
        }

        //[HttpGet("student/listofScoreStu")]
        //public async Task<IActionResult> GetListOfScoreStudent()
        //{
        //    try
        //    {

        //    }
        //    catch
        //    {

        //        return BadRequest();
        //    }
        //}
    }
}