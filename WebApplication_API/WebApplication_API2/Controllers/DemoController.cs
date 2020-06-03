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
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPost("create")]
        public  async Task<IActionResult> Create([FromBody] Product product)
        {
            try
            {
                Debug.WriteLine("Product info - create ");
                Debug.WriteLine("id: " + product.Id);
                Debug.WriteLine("name : " + product.Name);
                Debug.WriteLine("price: " + product.Price);
                product.Id = "asdas";
                product.Name = "Tesdasd";
                return Ok(product);
            }
            catch 
            {

                return BadRequest();
            }
        }

        [Produces("application/json")]
        [Consumes("application/json")]
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            try
            {
                Debug.WriteLine("Product info - create ");
                Debug.WriteLine("id: " + product.Id);
                Debug.WriteLine("name : " + product.Name);
                Debug.WriteLine("price: " + product.Price);
                return Ok(product);
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                Debug.WriteLine("deleted id : " + id);
                return Ok();
            }
            catch 
            {

                return BadRequest();
            }
        }
    }
}