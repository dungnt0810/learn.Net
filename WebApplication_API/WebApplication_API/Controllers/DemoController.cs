using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApplication_API.Controllers
{
    [Route("api/demo")]
    public class DemoController : Controller
    {

        [HttpGet("demo1")]
        [Produces("text/plain")]
        public async Task<IActionResult> Demo1()
        {
            try
            {

                return Ok("Hello");
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("demo2")]
        [Produces("text/html")]
        public async Task<IActionResult> Demo2()
        {
            try
            {
                var str = "<h3><u>Hiiiiiiiiiiiiiiii</u></h3>";
                return new ContentResult
                {
                    Content = str,
                    ContentType = "text/html",
                    StatusCode = (int)System.Net.HttpStatusCode.OK, 
                };
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("demo3/{id}")]
        [Produces("text/plain")]
        public async Task<IActionResult> Demo3(int id)
        {
            try
            {

                return Ok("Hello " + id);
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("average")]
        [Produces("text/json")]
        public async Task<IActionResult> Average(int[] arr)
        {
            try
            {

                return Ok(arr.Average());
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("xeploai")]
        [Produces("text/json")]
        public async Task<IActionResult> XepLoai(int[] arr)
        {
            try
            {
               // Array.Sort(arr);
                return Ok(JsonConvert.SerializeObject(arr));
            }
            catch
            {

                return BadRequest();
            }
        }


        [HttpGet("convert/{type}/{temp}")]
        [Produces("text/plain")]
        public async Task<IActionResult> Convert(string type, double temp)
        {
            try
            {
                if (type.Equals("ctof"))
                {
                    var f = temp * 1.8 + 32;
                    return Ok(f);
                }
                if (type.Equals("ftoc"))
                {
                    var c = (temp - 32) / 1.8;
                    return Ok(c);
                }
                return Ok("invalid");
            }
            catch
            {

                return BadRequest();
            }
        }



        private IActionResult Ok(object v)
        {
            throw new NotImplementedException();
        }
    }
}