using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API.Models;

namespace WebApplication_API.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        [HttpGet("show1product")]
        [Produces("application/json")]
        public async Task<IActionResult> ShowProduct()
        {
            try
            {
                var product = new Product
                {
                    Id = "asd",
                    Name = "NAme 1",
                    Price = 1213.132,
                };

                return Ok(product);
            }
            catch
            {

                return BadRequest();
            }
        }

        [HttpGet("showproduct")]
        [Produces("application/json")]
        public async Task<IActionResult> ShowAllProduct()
        {
            try
            {
                var products = new List<Product>
                {
                    new Product {
                    Id = "asd",
                    Name = "NAme 1",
                    Price = 1213.132,
                },
                    new Product {
                    Id = "asd",
                    Name = "NAme 2",
                    Price = 1213.132,
                },
                    new Product {
                    Id = "asd",
                    Name = "NAme 3",
                    Price = 1213.132,
                },
            };


                return Ok(products);
            }
            catch
            {

                return BadRequest();
            }
        }
    }
}