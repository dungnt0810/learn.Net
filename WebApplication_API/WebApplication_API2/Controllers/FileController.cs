using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API2.Models;

namespace WebApplication_API2.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        //interface hỗ trợ upload file ở trong thư viện Microsoft.AspNetCore.Hosting;
        private IWebHostEnvironment iWebHostEnvironment;

        public FileController(IWebHostEnvironment _iWebHostEnvironment)
        {
            iWebHostEnvironment = _iWebHostEnvironment;
        }


        [HttpPost("uploadfile")]
        public async Task<IActionResult> GetFileUpload(IFormFile file)
        {
            try
            {
                Debug.WriteLine("File name : " + file.FileName);
                Debug.WriteLine("File Size : " + file.Length);
                Debug.WriteLine("File type : " + file.ContentType);

                //Save file
                var path = Path.Combine(iWebHostEnvironment.WebRootPath, "Uploads", file.FileName);
                var fileStream = new FileStream(path, FileMode.Create);
                await file.CopyToAsync(fileStream);

                return Ok();
            }
            catch 
            {

                return BadRequest();
            }
        }

        [HttpPost("uploadmultifile")]
        public async Task<IActionResult> GetMultiFileUpload(List<IFormFile> files)
        {
            try
            {
                Debug.WriteLine("files : " + files.Count);
                foreach (var file in files)
                {
                    Debug.WriteLine("File name : " + file.FileName);
                    Debug.WriteLine("File Size : " + file.Length);
                    Debug.WriteLine("File type : " + file.ContentType);
                    Debug.WriteLine("---------------------------------");

                    //Save file
                    var path = Path.Combine(iWebHostEnvironment.WebRootPath, "Uploads", file.FileName);
                    var fileStream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(fileStream);
                }

               
                return Ok();
            }
            catch 
            {

                return BadRequest();
            }
        }

        [HttpGet("readfilecsv")]
        public async Task<IActionResult> ReadFileCSV()
        {
            try
            {
                var path = Path.Combine(iWebHostEnvironment.WebRootPath,"Uploads", "product.csv");

                //var filestream = new FileStream(path, FileMode.Open);
                //var file = new StreamReader(filestream);
                //var lines = file.ReadToEnd();
                var products = new List<Product>();
                string[] lines = System.IO.File.ReadAllLines(path);
                Debug.WriteLine(lines.Length);

                foreach (var line in lines)
                {
                    string[] rs = line.Split(new char[] { ',' });
                    var product = new Product
                    {
                        Id = rs[0],
                        Name = rs[1],
                        Price = double.Parse(rs[2]),
                    };
                    products.Add(product);
                }

                return Ok(products);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}