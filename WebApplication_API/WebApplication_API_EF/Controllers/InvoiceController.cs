using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_API_EF.Models.Repositories;

namespace WebApplication_API_EF.Controllers
{
    [Route("api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private IInvoiceRepository invoiceRepository;

        public InvoiceController(IInvoiceRepository _invoiceRepository)
        {
            invoiceRepository = _invoiceRepository;
        }

        [HttpGet("findall")]
        [Produces("application/json")]
        public async Task<IActionResult> All()
        {
            try
            {
                var invoices =  invoiceRepository.GetAll().ToList();
                return Ok(invoices);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
