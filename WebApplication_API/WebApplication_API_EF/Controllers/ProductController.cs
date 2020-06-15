using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API_EF.Models;

namespace WebApplication_API_EF.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DbSession6Context db;

        public ProductController(DbSession6Context _db)
        {
            db = _db;
        }

        [HttpGet("allproduct")]
        [Produces("application/json")]
        public async Task<IActionResult> AllProduct()
        {
            try
            {
                var products = db.Product.ToList();
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("frommintomax/{min}/{max}")]
        [Produces("application/json")]
        public async Task<IActionResult> ProductFromMinToMax(int min, int max)
        {
            try
            {
                var products = db.Product.Where(p => p.Price <= max && p.Price >= min).ToList();
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("descendingAllProduct")]
        [Produces("application/json")]
        public async Task<IActionResult> DescendingAllProduct()
        {
            try
            {
                var products = db.Product.OrderByDescending(p => p.Price).ToList();
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("newProduct/{n}")]
        [Produces("application/json")]
        public async Task<IActionResult> NewProduct(int n)
        {
            try
            {
                if (n <= db.Product.Count())
                {
                    var products = db.Product.OrderByDescending(p => p.Id).Take(n).ToList();
                    return Ok(products);
                }
                else
                {
                    return Ok("askjd");
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("search/{key}")]
        [Produces("application/json")]
        public async Task<IActionResult> SearchByName(string key)
        {
            try
            {
                var products = db.Product.Where(p => p.Name.Contains(key)).ToList();
                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("total")]
        [Produces("application/json")]
        public async Task<IActionResult> TotalOfProduct()
        {
            try
            {
                var total = db.Product.Sum(p => p.Price);
                return Ok(total);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("add")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            try
            {
                db.Product.Add(product);
                db.SaveChanges();
                return Ok(product);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}