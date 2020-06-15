using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Middleware.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [HttpGet("demo1")]
        [Produces("text/plain")]
        public async Task<IActionResult> Demo1()
        {
            //middleware
            try
            {
                return Ok("demo1");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("demo2")]
        [Produces("text/plain")]
        public async Task<IActionResult> Demo2()
        {
            try
            {
                return Ok("demo2");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}