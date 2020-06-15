using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API_EF.Models.Repositories;

namespace WebApplication_API_EF.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository studentRepository;

        public StudentController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        [HttpGet("findall")]
        [Produces("application/json")]
        public async Task<IActionResult> AllProduct()
        {
            try
            {
                var students = studentRepository.GetAll().ToList();
                return Ok(students);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
