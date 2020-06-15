using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication_Server.Models;

namespace WebApplication_Server.Controllers
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
        [Produces("text/html")]
        public async Task<IActionResult> Demo2()
        {
            //middleware
            try
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
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("demo3/{fullname}")]
        [Produces("text/plain")]
        public async Task<IActionResult> Demo3(string fullname)
        {

            try
            {
                return Ok("hiiiii " + fullname);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("tong2so/{num1}/{num2}")]
        [Produces("text/plain")]
        public async Task<IActionResult> Tong(int num1, int num2)
        {
            try
            {
                return Ok(num1 + num2);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [Produces("application/json")]
        [HttpGet("demo4")]
        public async Task<IActionResult> Demo4()
        {
            try
            {
                var product = new Product
                {
                    Id = "asd",
                    Name = "asda",
                    Price = 10.1,
                    Status = true,
                    Quantity = 10,
                };


                return Ok(product);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("demo5")]
        public async Task<IActionResult> Demo5()
        {
            try
            {
                var products = new List<Product>
                {
                    new Product {
                    Id = "asd",
                    Name = "asda",
                    Price = 10.1,
                    Status = true,
                    Quantity = 10,
                    },

                    new Product {
                        Id = "asd",
                        Name = "asda",
                        Price = 10.1,
                        Status = true,
                        Quantity = 10,
                    },
                    new Product {
                        Id = "asd",
                        Name = "asda",
                        Price = 10.1,
                        Status = true,
                        Quantity = 10,
                    },
                    new Product {
                        Id = "asd",
                        Name = "asda",
                        Price = 10.1,
                        Status = true,
                        Quantity = 10,
                    },
                };


                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("demo6")]
        public async Task<IActionResult> Demo6()
        {
            try
            {
                var invoices = new List<Invoice> {
                    new Invoice
                    {
                        Id = "asd",
                        Name = "asda",
                        Payment = "Momo",
                        Customer = new Customer
                        {
                            Id = "asdfaf",
                            Name = "askjdjjn",
                            Address =" asdkha",
                            Email = "asdal@sada",
                        },
                        invoiceDetails = new List<InvoiceDetail>
                        {
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                        }
                    },
                    new Invoice
                    {
                        Id = "asd",
                        Name = "asda",
                        Payment = "Momo",
                        Customer = new Customer
                        {
                            Id = "asdfaf",
                            Name = "askjdjjn",
                            Address =" asdkha",
                            Email = "asdal@sada",
                        },
                        invoiceDetails = new List<InvoiceDetail>
                        {
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                        }
                    },
                    new Invoice
                    {
                        Id = "asd",
                        Name = "asda",
                        Payment = "Momo",
                        Customer = new Customer
                        {
                            Id = "asdfaf",
                            Name = "askjdjjn",
                            Address =" asdkha",
                            Email = "asdal@sada",
                        },
                        invoiceDetails = new List<InvoiceDetail>
                        {
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                            new InvoiceDetail
                            {
                                Id = "dasda",
                                Name = "asda",
                                Price = 212,
                                Quantity = 10,
                            },
                        }
                    },
                };
                return Ok(invoices);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //[Consumes("application/json")]
        [Produces("application/json")]
        [HttpPost("demo7")]
        public async Task<IActionResult> Demo7([FromBody] Product product)
        {
            try
            {
                Debug.WriteLine("Product info - POST");
                Debug.WriteLine("id: " + product.Id);
                Debug.WriteLine("name " + product.Name);
                product.Id = "kjadkj";
                product.Name = "asdadn";

                return Ok(product);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}